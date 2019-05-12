using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public class Kernel
    {
        public const string Connection = "server=localhost;username=root;password=;database=shop;";
        public static void LogError(string err)
        {
            MessageBox.Show("Error: " + err);
        }
    }
}
