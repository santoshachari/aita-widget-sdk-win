using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAWidgetSDK.Model
{
    public class Trip
    {
        public string tripId { get; set; }
        public DateTime departureDateTime { get; set; }
        public DateTime departureDateTimeUTC { get; set; }
        public DateTime arrivalDateTime { get; set; }
        public DateTime arrivalDateTimeUTC { get; set; }
        public List<FlightInfo> flights { get; set; }
        public DateTime updatedAt { get; set; } 
        public DateTime createdAt { get; set; }
        public bool alertsPurchased { get; set; }
        public bool smsPurchased { get; set; }
        public bool pushEnabled { get; set; }
        public bool isSample { get; set; }
        public string departureAirportCode { get; set; }
        public string arrivalAirportCode { get; set; }
    }
}
