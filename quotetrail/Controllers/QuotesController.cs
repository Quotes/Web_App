using System.Collections.Generic;
using System.Web.Mvc;
using quotetrail.Service;

namespace quotetrail.Controllers
{
    public class QuotesController : Controller
    {
        //
        // GET: /Quotes/

        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult AddQuote(Models.Quote quote)
        {
            var quotesservices = new QuotesService();
            quote.User = User.Identity.Name;
            quote = quotesservices.AddQuote(quote);
            return PartialView("AddQuote", quote);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetProjects()
        {
            var quotesservices = new QuotesService();
            var projectsList = quotesservices.GetProjects();
            return Json(projectsList); ;
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetQuotes(string project)
        {
             var quotesservices = new QuotesService();
             var quotes = quotesservices.GetQuotes(project);
            return Json(quotes);

        }
    }
}
