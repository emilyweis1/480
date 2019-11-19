using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;


namespace quotable.api.Controllers
{
    ///// <summary>
    ///// TODO
    ///// </summary>
    //[Route("api/")]
    //[ApiController]
    //public class HomeController : ControllerBase
    //{
    //    //private LinkGenerator LinkGenerator { get; }
    //    private IHttpContextAccessor Context { get; }

    //    /// <summary>
    //    /// TODO
    //    /// </summary>
    //    /// <param name="context"></param>
    //    /// <param name="linkGenerator"></param>
    //    //public HomeController(IHttpContextAccessor context, LinkGenerator linkGenerator)
    //    //{
    //    //    LinkGenerator = linkGenerator ?? throw new ArgumentNullException(nameof(linkGenerator));
    //    //    Context = context ?? throw new ArgumentNullException(nameof(context));
    //    //}

    //    // GET: api/Home
    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <returns></returns>
    //    [HttpGet]
    //    public IEnumerable<Data> Get()
    //    {
    //        var data = new Data();
    //        data.Key = "quotable";
    //        //data.Uri = LinkGenerator.GetUriByAction(Context.HttpContext,
    //                           //    controller: "Quotable",
    //                           //    action: "Get"
    //                           //);
    //        return new Data[] { data };
    //    }

    //    //public class Data
    //    //{
    //    //    public string Key { get; set; }
    //    //    public string Uri { get; set; }
    //    //}
    //}
}
