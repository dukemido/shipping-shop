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
    public partial class SearchOrderFrm : Form
    {
        public SearchOrderFrm()
        {
            InitializeComponent();
        }
        public void LoadBy(string Param, string Value)
        {
            bool Found = false;
            var results = Order.Search(Param, Value, ref Found);
            if (!Found)
                MessageBox.Show("No results found");
            else
            {
                MessageBox.Show(results.Count + " results found!");
                this.Hide();
                var cusResults = new SearchResultsForm(results);
                cusResults.ShowDialog();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadBy("OrderID", orderNo.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadBy("CustomerID", CustomerId.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadBy("ProductID", ProductId.Text);

        }
    }
}
