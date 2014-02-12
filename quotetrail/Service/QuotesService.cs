using System.Collections.Generic;
using quotetrail.Models;
using System.Web.Mvc;
using quotetrail.Service;

namespace quotetrail.Service
{
    using System;
    using System.Configuration;
    using System.Globalization;

    using Newtonsoft.Json;

    using RestSharp;

    class QuotesService
    {
        public bool AddQuote(Quote quote)
        {
            //TODO: contact the service and send the quote object and return the result
            try
            {
                var client = new RestClient(ConfigurationManager.AppSettings["AddQuotesEndPoint"]);
                var request = new RestRequest(Method.POST);
                request.AddHeader("Accept", "application/json");
                string json = JsonConvert.SerializeObject(quote);

                request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
                request.RequestFormat = DataFormat.Json;

                IRestResponse response = client.Execute(request);
                var content = response.Content;
                var x = content.ToString(CultureInfo.InvariantCulture);
                // this x should be true or OK which says that the quote was successfully added.
                Console.WriteLine(x);
                return true;
            }
            catch (Exception ex)
            {
                var x = ex.Message;
                Console.WriteLine(x);
            }
            return false;
        }

        public List<string> GetProjects()
        {
            // hit the end point GetProjectNamesEndPoint
            var projectsList = new List<string> { "Abcam", "Pam", "Blue Label", "sathyam" };
            return projectsList;
        }

        public string GetQuotes(string project)
        {
            try
            {
                var client = new RestClient(ConfigurationManager.AppSettings["GetQuotesEndPoint"]);
                var request = new RestRequest(Method.POST);
                var json ="";
                IRestResponse response = client.Execute(request);
                var content = response.Content;
                var x = content.ToString(CultureInfo.InvariantCulture);
                Console.WriteLine(x);
                // return the value returned by the service to controller
            }
            catch (Exception ex)
            {
                var x = ex.Message;
                Console.WriteLine(x);
                // check out a way we can display that error happened while pulling the quote values.
            }
            //TODO: send the project name to the web service and get the quotes Json and return it
            return @" {""quotes"":[{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""}]}";
        }

    }
}