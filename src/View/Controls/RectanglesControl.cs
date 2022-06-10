using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Programming.Model.Classes.Geometry;
using Programming.Model.Classes;
using Rectangle = Programming.Model.Classes.Geometry.Rectangle;

namespace Programming.View.Controls
{
    /// <summary>
    /// Реализация  прямоугольников.
    /// </summary>
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Количество элементов.
        /// </summary>
        private const int ElementsCount = 5;

        /// <summary>
        /// Массив прямоугольников.
        /// </summary>
        private Rectangle[] _rectangles;

        /// <summary>
        /// Выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Создает экземпляр <see cref="RectanglesControl"/>.
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();
            CreateRectangles(ElementsCount);
        }

        /// <summary>
        /// Находит прямоугольник с максимальной шириной
        /// </summary>
        /// <param name="rectangles">Массив прямоугольников.</param>
        /// <param name="rectanglesCount">Количество элементов массива.</param>
        /// <returns>Индекс прямоугольника.</returns>
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles, int rectanglesCount)
        {
            int indexMaxWide = 0;
            double max = 0;
            for (int i = 0; i < rectanglesCount; i++)
            {
                if (rectangles[i].Width > max)
                {
                    max = rectangles[i].Width;
                    indexMaxWide = i;
                }
            }
            return indexMaxWide;
        }

        /// <summary>
        /// Заполнение массива.
        /// </summary>
        /// <param name="countRectangles"></param>
        private void CreateRectangles(int countRectangles)
        {
            _rectangles = new Rectangle[countRectangles];
            for (int i = 0; i < countRectangles; i++)
            {

                _rectangles[i] = RectangleFactory.Randomize(500, 500);
                RectanglesListBox.Items.Add("Rectangle " + (i + 1));
            }
            RectanglesListBox.SelectedIndex = 0;
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRectangle = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedRectangle];
            IdTextBox.Text = _currentRectangle.Id.ToString();
            LengthTextBox.Text = _currentRectangle.Height.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
            XTextBox.Text = _currentRectangle.Center.X.ToString();
            YTextBox.Text = _currentRectangle.Center.Y.ToString();
        }

        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            LengthTextBox.BackColor = AppColor.CorrectColor;
            try
            {
                _currentRectangle.Height = Convert.ToInt32(LengthTextBox.Text);
            }
            catch
            {
                LengthTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            WidthTextBox.BackColor = AppColor.CorrectColor;
            try
            {
                _currentRectangle.Width = Convert.ToInt32(WidthTextBox.Text);
            }
            catch
            {
                WidthTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }

        private void FIndButton_Click(object sender, EventArgs e)
        {
            int indexFindRectangle = FindRectangleWithMaxWidth(_rectangles, ElementsCount);
            RectanglesListBox.SelectedIndex = indexFindRectangle;
        }

        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void XTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void YTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
