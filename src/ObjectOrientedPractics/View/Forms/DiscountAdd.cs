using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Forms
{
    public partial class DiscountAdd : Form
    {
        public DiscountAdd()
        {
            InitializeComponent();
            var categoryValues = Enum.GetValues(typeof(Category));
            foreach (var value in categoryValues)
            {
                CategoryComboBox.Items.Add(value);
            }
            CategoryComboBox.SelectedIndex = 0;
        }

        public PercentDiscount PercentDiscount { get; set; }

        private void OkButton_Click(object sender, EventArgs e)
        {
            PercentDiscount percentDiscount = new PercentDiscount((Category)CategoryComboBox.SelectedItem);
            PercentDiscount = percentDiscount;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
