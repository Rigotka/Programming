using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Classes;
using Programming.Model.Enums;
using Color = Programming.Model.Enums.Color;
using Rectangle = Programming.Model.Classes.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private string[] _colors = { "Red", "Black", "Green", "Yellow", "Orange" };
        private Rectangle[] _rectangles;
        private Rectangle _currentRectangle;
        private Movie[] _movies;
        private Movie _currentMovie;

        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int indexMaxWide = 0;
            double max = 0;
            for(int i = 0; i < 5; i ++)
            {
                if (rectangles[i].Width > max)
                {
                    max = rectangles[i].Width;
                    indexMaxWide = i;
                }
            }
            return indexMaxWide;
        }

        private int FindMovieWithMaxRating(Movie[] movies)
        {
            int indexMaxRating = 0;
            double max = 0;
            for(int i = 0; i < 5; i++)
            {
                if(movies[i].Rating > max)
                {
                    max = movies[i].Rating;
                    indexMaxRating = i;
                }
            }
            return indexMaxRating;
        }
        public MainForm()
        {
            // page Enums
            InitializeComponent();
            var allEnums = Enum.GetValues(typeof(Enums));
            foreach(var enumValue in allEnums)
            {
                EnumsListBox.Items.Add(enumValue);
            }
            EnumsListBox.SelectedIndex = 0;

            var valuesSeasons = Enum.GetValues(typeof(Season));
            foreach (var value in valuesSeasons)
            {
                SeasonComboBox.Items.Add(value);
            }

            // page Classes
            _rectangles = new Rectangle[5];
            var rand = new Random();
            double length, width;
            for (int i = 0; i < 5; i++)
            {
                length = Math.Round(rand.NextDouble() * 100, 1);
                width = Math.Round(rand.NextDouble() * 100, 1);
                _rectangles[i] = new Rectangle(length, width, _colors[i]);
                RectanglesListBox.Items.Add("Rectangle " + (i + 1));
            }
            RectanglesListBox.SelectedIndex = 0;

            _movies = new Movie[5]
            {
                new Movie("Tenet", 2, 2020, "Action", 8),
                new Movie("The Gentlemen", 2, 2019, "Criminal", 9),
                new Movie("Interstellar", 3, 2014, "Science fiction", 7),
                new Movie("The Martian", 2, 2015, "Science fiction", 7.7),
                new Movie("Stalk", 2, 2019, "с++", 7)
            };

            foreach(var movie in _movies)
            {
                MoviesListBox.Items.Add(movie.Title);
            }
            MoviesListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            var selectedEnum = (Enums)EnumsListBox.SelectedItem;
            Array values;
            switch (selectedEnum)
            {
                case Enums.Color:
                    values = Enum.GetValues(typeof(Color));
                    break;
                case Enums.EducationForm:
                    values = Enum.GetValues(typeof(EducationForm));
                    break;
                case Enums.Genre:
                    values = Enum.GetValues(typeof(Genre));
                    break;
                case Enums.Manufacturers:
                    values = Enum.GetValues(typeof(Manufacturers));
                    break;
                case Enums.Season:
                    values = Enum.GetValues(typeof(Season));
                    break;
                case Enums.Weekday:
                    values = Enum.GetValues(typeof(Weekday));
                    break;
                default:
                    throw new NotImplementedException();
            }

            foreach(var value in values)
            {
                ValuesListBox.Items.Add(value);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Text = ((int)ValuesListBox.SelectedItem).ToString();
        }

        private void ParsingButton_Click(object sender, EventArgs e)
        {
            if (Enum.TryParse(WeekdayParsingTextBox.Text, out Weekday weekday))
            {
                WeekdayParsingResultLabel.Text = $"This is the day of the week ({weekday} = {(int)weekday})";
            }
            else
            {
                WeekdayParsingResultLabel.Text = "There is no such day of the week";
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            switch((Season)SeasonComboBox.SelectedItem)
            {
                case Season.Summer:
                    BackColor = ColorTranslator.FromHtml("#00FF00");
                    break;
                case Season.Autumn:
                    BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
                case Season.Winter:
                    MessageBox.Show("winter");
                    break;
                case Season.Spring:
                    MessageBox.Show("spring");
                    break;
                default:
                    MessageBox.Show("Chooce Season!");
                    break;
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRectangle = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedRectangle];
            LenghtTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
        }

        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            LenghtTextBox.BackColor = ColorTranslator.FromHtml("Window");
            try
            {
                _currentRectangle.Length = Convert.ToDouble(LenghtTextBox.Text);
            }
            catch
            {
                LenghtTextBox.BackColor = ColorTranslator.FromHtml("LightPink");
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            WidthTextBox.BackColor = ColorTranslator.FromHtml("Window");
            try
            {
                _currentRectangle.Width = Convert.ToDouble(WidthTextBox.Text);
            }
            catch
            {
                WidthTextBox.BackColor = ColorTranslator.FromHtml("LightPink");
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }

        private void FIndButton_Click(object sender, EventArgs e)
        {
            int indexFindRectangle = FindRectangleWithMaxWidth(_rectangles);
            RectanglesListBox.SelectedIndex = indexFindRectangle;
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedMovie = MoviesListBox.SelectedIndex;
            _currentMovie = _movies[selectedMovie];
            TitleTextBox.Text = _currentMovie.Title;
            GenreTextBox.Text = _currentMovie.Genre;
            DurationTextBox.Text = _currentMovie.Duration.ToString();
            YearTextBox.Text = _currentMovie.Year.ToString();
            RatingTextBox.Text = _currentMovie.Rating.ToString();

        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Title = TitleTextBox.Text;
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = GenreTextBox.Text;
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            YearTextBox.BackColor = ColorTranslator.FromHtml("Window");
            try
            {
                _currentMovie.Year = Convert.ToInt32(YearTextBox.Text);
            }
            catch
            {
                YearTextBox.BackColor = ColorTranslator.FromHtml("LightPink");
            }
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            DurationTextBox.BackColor = ColorTranslator.FromHtml("Window");
            try
            {
                _currentMovie.Duration = Convert.ToInt32(DurationTextBox.Text);
            }
            catch
            {
                DurationTextBox.BackColor = ColorTranslator.FromHtml("LightPink");
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            RatingTextBox.BackColor = ColorTranslator.FromHtml("Window");
            try
            {
                _currentMovie.Rating = Convert.ToDouble(RatingTextBox.Text);
            }
            catch
            {
                RatingTextBox.BackColor = ColorTranslator.FromHtml("LightPink");
            }
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int indexFindMovie = FindMovieWithMaxRating(_movies);
            MoviesListBox.SelectedIndex = indexFindMovie;
        }
    }
}
