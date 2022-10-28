using ObjectOrientedPractics.View.Tabs;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private ProjectSerializer _serializer = new("Customers");

        public Store _store;

        public MainForm()
        {
            InitializeComponent();

            _store = _serializer.LoadFromFile();
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _store.Items = ItemsTab.Items;
            _store.Customers = CustomersTab.Customers;
            _serializer.SaveToFile(_store);
        }
    }
}