using System;
using System.Windows.Forms;
using Programming.Model.Enums;
using Programming.Model.Classes;


namespace Programming.View.Controls
{
    /// <summary>
    /// Реализация сезонов.
    /// </summary>
    public partial class SeasonsControl : UserControl
    {
        /// <summary>
        /// Создает экземпляр <see cref="SeasonsControl"/>.
        /// </summary>
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
                    BackColor = AppColor.SummerColor;
                    break;
                case Season.Autumn:
                    BackColor = AppColor.AutumnColor;
                    break;
                case Season.Winter:
                    MessageBox.Show("winter");
                    break;
                case Season.Spring:
                    MessageBox.Show("spring");
                    break;
                default:
                    MessageBox.Show("Choose Season!");
                    break;
            }
        }
    }
}
