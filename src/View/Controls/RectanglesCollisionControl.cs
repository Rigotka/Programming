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
    /// Реализация пересечения прямоугольников.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {
        /// <summary>
        /// Коллекция прямоугольников.
        /// </summary>
        private List<Rectangle> _rectangles = new List<Rectangle>();

        /// <summary>
        /// Выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Коллекция Panel.
        /// </summary>
        private List<Panel> _rectanglePanels = new List<Panel>();

        /// <summary>
        /// Высота области.
        /// </summary>
        private int _heightCanvas;

        /// <summary>
        /// Ширина области.
        /// </summary>
        private int _widthCanvas;

        /// <summary>
        /// Создает экземпляр <see cref="RectanglesCollisionControl"/>.
        /// </summary>
        public RectanglesCollisionControl()
        {
            InitializeComponent();

            _heightCanvas = CanvasPanel.Height;
            _widthCanvas = CanvasPanel.Width;
        }

        /// <summary>
        /// Находит пересекающиеся прямоугольники и окрашивает их.
        /// </summary>
        private void FindCollisions()
        {
            _rectanglePanels.ForEach(panel => panel.BackColor = AppColor.NotCollision);
            for(int i = 0; i < _rectanglePanels.Count; i++)
            {
                for(int j = i + 1; j < _rectanglePanels.Count; j++)
                {
                    if(CollisionManager.IsCollision(_rectangles[i], _rectangles[j]) && i != j)
                    {
                        _rectanglePanels[i].BackColor = AppColor.IsCollision;
                        _rectanglePanels[j].BackColor = AppColor.IsCollision;
                    }
                }
            }
        }

        /// <summary>
        /// Формирует текст из данных прямоугольника.
        /// </summary>
        /// <param name="rectangle">Прямоугольник</param>
        /// <returns>Отформатированный текст.</returns>
        private string FormattedTextRectangle(Rectangle rectangle)
        {
            return $"{rectangle.Id}:" +
                   $"(X= {rectangle.Center.X}; " +
                   $"Y= {rectangle.Center.Y} " +
                   $"W= {rectangle.Width}; " +
                   $"H= {rectangle.Height})";
        }

        /// <summary>
        /// Обновляет информацию в списке.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            int indexSelectedRectangle = RectanglesListBox.SelectedIndex;
            RectanglesListBox.Items[indexSelectedRectangle] = FormattedTextRectangle(rectangle);
            FindCollisions();
        }

        /// <summary>
        /// Очищает информацию в TexBox-ах
        /// </summary>
        private void ClearRectangleInfo()
        {
            IdTextBox.Clear();
            XTextBox.Clear();
            YTextBox.Clear();
            WidthTextBox.Clear();
            HeightTextBox.Clear();
        }

        private void AddRectanglesPictureBox_Click(object sender, EventArgs e)
        {      
            Rectangle rectagle = RectangleFactory.Randomize(_widthCanvas, _heightCanvas);
            _rectangles.Add(rectagle);
            RectanglesListBox.Items.Add(FormattedTextRectangle(rectagle));
                
            Panel rectanglePanel = new Panel
            {
                Width = rectagle.Width,       
                Height = rectagle.Height,
                Location = new Point(rectagle.Center.X, rectagle.Center.Y),
                BackColor = AppColor.NotCollision
            };
  
            _rectanglePanels.Add(rectanglePanel);                
            CanvasPanel.Controls.Add(rectanglePanel);
                
            FindCollisions();
        }

        private void RemoveRectanglePictureBox_Click(object sender, EventArgs e)
        {
            int indexSelectedRectangle = RectanglesListBox.SelectedIndex;

            if (indexSelectedRectangle == -1)
                return;

            _rectangles.RemoveAt(indexSelectedRectangle);
            RectanglesListBox.Items.RemoveAt(indexSelectedRectangle);
            _rectanglePanels.RemoveAt(indexSelectedRectangle);
            CanvasPanel.Controls.RemoveAt(indexSelectedRectangle);

            FindCollisions();
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSelectedRectangle = RectanglesListBox.SelectedIndex;

            if (indexSelectedRectangle == -1)
            {
                ClearRectangleInfo();
                return;
            }

            _currentRectangle = _rectangles[indexSelectedRectangle];
            IdTextBox.Text = _currentRectangle.Id.ToString();
            XTextBox.Text = _currentRectangle.Center.X.ToString();
            YTextBox.Text = _currentRectangle.Center.Y.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            HeightTextBox.Text = _currentRectangle.Height.ToString();
        }

        private void XTextBox_TextChanged(object sender, EventArgs e)
        {
            XTextBox.BackColor = AppColor.CorrectColor;
            int indexSelectedRectangle = RectanglesListBox.SelectedIndex;

            if (indexSelectedRectangle == -1)
                return;

            try
            {
                _currentRectangle.Center.X = Convert.ToInt32(XTextBox.Text);
                _rectanglePanels[indexSelectedRectangle].Location = new Point(
                    _currentRectangle.Center.X, _currentRectangle.Center.Y
                );
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                XTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        private void YTextBox_TextChanged(object sender, EventArgs e)
        {
            YTextBox.BackColor = AppColor.CorrectColor;
            int indexSelectedRectangle = RectanglesListBox.SelectedIndex;

            if (indexSelectedRectangle == -1)
                return;

            try
            {
                _currentRectangle.Center.Y = Convert.ToInt32(YTextBox.Text);
                _rectanglePanels[indexSelectedRectangle].Location = new Point(
                    _currentRectangle.Center.X, _currentRectangle.Center.Y
                );
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                YTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            WidthTextBox.BackColor = AppColor.CorrectColor;
            int indexSelectedRectangle = RectanglesListBox.SelectedIndex;

            if (indexSelectedRectangle == -1)
                return;

            try
            {
                _currentRectangle.Width = Convert.ToInt32(WidthTextBox.Text);
                _rectanglePanels[RectanglesListBox.SelectedIndex].Width = _currentRectangle.Width;
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                WidthTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            HeightTextBox.BackColor = AppColor.CorrectColor;
            int indexSelectedRectangle = RectanglesListBox.SelectedIndex;

            if (indexSelectedRectangle == -1)
                return;

            try
            {
                _currentRectangle.Height = Convert.ToInt32(HeightTextBox.Text);
                _rectanglePanels[RectanglesListBox.SelectedIndex].Height = _currentRectangle.Height;
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                HeightTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AddRectanglesPictureBox_MouseEnter(object sender, EventArgs e)
        {
            AddRectanglesPictureBox.Image = Properties.Resources.rectangle_add_24x24;
        }

        private void AddRectanglesPictureBox_MouseLeave(object sender, EventArgs e)
        {
            AddRectanglesPictureBox.Image = Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void AddRectanglesPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            AddRectanglesPictureBox.BackColor = SystemColors.Control;
        }

        private void AddRectanglesPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            AddRectanglesPictureBox.BackColor = SystemColors.ControlLightLight;
        }

        private void RemoveRectanglePictureBox_MouseEnter(object sender, EventArgs e)
        {
            RemoveRectanglePictureBox.Image = Properties.Resources.rectangle_remove_24x24;
        }

        private void RemoveRectanglePictureBox_MouseLeave(object sender, EventArgs e)
        {
            RemoveRectanglePictureBox.Image = Properties.Resources.rectangle_remove_24x24_uncolor;
        }

        private void RemoveRectanglePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            RemoveRectanglePictureBox.BackColor = SystemColors.Control;
        }

        private void RemoveRectanglePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            RemoveRectanglePictureBox.BackColor = SystemColors.ControlLightLight;
        }

        private void CanvasPanel_Resize(object sender, EventArgs e)
        {
            _heightCanvas = CanvasPanel.Height;
            _widthCanvas = CanvasPanel.Width;
        }
    }
}
