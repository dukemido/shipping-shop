using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop.Objects
{
    public class Order
    {
        public int CustomerId, ItemId, Quantity, Price;
        public string CustomerName, ProductName;
        public DateTime Stamp;
        public int OrderId;
        public bool Paid;
        public Order()
        {

        }
        public Order(int CustomerId, int ItemId, int Quantity, int Price, bool Paid, DateTime Stamp, int OrderId = 0)
        {
            this.CustomerId = CustomerId;
            this.ItemId = ItemId;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Paid = Paid;
            this.Stamp = Stamp;
            this.OrderId = OrderId;
        }
        public void finalizeOrder()
        {
            using (var conn = new MySqlConnection(Kernel.Connection))
            {
                using (var cmd = new MySqlCommand("INSERT INTO orders (ProductID,CustomerID,Quantity,Paid,OrderDate, Amount) VALUES (@pid,@cid,@quantity,@paid,@date,@am)", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@pid", ItemId);
                    cmd.Parameters.AddWithValue("@cid", CustomerId);
                    cmd.Parameters.AddWithValue("@quantity", Quantity);
                    cmd.Parameters.AddWithValue("@paid", Paid ? 1 : 0);
                    cmd.Parameters.AddWithValue("@date", Stamp);
                    cmd.Parameters.AddWithValue("@am", Price);
                    cmd.ExecuteNonQuery();
                    OrderId = (int)cmd.LastInsertedId;
                }
                using (var cmd = new MySqlCommand("UPDATE products SET QuantityAvailable=QuantityAvailable-" + Quantity + " WHERE ID=@pid", conn))
                {
                    cmd.Parameters.AddWithValue("@pid", ItemId);
                    cmd.ExecuteNonQuery();
                }
            }

        }

        //internal static List<Order> SearchByCustomerName(string text, ref bool found)
        //{
        //    var cus = new List<Order>();
        //    using (var conn = new MySqlConnection(Kernel.Connection))
        //    using (var cmd = new MySqlCommand("SELECT * FROM orders o, customers c WHERE " + Param + " LIKE '%" + Val + "%'", conn))
        //    {
        //        conn.Open();
        //        using (var reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                cus.Add(new Order(reader.GetInt32("CustomerID"),
        //                    reader.GetInt32("ProductID"),
        //                    reader.GetInt32("Quantity"),
        //                    reader.GetInt32("Amount"),
        //                    reader.GetBoolean("Paid"),
        //                    reader.GetDateTime("OrderDate"),
        //                    reader.GetInt32("OrderID")));
        //            }
        //            Found = true;
        //        }
        //    }
        //    return cus;
        //}

        public static List<Order> Search(string Param, string Val, ref bool Found)
        {
            var cus = new List<Order>();
            using (var conn = new MySqlConnection(Kernel.Connection))
            using (var cmd = new MySqlCommand("SELECT * FROM orders WHERE " + Param + " LIKE '%" + Val + "%'", conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cus.Add(new Order(reader.GetInt32("CustomerID"),
                            reader.GetInt32("ProductID"),
                            reader.GetInt32("Quantity"),
                            reader.GetInt32("Amount"),
                            reader.GetBoolean("Paid"),
                            reader.GetDateTime("OrderDate"),
                            reader.GetInt32("OrderID")));
                    }
                    Found = true;
                }
            }
            return cus;
        }
    }
}
