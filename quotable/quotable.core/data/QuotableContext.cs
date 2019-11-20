using Microsoft.EntityFrameworkCore;

namespace quotable.core
{
    /// <summary>
	/// The database context that provides access to quote and other data.
	/// </summary>
	public class QuotableContext : DbContext
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public QuotableContext(DbContextOptions options) : base(options)
        {

        }

        /// <summary>
        /// Used to access quotes in the database.
        /// </summary>
        public DbSet<Quote> Quotes { get; set; }

        /// <summary>
        /// Used to access authors in the database.
        /// </summary>
        public DbSet<Author> Authors { get; set; }

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuoteAuthor>().HasKey(x => new { x.QuoteId, x.AuthorId });
        }
    }
}
