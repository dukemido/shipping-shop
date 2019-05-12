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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cus = new CustomersForm();
            cus.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cus = new ProductsFrm();
            cus.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cus = new SearchOrderFrm();
            cus.ShowDialog();
        }
    }
}
