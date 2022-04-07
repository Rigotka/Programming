using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private int _flightTime;

        public string Departure { get; set; }

        public string Destination { get; set; }

        public int FlightTime
        {
            get
            { 
                return _flightTime; 
            }

            set
            {
                Validator.AssertOnPositiveValue(value, nameof(FlightTime));
                _flightTime = value;
            }
        }

        public Flight() 
        {
        }

        public Flight(string departure, string destination, int flightTime)
        {
            Departure = departure;
            Destination = destination;
            FlightTime = flightTime;
        }
    }
}