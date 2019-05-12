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
    public partial class CustomerResults : Form
    {
        List<Customer> Customers;
        public CustomerResults(List<Customer> Customers)
        {
            InitializeComponent();
            this.Customers = Customers;
            foreach (var item in Customers)
            {
                Results.Items.Add("ID:" + item.ID + "/" +
                    "Name:" + item.Name + "/" +
                    "Phone:" + item.Phone + "/" +
                    "ShippingAddress:" + item.ShippingAddress + "/" +
                    "Insta:" + item.Instagram_user + "/" +
                    "Email:" + item.Email);
            }
        }

        private void CustomerResults_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Results.SelectedIndex == -1)
            {
                MessageBox.Show("Nothing selected!");
                return;
            }
            var customer = new Customer();
            var results = Results.SelectedItem.ToString().Split('/');
            foreach (var item in results)
            {
                var data = item.Split(':');
                if (data.Length < 2) continue;
                if (data[0] == "ID")
                    customer.ID = int.Parse(data[1]);
                if (data[0] == "Name")
                    customer.Name = data[1];
                if (data[0] == "Phone")
                    customer.Phone = data[1];
                if (data[0] == "ShippingAddress")
                    customer.ShippingAddress = data[1];
                if (data[0] == "Insta")
                    customer.Instagram_user = data[1];
                if (data[0] == "Email")
                    customer.Email = data[1];
            }
            this.Hide();
            var cus = new CustomersForm(customer);
            cus.ShowDialog();
        }

        private void Results_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
