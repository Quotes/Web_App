using System.Collections.Generic;
using quotetrail.Models;
using System.Web.Mvc;
using quotetrail.Service;

namespace quotetrail.Service
{
    class QuotesService
    {
        public Quote AddQuote(Quote quote)
        {
            //TODO: contacr the service and set the respective in the quote object
            quote.Status = false ? "added" : "failed";
            //TODO: Return the quote Object
            return quote;
        }

        public List<string> GetProjects()
        {
            var projectsList = new List<string> { "Abcam", "Pam", "Blue Label", "sathyam" };
            return projectsList;
        }

        public string GetQuotes(string project)
        {
            //TODO: send the project name to the web service and get the quotes Json and return it
            return @" {""quotes"":[{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""}]}";
        }

    }
}