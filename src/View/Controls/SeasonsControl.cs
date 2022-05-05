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
    public partial class SeasonsControl : UserControl
    {
        public SeasonsControl()
        {
            InitializeComponent();

            var seasonValues = Enum.GetValues(typeof(Season));
            foreach (var value in seasonValues)
            {
                SeasonComboBox.Items.Add(value);
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            switch ((Season)SeasonComboBox.SelectedItem)
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
    }
}
