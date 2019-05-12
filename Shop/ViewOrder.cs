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
    public partial class ViewOrder : Form
    {
        public ViewOrder(Order order)
        {
            InitializeComponent();
            string paid = order.Paid ? "YES" : "NO";
            Writeline($"Order Number: {order.OrderId}");
            Writeline($"Date of Order:  {order.Stamp}");
            Writeline($"Paid: {paid}");
            Writeline($"CustomerID: {order.CustomerId}");
            Writeline($"ItemID: {order.ItemId}");
            Writeline($"Price: {order.Price}");
            Writeline($"Quantity: {order.Quantity}");
        }
        void Writeline(string text)
        {
            richTextBox1.Text += text + Environment.NewLine;
            richTextBox1.ScrollToCaret();
        }
        private void ViewOrder_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
