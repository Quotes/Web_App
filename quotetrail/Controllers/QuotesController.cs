using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            quote.User = User.Identity.Name;
            quote.Status = quote.AddQuote() ? "added" : "failed";
            return PartialView("AddQuote", quote);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetProjects()
        {
            var projectsList = new List<string> { "Abcam", "Pam", "Blue Label", "sathyam" };
            var x = Json(projectsList);
            return x;
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetQuotes(string project)
        {
            var x =
                @" {""quotes"":[{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""}]}";
            return Json(x);

        }
    }
}
