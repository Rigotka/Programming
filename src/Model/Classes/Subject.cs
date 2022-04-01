using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    public class Subject
    {
        private int _score;

        public string Name { get; set; }

        public string Lecturer { get; set; }

        public int Score
        {
            get { return _score; }
            set
            {
                if (value < 0 || value > 5)
                    throw new ArgumentException($"The score must be between 0 and 5, but was {value}");

                _score = value;
            }
        }

        public Subject() 
        {
        }

        public Subject(string name, string lecturer, int score)
        {
            Name = name;
            Lecturer = lecturer;
            Score = score;
        }
    }
}
