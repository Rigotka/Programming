using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Control
{
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Адрес.
        /// </summary>
        private Address _address;

        private bool _readOnly;

        /// <summary>
        /// Возвращает и задает адрес.
        /// </summary>
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

        public bool ReadOnly
        {
            set
            {
                _readOnly = value;

                if(_readOnly)
                {
                    PostIndexTextBox.ReadOnly = true;
                    CountryTextBox.ReadOnly = true;
                    CityTextBox.ReadOnly = true;
                    StreetTextBox.ReadOnly = true;
                    BuildingTextBox.ReadOnly = true;
                    ApartmentTextBox.ReadOnly = true;
                }
            }
        }

        public AddressControl()
        {
            InitializeComponent();

            _address = new Address();
        }

        /// <summary>
        /// Обновляет поля информации.
        /// </summary>
        public void UpdateFieldsInfo()
        {
            PostIndexTextBox.Text = _address.Index.ToString();
            CountryTextBox.Text = _address.Country;
            CityTextBox.Text = _address.City;
            StreetTextBox.Text = _address.Street;
            BuildingTextBox.Text = _address.Building;
            ApartmentTextBox.Text = _address.Apartment;
        }

        /// <summary>
        /// Очищает поля информации.
        /// </summary>
        public void ClearFieldsInfo()
        {
            PostIndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();

            PostIndexTextBox.BackColor = AppColor.CorrectColor;
            CountryTextBox.BackColor = AppColor.CorrectColor;
            CityTextBox.BackColor = AppColor.CorrectColor;
            StreetTextBox.BackColor = AppColor.CorrectColor;
            BuildingTextBox.BackColor = AppColor.CorrectColor;
            ApartmentTextBox.BackColor = AppColor.CorrectColor;
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
                return;
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
