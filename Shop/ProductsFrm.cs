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
    public partial class ProductsFrm : Form
    {
        public ProductsFrm()
        {
            InitializeComponent();
        }
        bool Loaded = false;
        int ID = 0;
        public ProductsFrm(Product Product)
        {
            InitializeComponent();
            Loaded = true;
            ID = Product.ID;
            ProdName.Text = Product.Name;
            Price.Text = Product.Price.ToString();
            Quantity.Text = Product.Quantity.ToString();
        }
        public void LoadBy(string Param, string Value)
        {
            bool Found = false;
            var results = Product.Search(Param, Value, ref Found);
            if (!Found)
                MessageBox.Show("No results found");
            else
            {
                MessageBox.Show(results.Count + " results found!");
                var cusResults = new ProductResults(results);
                cusResults.ShowDialog();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            LoadBy("Name", ProdName.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cus = new Product(ProdName.Text,
                int.Parse(Quantity.Text),
                int.Parse(Price.Text));
            cus.Insert();
            Loaded = false;
            ID = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Loaded)
            {
                MessageBox.Show("You must load the product first before updating!");
                return;
            }
            var prod = new Product(ProdName.Text, int.Parse(Quantity.Text), int.Parse(Price.Text), ID);
            prod.Update();
        }
    }
}
