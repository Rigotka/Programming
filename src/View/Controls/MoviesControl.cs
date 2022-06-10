using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Programming.Model.Classes;

namespace Programming.View.Controls
{
    /// <summary>
    /// Реализация перечислений.
    /// </summary>
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Количество элементов в массиве.
        /// </summary>
        private const int ElementsCount = 5;

        /// <summary>
        /// Массив фильмов.
        /// </summary>
        private Movie[] _movies;

        /// <summary>
        /// Выбранный фильма.
        /// </summary>
        private Movie _currentMovie;

        /// <summary>
        /// Создает экземпляр <see cref="MoviesControl"/>.
        /// </summary>
        public MoviesControl()
        {
            InitializeComponent();
            CreateMovies();
        }

        /// <summary>
        /// Наполняет массив.
        /// </summary>
        private void CreateMovies()
        {
            _movies = new Movie[5]
            {
                new Movie("Tenet", 2, 2020, "Action", 8),
                new Movie("The Gentlemen", 2, 2019, "Criminal", 9),
                new Movie("Interstellar", 3, 2014, "Science fiction", 9.9),
                new Movie("The Martian", 2, 2015, "Science fiction", 7.7),
                new Movie("Stalk", 2, 2019, "с++", 7)
            };

            foreach (var movie in _movies)
            {
                MoviesListBox.Items.Add(movie.Title);
            }

            MoviesListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Находит фильм с самым высоким рейтингом.
        /// </summary>
        /// <param name="movies">Массив фильмов</param>
        /// <returns>Индекс фильма.</returns>
        private int FindMovieWithMaxRating(Movie[] movies)
        {
            int maxWidthIndex = 0;
            double max = 0;
            for (int i = 0; i < ElementsCount; i++)
            {
                if (movies[i].Rating > max)
                {
                    max = movies[i].Rating;
                    maxWidthIndex = i;
                }
            }
            return maxWidthIndex;
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
            YearTextBox.BackColor = AppColor.CorrectColor;
            try
            {
                _currentMovie.Year = Convert.ToInt32(YearTextBox.Text);
            }
            catch
            {
                YearTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            DurationTextBox.BackColor = AppColor.CorrectColor;
            try
            {
                _currentMovie.Duration = Convert.ToInt32(DurationTextBox.Text);
            }
            catch
            {
                DurationTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            RatingTextBox.BackColor = AppColor.CorrectColor;
            try
            {
                _currentMovie.Rating = Convert.ToDouble(RatingTextBox.Text);
            }
            catch
            {
                RatingTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int indexFindMovie = FindMovieWithMaxRating(_movies);
            MoviesListBox.SelectedIndex = indexFindMovie;
        }
    }
}
