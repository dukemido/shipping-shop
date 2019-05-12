using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop.Objects
{
    public class Product
    {
        public string Name;
        public int Quantity, Price;
        public Product()
        {

        }
        public Product(string Name, int Quantity, int Price, int ID = 0)
        {
            this.Name = Name;
            this.Quantity = Quantity;
            this.Price = Price;
            this.ID = ID;
        }
        public int ID
        {
            get;
            set;
        }
        public void Insert()
        {
            using (var conn = new MySqlConnection(Kernel.Connection))
            using (var cmd = new MySqlCommand("INSERT INTO products (Name,QuantityAvailable,Price)"
                + " VALUES (@name,@quantity,@price)", conn))
            {
                conn.Open();
                try
                {
                    cmd.Parameters.AddWithValue("@name", Name);
                    cmd.Parameters.AddWithValue("@quantity", Quantity);
                    cmd.Parameters.AddWithValue("@price", Price);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inserted new product.");
                }
                catch (Exception e)
                {
                    Kernel.LogError(e.Message);
                }
            }
        }
        public static List<Product> Search(string Param, string Val, ref bool Found)
        {
            var cus = new List<Product>();
            using (var conn = new MySqlConnection(Kernel.Connection))
            using (var cmd = new MySqlCommand("SELECT * FROM products WHERE " + Param + " LIKE '%" + Val + "%'", conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cus.Add(new Product(reader.GetString("Name"),
                            reader.GetInt32("QuantityAvailable"),
                            reader.GetInt32("Price"),
                            reader.GetInt32("ID")));
                    }
                    Found = true;
                }
            }
            return cus;
        }
        public static List<Product> LoadAllProducts()
        {
            var cus = new List<Product>();
            using (var conn = new MySqlConnection(Kernel.Connection))
            using (var cmd = new MySqlCommand("SELECT * FROM products", conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cus.Add(new Product(reader.GetString("Name"),
                            reader.GetInt32("QuantityAvailable"),
                            reader.GetInt32("Price"),
                            reader.GetInt32("ID")));
                    }
                }
            }
            return cus;
        }
        internal void Update()
        {
            using (var conn = new MySqlConnection(Kernel.Connection))
            using (var cmd = new MySqlCommand("UPDATE products SET Name=@name,QuantityAvailable=@quant,"
                + "Price=@price WHERE ID=@id", conn))
            {
                conn.Open();
                try
                {
                    cmd.Parameters.AddWithValue("@name", Name);
                    cmd.Parameters.AddWithValue("@quant", Quantity);
                    cmd.Parameters.AddWithValue("@price", Price);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Product.");
                }
                catch (Exception e)
                {
                    Kernel.LogError(e.Message);
                }
            }

        }
    }
}
