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

namespace Programming.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var AllEnums = Enum.GetValues(typeof(Enums));
            foreach(var _enum in AllEnums)
            {
                EnumsListBox.Items.Add(_enum);
            }
            EnumsListBox.SetSelected(0, true);

            var valuseSeasons = Enum.GetValues(typeof(Season));
            foreach (var value in valuseSeasons)
            {
                SeasonComboBox.Items.Add(value);
            }
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            var SelectEnum = (Enums)EnumsListBox.SelectedIndex;
            Array Values;
            switch (SelectEnum)
            {
                case Enums.Colour:
                    Values = Enum.GetValues(typeof(Colour));
                    break;
                case Enums.FormOfStudy:
                    Values = Enum.GetValues(typeof(FormOfStudy));
                    break;
                case Enums.Genre:
                    Values = Enum.GetValues(typeof(Genre));
                    break;
                case Enums.Manufacturers:
                    Values = Enum.GetValues(typeof(Manufacturers));
                    break;
                case Enums.Season:
                    Values = Enum.GetValues(typeof(Season));
                    break;
                case Enums.Weekday:
                    Values = Enum.GetValues(typeof(Weekday));
                    break;
                default:
                    throw new NotImplementedException();
            }

            foreach(var value in Values)
            {
                ValuesListBox.Items.Add(value);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueBox.Text = ((int)ValuesListBox.SelectedItem).ToString();
        }

        private void ParsingButton_Click(object sender, EventArgs e)
        {
            Weekday result;
            if (Enum.TryParse(WeekdayParsingTextBox.Text, out result))
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
                    BackColor = Color.Green;
                    break;
                case Season.Autumn:
                    BackColor = Color.Orange;
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
