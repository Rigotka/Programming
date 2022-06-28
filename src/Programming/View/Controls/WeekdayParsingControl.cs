using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    /// <summary>
    /// Реализация дней недели.
    /// </summary>
    public partial class WeekdayParsingControl : UserControl
    {
        /// <summary>
        /// Создает экземпляр <see cref="WeekdayParsingControl"/>.
        /// </summary>
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        private void ParsingButton_Click(object sender, EventArgs e)
        {
            if (Enum.TryParse(WeekdayParsingTextBox.Text, out Weekday weekday))
                WeekdayParsingResultLabel.Text = $"This is the day of the week ({weekday} = {(int)weekday})";
            else
                WeekdayParsingResultLabel.Text = "There is no such day of the week";
        }
    }
}
