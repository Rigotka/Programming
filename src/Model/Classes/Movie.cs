using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    public class Movie
    {
        private int _duration;

        private int _year;

        private double _rating;

        public string Title { get; set; }

        public string Genre { get; set; }

        public int Duration
        {
            get 
            { 
                return _duration; 
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Duration));
                _duration = value;
            }
        }

        public int Year
        {
            get 
            { 
                return _year; 
            }
            set
            {
                Validator.AssertValueInRange(value, 1990, 2022, nameof(Year));
                _year = value;
            }
        }

        public double Rating
        {
            get 
            { 
                return _rating; 
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }

        public Movie() 
        { 
        }

        public Movie(string title, int duration, int year, string genre, double rating)
        {
            Title = title;
            Duration = duration;
            Year = year;
            Genre = genre;
            Rating = rating;
        }
    }
}
