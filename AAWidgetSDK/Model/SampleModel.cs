using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAWidgetSDK.Model
{
    public class SampleModel
    {
        public static Airport sampleAirport_SVO
        {
            get
            {
                var airport = new Airport();
                airport.offset = 3.0;
                airport.city = "Moscow";
                airport.code = "SVO";
                airport.name = "Sheremetyevo Airport";
                airport.latitude = 55.966324;
                airport.longitude = 37.416573;
                airport.country = "RU";
                airport.countryFullName = "Russian Federation";
                return airport;
            }
        }

        public static Airport sampleAirport_JFK
        {
            get
            {
                var airport = new Airport();
                airport.offset = -4.0;
                airport.city = "New York";
                airport.code = "JFK";
                airport.name = "John F. Kennedy International Airport";
                airport.latitude = 40.642334;
                airport.longitude = -73.78817;
                airport.country = "US";
                airport.countryFullName = "United States";
                return airport;
            }
        }

        public static FlightInfo sampleFlight
        {
            get
            {
                var flight = new FlightInfo();
                flight.airportOriginCode = sampleAirport_SVO.code;
                flight.airportDestinationCode = sampleAirport_JFK.code;
                flight.airline = sampleAirline;
                flight.number = "100";
                flight.departureDatetime = DateTime.Now.AddHours(20);
                flight.arrivalDatetime = DateTime.Now.AddHours(30);
                flight.id = "sample";
                flight.departureGate = "40";
                flight.departureTerminal = "F";
                flight.arrivalGate = "88";
                flight.arrivalTerminal = "A";
                return flight;

            }
        }

        public static Airline sampleAirline
        {
            get
            {
                var airline = new Airline();
                airline.code = "SU";
                airline.phone = "+7 945 654 32 43";
                airline.twitter = "aeroflot";
                airline.website = "www.aeroflot.ru";
                airline.email = "aeroflot@aeroflot.com";
                airline.iata = "SU";
                airline.icao = "ALF";
                airline.name = "Aeroflot - Russian airlines";
                return airline;
            }
        }

        public static Trip sampleTrip
        {
            get
            {
                var trip = new Trip();
                trip.tripId = "sampleTrip";
                var flight = sampleFlight;
                trip.alertsPurchased = true;
                trip.arrivalAirportCode = sampleAirport_JFK.code;
                trip.arrivalDateTime = flight.arrivalDatetime.Value;
                trip.arrivalDateTimeUTC = trip.arrivalDateTime.ToUniversalTime();
                trip.smsPurchased = true;
                trip.departureAirportCode = sampleAirport_SVO.code;
                trip.flights = new List<FlightInfo>() {flight};
                trip.departureDateTime = flight.departureDatetime.Value;
                trip.departureDateTimeUTC = trip.departureDateTime.ToUniversalTime();
                trip.pushEnabled = true;
                return trip;
            }
        }
    }
}
