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
    public partial class SearchResultsForm : Form
    {
        public SearchResultsForm()
        {
            InitializeComponent();
        }
        List<Order> Orders;
        public SearchResultsForm(List<Order> Orders)
        {
            InitializeComponent();
            this.Orders = Orders;
            foreach (var item in Orders)
            {
                Results.Items.Add(
                    "OrderId>" + item.OrderId + "@" +
                    "CustomerId>" + item.CustomerId+ "@" +
                    "ProductId>" + item.ItemId + "@" +
                    "Paid>" + item.Paid + "@" +
                    "DateOfOrder>" + item.Stamp.ToString()+ "@" +
                    "Quantity>" + item.Quantity + "@" +
                    "Price>" + item.Price);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Results.SelectedIndex == -1)
            {
                MessageBox.Show("Nothing selected!");
                return;
            }
            var order = new Order();
            var results = Results.SelectedItem.ToString().Split('@');
            foreach (var item in results)
            {
                var data = item.Split('>');
                if (data.Length < 2) continue;
                if (data[0] == "OrderId")
                    order.OrderId = int.Parse(data[1]);
                if (data[0] == "CustomerId")
                    order.CustomerId = int.Parse(data[1]);
                if (data[0] == "ProductId")
                    order.ItemId = int.Parse(data[1]);
                if (data[0] == "Paid")
                    order.Paid = bool.Parse(data[1]);
                if (data[0] == "Quantity")
                    order.Quantity = int.Parse(data[1]);
                if (data[0] == "Price")
                    order.Price = int.Parse(data[1]);
                if (data[0] == "DateOfOrder")
                    order.Stamp = DateTime.Parse(data[1]);
            }
            this.Hide();
            var cus = new ViewOrder(order);
            cus.ShowDialog();
        }
    }
}
