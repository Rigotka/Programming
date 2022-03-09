using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Enums;
using Color = Programming.Model.Enums.Color;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var allEnums = Enum.GetValues(typeof(Enums));
            foreach(var enumValue in allEnums)
            {
                EnumsListBox.Items.Add(enumValue);
            }
            EnumsListBox.SelectedIndex = 0;

            var valuseSeasons = Enum.GetValues(typeof(Season));
            foreach (var value in valuseSeasons)
            {
                SeasonComboBox.Items.Add(value);
            }
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            var selectEnum = (Enums)EnumsListBox.SelectedIndex;
            Array values;
            switch (selectEnum)
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
            if (Enum.TryParse(WeekdayParsingTextBox.Text, out Weekday result))
            {
                WeekdayParsingResultLabel.Text = $"this is the day of the week ({result} = {(int)result})";
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
                    MessageBox.Show("Spring");
                    break;
                default:
                    MessageBox.Show("Choice Season!");
                    break;
            }
        }
    }
}
