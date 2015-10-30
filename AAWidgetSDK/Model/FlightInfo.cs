using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAWidgetSDK.Model
{
    public class FlightInfo
    {
        private string _Id;
        private string _TripId;
        private string _Carrier;
        private string _Number;
        private string _Status1;
        private string _AirportOriginCode;
        private string _AirportDestinationCode;
        private Nullable<DateTime> _DepartureDatetime;
        private Nullable<DateTime> _DepartureDatetimeEstimate;
        private Nullable<DateTime> _DepatureDatetimeRunwaySchedule;
        private Nullable<DateTime> _DepartureDatetimeRunwayEstimate;
        private Nullable<DateTime> _ArrivalDatetime;
        private Nullable<DateTime> _ArrivalDatetimeEstimate;
        private Nullable<DateTime> _ArrivalDatetimeRunwaySchedule;
        private Nullable<DateTime> _ArrivalDatetimeRunwayEstimate;
        private string _DepartureCity;
        private string _ArrivalCity;
        private string _DepartureTerminal;
        private string _DepartureGate;
        private string _ArrivalTerminal;
        private string _ArrivalGate;
        private Aircraft _Aircraft;
        private string _DepartureDelayActual;
        private string _ArrivalDelayActual;
        private System.Nullable<double> _DepartureOffset;
        private System.Nullable<double> _ArrivalOffset;
        private string _MainAirlineName;
        private System.Nullable<int> _Purchased;
        private System.Nullable<int> _CheckedIn;
        private int _PushEnabled;
        private Nullable<DateTime> _DepartureDateActual;
        private Nullable<DateTime> _ArrivalDateActual;
        private int _SmsEnabled;
        private System.Nullable<int> _Finished;
        private Nullable<DateTime> _LastUpdated;
        private Nullable<DateTime> _CreatedAt;
        private System.Nullable<double> _Distance;
        private System.Nullable<double> _Duration;
        private Nullable<DateTime> _ArrivalDatetimeUtc;
        private Nullable<DateTime> _DepartureDatetimeUtc;
        private string _Seat;
        private Airline _Airline;
        private Airport _AirportDeparture;
        private Airport _AirportArrival;

        public string id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string tripId
        {
            get { return _TripId; }
            set { _TripId = value; }
        }

        public string carrier
        {
            get { return _Carrier; }
            set { _Carrier = value; }
        }

        public string number
        {
            get { return _Number; }
            set { _Number = value; }
        }

        public string status
        {
            get { return _Status1; }
            set { _Status1 = value; }
        }

        public string airportOriginCode
        {
            get { return _AirportOriginCode; }
            set { _AirportOriginCode = value; }
        }

        public string airportDestinationCode
        {
            get { return _AirportDestinationCode; }
            set { _AirportDestinationCode = value; }
        }

        public DateTime? departureDatetime
        {
            get { return _DepartureDatetime; }
            set { _DepartureDatetime = value; }
        }

        public DateTime? departureDatetimeEstimate
        {
            get { return _DepartureDatetimeEstimate; }
            set { _DepartureDatetimeEstimate = value; }
        }

        public DateTime? depatureDatetimeRunwaySchedule
        {
            get { return _DepatureDatetimeRunwaySchedule; }
            set { _DepatureDatetimeRunwaySchedule = value; }
        }

        public DateTime? departureDatetimeRunwayEstimate
        {
            get { return _DepartureDatetimeRunwayEstimate; }
            set { _DepartureDatetimeRunwayEstimate = value; }
        }

        public DateTime? arrivalDatetime
        {
            get { return _ArrivalDatetime; }
            set { _ArrivalDatetime = value; }
        }

        public DateTime? arrivalDatetimeEstimate
        {
            get { return _ArrivalDatetimeEstimate; }
            set { _ArrivalDatetimeEstimate = value; }
        }

        public DateTime? arrivalDatetimeRunwaySchedule
        {
            get { return _ArrivalDatetimeRunwaySchedule; }
            set { _ArrivalDatetimeRunwaySchedule = value; }
        }

        public DateTime? arrivalDatetimeRunwayEstimate
        {
            get { return _ArrivalDatetimeRunwayEstimate; }
            set { _ArrivalDatetimeRunwayEstimate = value; }
        }

        public string departureCity
        {
            get { return _DepartureCity; }
            set { _DepartureCity = value; }
        }

        public string arrivalCity
        {
            get { return _ArrivalCity; }
            set { _ArrivalCity = value; }
        }

        public string departureTerminal
        {
            get { return _DepartureTerminal; }
            set { _DepartureTerminal = value; }
        }

        public string departureGate
        {
            get { return _DepartureGate; }
            set { _DepartureGate = value; }
        }

        public string arrivalTerminal
        {
            get { return _ArrivalTerminal; }
            set { _ArrivalTerminal = value; }
        }

        public string arrivalGate
        {
            get { return _ArrivalGate; }
            set { _ArrivalGate = value; }
        }

        public Aircraft aircraft
        {
            get { return _Aircraft; }
            set { _Aircraft = value; }
        }

        public string departureDelayActual
        {
            get { return _DepartureDelayActual; }
            set { _DepartureDelayActual = value; }
        }

        public string arrivalDelayActual
        {
            get { return _ArrivalDelayActual; }
            set { _ArrivalDelayActual = value; }
        }

        public double? departureOffset
        {
            get { return _DepartureOffset; }
            set { _DepartureOffset = value; }
        }

        public double? arrivalOffset
        {
            get { return _ArrivalOffset; }
            set { _ArrivalOffset = value; }
        }

        public string mainAirlineName
        {
            get { return _MainAirlineName; }
            set { _MainAirlineName = value; }
        }

        public int? purchased
        {
            get { return _Purchased; }
            set { _Purchased = value; }
        }

        public int? checkedIn
        {
            get { return _CheckedIn; }
            set { _CheckedIn = value; }
        }

        public int pushEnabled
        {
            get { return _PushEnabled; }
            set { _PushEnabled = value; }
        }

        public DateTime? departureDateActual
        {
            get { return _DepartureDateActual; }
            set { _DepartureDateActual = value; }
        }

        public DateTime? arrivalDateActual
        {
            get { return _ArrivalDateActual; }
            set { _ArrivalDateActual = value; }
        }

        public int smsEnabled
        {
            get { return _SmsEnabled; }
            set { _SmsEnabled = value; }
        }

        public int? finished
        {
            get { return _Finished; }
            set { _Finished = value; }
        }

        public DateTime? lastUpdated
        {
            get { return _LastUpdated; }
            set { _LastUpdated = value; }
        }

        public DateTime? createdAt
        {
            get { return _CreatedAt; }
            set { _CreatedAt = value; }
        }

        public double? distance
        {
            get { return _Distance; }
            set { _Distance = value; }
        }

        public double? duration
        {
            get { return _Duration; }
            set { _Duration = value; }
        }

        public DateTime? arrivalDatetimeUtc
        {
            get { return _ArrivalDatetimeUtc; }
            set { _ArrivalDatetimeUtc = value; }
        }

        public DateTime? departureDatetimeUtc
        {
            get { return _DepartureDatetimeUtc; }
            set { _DepartureDatetimeUtc = value; }
        }

        public string seat
        {
            get { return _Seat; }
            set { _Seat = value; }
        }

        public Airport airportDeparture
        {
            get { return _AirportDeparture; }
            set { _AirportDeparture = value; }
        }

        public Airport airportArrival
        {
            get { return _AirportArrival; }
            set { _AirportArrival = value; }
        }

        public Airline airline
        {
            get { return _Airline; }
            set { _Airline = value; }
        }
    }
}
