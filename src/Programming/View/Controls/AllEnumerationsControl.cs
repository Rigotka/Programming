using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Color = Programming.Model.Enums.Color;
using Programming.Model.Enums;


namespace Programming.View.Controls
{
    /// <summary>
    /// Реализация перечислений.
    /// </summary>
    public partial class AllEnumerationsControl : UserControl
    {
        /// <summary>
        /// Создает экземпляр <see cref="AllEnumerationsControl"/>.
        /// </summary>
        public AllEnumerationsControl()
        {
            InitializeComponent();
            var allEnums = Enum.GetValues(typeof(Enums));
            foreach (var enumValue in allEnums)
            {
                EnumsListBox.Items.Add(enumValue);
            }
            EnumsListBox.SelectedIndex = 0;
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

            foreach (var value in values)
            {
                ValuesListBox.Items.Add(value);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValuesListBox.SelectedItem == null)
                return;

            IntValueTextBox.Text = ((int)ValuesListBox.SelectedItem).ToString();
        }
    }
}
