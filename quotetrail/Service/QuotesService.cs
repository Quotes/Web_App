﻿using System.Collections.Generic;
using quotetrail.Models;
using System.Web.Mvc;
using quotetrail.Service;

namespace quotetrail.Service
{
    class QuotesService
    {
        public bool AddQuote(Quote quote)
        {
            //TODO: contact the service and send the quote object and return the result
            return false ? true: false;
        }

        public List<string> GetProjects()
        {
            var projectsList = new List<string> { "Abcam", "Pam", "Blue Label", "sathyam" };
            return projectsList;
        }

        public string GetQuotes(string project)
        {
            //TODO: send the project name to the web service and get the quotes Json and return it
            return @" {""quotes"":[{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""quote1 asd a sda sd as d a sda s dasd a sdasdasd asd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""},{""quote"": ""sadasd a s asd asd a sd a sd a  sdada d a sd"",""quoted_by"": ""JOHN"",""date"": ""13-JAN-2011""}]}";
        }

    }
}