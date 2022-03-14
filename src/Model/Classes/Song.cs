using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    class Song
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        private int _duration;

        public int Duration
        {
            get { return _duration; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Song duration must be greater than 0, but was " + value);
                else
                    _duration = value;
            }
        }

        public Song() { }
        public Song(string title, string author, string genre, int duration)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Duration = duration;
        }
    }
}
