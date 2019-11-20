using System;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using quotable.core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
namespace quotable.console
{
    class Program 
    {
        /// <summary>
        /// Main creates an instance of SimpleRandomQuoteProvider named simple that
        /// then creates 7 simple quotes in SimpleRandomQuoteProvider from quotable.core
        /// 
        /// Main then creates a DefaultRandomQuoteGenerator that prints out quotes 
        /// from DefaultRandomQuoteGenerator in quotable.core
        /// </summary>
        /// <param name="args"></param>
        // [miko]
        // entering the world of async
        // see the stackoverflow entry below if your visual studio 
        // is complaining about not finding a main method.
        // https://stackoverflow.com/a/44254451/167160
        static async Task Main(string[] args)
        {

            SimpleRandomQuoteProvider simple = new SimpleRandomQuoteProvider();

            foreach (var s in simple.getQuotes(7))
            {
                Console.WriteLine(s);
            }

            string[] quo = new string[4] { "one", "two", "three", "four" };

            DefaultRandomQuoteGenerator defaultRand = new DefaultRandomQuoteGenerator(quo);

            // [miko]
            // even in a plain console application, we can use the dependency injection functionality
            // provided by microsoft...it is not limited to only aspnet.core applications.
            var container = new ServiceCollection();

            // setup to use a sqlite database
            container.AddDbContext<QuotableContext>(options => options.UseSqlite("Data Source=quote.db"), ServiceLifetime.Transient);
            // [miko]
            // getting a context that has already been disposed.
            // yup.
            // AddDbContext is implicitly scoped.
            // explicitly set the service lifetime
            // https://github.com/aspnet/EntityFrameworkCore/issues/4988

            var provider = container.BuildServiceProvider();

            using (var context = provider.GetService<QuotableContext>())
            {
                // [miko]
                // good for testing
                // bad for production...
                await context.Database.EnsureDeletedAsync();

                // [miko]
                // if the database doesn't exist it will be created
                // this should ideally only be run once in an application lifetime
                // this only ensure existence, this does not perform migrations.
                var dbDidntExist = await context.Database.EnsureCreatedAsync();

                if (dbDidntExist)
                {
                    await PopulateDatabase(context);
                }
            }

            using (var context = provider.GetService<QuotableContext>())
            {
                var quotes = context.Quotes
                                        .Include(d => d.QuoteAuthor)
                                        .ThenInclude(x => x.Author);

                foreach (var quote in quotes)
                {
                    Console.WriteLine($"quote.id = {quote.Id}");
                    Console.WriteLine($"quote.title = {quote.Body}");

                    foreach (var author in quote.Authors)
                    {
                        Console.WriteLine($"quote.author.id = {author.Id}");
                        Console.WriteLine($"quote.author.firstname = {author.FirstName}");
                        Console.WriteLine($"quote.author.firstname = {author.LastName}");
                    }

                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }

        private static async Task PopulateDatabase(QuotableContext context)
        {
            var author1 = new Author()
            {
                FirstName = "Dr",
                LastName = "Seuss"
            };
            var author2 = new Author()
            {
                FirstName = "Mr",
                LastName = "Spock"
            };
            var author3 = new Author()
            {
                FirstName = "Mr",
                LastName = "Tuvok"
            };

            var quote1 = new Quote();
            quote1.Body = "quote one body";

            var quote2 = new Quote();
            quote2.Body = "quote 2 body";

            var quote3 = new Quote();
            quote3.Body = "quote 3 body";

            var qa1 = new QuoteAuthor() { Quote = quote1, Author = author1 };
            var qa2 = new QuoteAuthor() { Quote = quote2, Author = author2 };
            var qa3 = new QuoteAuthor() { Quote = quote3, Author = author1 };
            var qa4 = new QuoteAuthor() { Quote = quote3, Author = author2 };
            var qa5 = new QuoteAuthor() { Quote = quote3, Author = author3 };

            context.AddRange(qa1, qa2, qa3, qa4, qa5);

            await context.SaveChangesAsync();
        }
    }
}
