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
    public partial class ProductResults : Form
    {
        List<Product> Products;
        public ProductResults(List<Product> Products)
        {
            InitializeComponent();
            this.Products = Products;
            foreach (var item in Products)
            {
                Results.Items.Add("ID:" + item.ID + "/" +
                    "Name:" + item.Name + "/" +
                    "Quantity:" + item.Quantity + "/" +
                    "Price:" + item.Price);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Results.SelectedIndex == -1)
            {
                MessageBox.Show("Nothing selected!");
                return;
            }
            var product = new Product();
            var results = Results.SelectedItem.ToString().Split('/');
            foreach (var item in results)
            {
                var data = item.Split(':');
                if (data.Length < 2) continue;
                if (data[0] == "ID")
                    product.ID = int.Parse(data[1]);
                if (data[0] == "Name")
                    product.Name = data[1];
                if (data[0] == "Quantity")
                    product.Quantity = int.Parse(data[1]);
                if (data[0] == "Price")
                    product.Price = int.Parse(data[1]);
            }
            this.Hide();
            var cus = new ProductsFrm(product);
            cus.ShowDialog();
        }
    }
}
