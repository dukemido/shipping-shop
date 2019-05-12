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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userBox.Text == "duke" && passBox.Text == "123")
            {
                MessageBox.Show($"Welcome back {userBox.Text}! Last access was on {DateTime.Now}");
                this.Hide();
                var main = new Main();
                main.ShowDialog();
            }
            else
                MessageBox.Show("Invalid username or password!");
        }
    }
}
