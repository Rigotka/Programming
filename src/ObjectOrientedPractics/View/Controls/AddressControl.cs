using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Control
{
    public partial class AddressControl : UserControl
    {
        private Address _address;

        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                UpdateFieldsInfo();
            }
        }

        public AddressControl()
        {
            InitializeComponent();

            _address = new Address();
        }

        public void UpdateFieldsInfo()
        {
            PostIndexTextBox.Text = _address.Index.ToString();
            CountryTextBox.Text = _address.Country;
            CityTextBox.Text = _address.City;
            StreetTextBox.Text = _address.Street;
            BuildingTextBox.Text = _address.Building;
            ApartmentTextBox.Text = _address.Apartment;
        }

        public void ClearFieldsInfo()
        {
            PostIndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            PostIndexTextBox.BackColor = AppColor.CorrectColor;
            try
            {
                _address.Index = Convert.ToInt32(PostIndexTextBox.Text);
            }
            catch
            {
                PostIndexTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            CountryTextBox.BackColor = AppColor.CorrectColor;
            try
            {
                _address.Country = CountryTextBox.Text;
            }
            catch
            {
                CountryTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            CityTextBox.BackColor = AppColor.CorrectColor;
            try
            {
                _address.City = CityTextBox.Text;
            }
            catch
            {
                CityTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            StreetTextBox.BackColor = AppColor.CorrectColor;
            try
            {
                _address.Street = StreetTextBox.Text;
            }
            catch
            {
                StreetTextBox.BackColor= AppColor.ErrorColor;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            BuildingTextBox.BackColor = AppColor.CorrectColor;
            try
            {
                _address.Building = BuildingTextBox.Text;
            }
            catch
            {
                BuildingTextBox.BackColor= AppColor.ErrorColor;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Apartment = ApartmentTextBox.Text;
            }
            catch
            {
                ApartmentTextBox.BackColor= AppColor.ErrorColor;
                return;
            }
            ApartmentTextBox.BackColor = AppColor.CorrectColor;
        }
    }
}
