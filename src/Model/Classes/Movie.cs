using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    class Movie
    {
        public string Title { get; set; }
        private int _duration;
        private int _year;
        private string Genre { get; set; }
        private double _rating;

        public int Duration
        {
            get { return _duration; }
            set
            {
                if ( value <= 0 )
                    throw new ArgumentException("Movie duration should be greater than 0, but was " + value);
                else
                    _duration = value;
            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                if ( value < 1900 || value > 2022 )
                    throw new ArgumentException("Year must be in nature from 1900 to 2022, but was " + value);
                else
                    _year = value;
            }
        }

        public double Rating
        {
            get { return _rating; }
            set
            {
                if ( value < 0 || value > 10 )
                    throw new ArgumentException("The rating should be in nature from 0 to 10, but was " + value);
                else
                    _rating = value;
            }
        }

        public Movie() { }
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
