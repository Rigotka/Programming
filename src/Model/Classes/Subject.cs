using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    public class Subject
    {
        private int _mark;

        public string Name { get; set; }

        public string Lecturer { get; set; }

        public int Mark
        {
            get 
            { 
                return _mark; 
            }

            set
            {
                Validator.AssertValueInRange(value, 0, 5, nameof(Mark));
                _mark = value;
            }
        }

        public Subject() 
        {
        }

        public Subject(string name, string lecturer, int mark)
        {
            Name = name;
            Lecturer = lecturer;
            Mark = mark;
        }
    }
}
