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
    public partial class OrderForm : Form
    {
        Customer MyCustomer;
        List<Product> Products = new List<Product>();
        
        public OrderForm(Customer Customer)
        {
            InitializeComponent();
            this.MyCustomer = Customer;
            CusName.Text = Customer.Name;
            ShippingAddress.Text = Customer.ShippingAddress;
        }

        private void ManualPrice_CheckedChanged(object sender, EventArgs e)
        {
            FinalPrice.Enabled = ManualPrice.Checked;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            Products = Product.LoadAllProducts();

            foreach (var item in Products)
                comboBox1.Items.Add($"Id:{item.ID}/Name:{item.Name}");
        }
        public int GetSelectedItemId()
        {
            var results = comboBox1.SelectedItem.ToString().Split('/');
            foreach (var item in results)
            {
                var data = item.Split(':');
                if (data.Length < 2) continue;
                if (data[0] == "Id")
                    return int.Parse(data[1]);
            }
            return -1;
        }
        public Product GetSelectedItem()
        {
            int id = GetSelectedItemId();
            if (id == -1)
            {
                MessageBox.Show("Error with selection!");
                return null;
            }
            return Products.Where(p => p.ID == id)
                .SingleOrDefault();
        }
        public void SetPrice()
        {
            int id = GetSelectedItemId();
            if (id == -1)
            {
                MessageBox.Show("Error with selection!");
                return;
            }
            ManualPrice.Enabled = numericUpDown1.Enabled = true;
            var item = Products.Where(p => p.ID == id)
                .SingleOrDefault();
            FinalPrice.Text = item.Price * numericUpDown1.Value + "";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = GetSelectedItem();
            AvailableQuantity.Text = item.Quantity.ToString();
            SetPrice();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (!numericUpDown1.Enabled) return;
            if (numericUpDown1.Value > int.Parse(AvailableQuantity.Text))
            {
                numericUpDown1.Value = int.Parse(AvailableQuantity.Text);
                if (int.Parse(AvailableQuantity.Text) == 0)
                    MessageBox.Show("Out of Stock!");
                else
                    MessageBox.Show($"Max available is {AvailableQuantity.Text}");
            }
            SetPrice();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to make this order?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var newOrder = new Order(MyCustomer.ID, GetSelectedItem().ID, int.Parse(numericUpDown1.Value.ToString()), int.Parse(FinalPrice.Text), Paid.Checked, DateTime.Now);
                newOrder.finalizeOrder();
                MessageBox.Show("Order done! Please screenshot the next form and send it to the customer.");
                orderNo.Text = newOrder.OrderId + "";
                DateLabel.Text = newOrder.Stamp.ToString();
                orderNo.Visible = label8.Visible = label9.Visible = DateLabel.Visible = true;
                OrderGroup.Enabled = false;
                ControlsGroup.Enabled = false;
            }
        }
    }
}
