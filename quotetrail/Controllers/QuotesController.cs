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
        public JsonResult AddQuote(Models.Quote quote)
        {
            if (!quote.IsValid)
            {
            var quotesservices = new QuotesService();
            quote.User = User.Identity.Name;
            return Json(quotesservices.AddQuote(quote));
            }
            return Json(false);
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
