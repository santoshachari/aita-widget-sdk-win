using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAWidgetSDK.Model
{
    public sealed class Airport
    {
        public string code { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string countryFullName { get; set; }
        public double offset { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string venueID { get; set; }
        public string phone { get; set; }
        public string url { get; set; }
        public string continent { get; set; }
    }
}
