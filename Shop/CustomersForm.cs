using Shop.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }
        bool Loaded = false;
        int ID = 0;
        Customer LoadedCus;
        public CustomersForm(Customer Customer)
        {
            InitializeComponent();
            Loaded = true;
            ID = Customer.ID;
            CusName.Text = Customer.Name;
            Phone.Text = Customer.Phone;
            ShippingAddress.Text= Customer.ShippingAddress;
            Email.Text = Customer.Email;
            Instagram.Text = Customer.Instagram_user;
            OrdersTab.Enabled = true;

            this.LoadedCus = Customer;
        }
        public void LoadBy(string Param, string Value)
        {
            bool Found = false;
            var results = Customer.Search(Param, Value, ref Found);
            if (!Found)
                MessageBox.Show("No results found");
            else
            {
                MessageBox.Show(results.Count + " results found!");
                this.Hide();
                var cusResults = new CustomerResults(results);
                cusResults.ShowDialog();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var cus = new Customer(CusName.Text,
                Phone.Text,
                ShippingAddress.Text,
                Email.Text,
                Instagram.Text);
            cus.Insert();
            ID = cus.ID;
            Loaded = true;
            LoadedCus = cus;
            OrdersTab.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadBy("CustomerName", CusName.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadBy("PhoneNo", Phone.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadBy("Email", Email.Text);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadBy("IGUser", Instagram.Text);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!Loaded)
            {
                MessageBox.Show("You must load the user first before updating!");
                return;
            }
            var cus = new Customer(CusName.Text, Phone.Text, ShippingAddress.Text, Email.Text, Instagram.Text, ID);
            cus.Update();
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            var newOrder = new OrderForm(LoadedCus);
            this.Hide();
            newOrder.ShowDialog();
        }
    }
}
