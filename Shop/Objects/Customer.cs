using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop.Objects
{
    public class Customer
    {
        public string Name, Phone, ShippingAddress, Email, Instagram_user;
        public int ID
        {
            get;
            set;
        }
        public Customer()
        {

        }
        public Customer(string Name, string Phone, string ShippingAddress, string Email, string Instagram_user, int ID = 0)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.ShippingAddress = ShippingAddress;
            this.Email = Email;
            this.Instagram_user = Instagram_user;
            this.ID = ID;
        }
        public void Insert()
        {
            using (var conn = new MySqlConnection(Kernel.Connection))
            using (var cmd = new MySqlCommand("INSERT INTO customers (CustomerName,PhoneNo,Address,IGUser,Email)"
                + " VALUES (@name,@phone,@address,@insta,@email)", conn))
            {
                conn.Open();
                try
                {
                    cmd.Parameters.AddWithValue("@name", Name);
                    cmd.Parameters.AddWithValue("@phone", Phone);
                    cmd.Parameters.AddWithValue("@address", ShippingAddress);
                    cmd.Parameters.AddWithValue("@insta", Instagram_user);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.ExecuteNonQuery();
                    ID = (int)cmd.LastInsertedId;
                    MessageBox.Show("Inserted new customer.");
                }
                catch (Exception e)
                {
                    Kernel.LogError(e.Message);
                }
            }
        }
        public static List<Customer> Search(string Param, string Val, ref bool Found)
        {
            var cus = new List<Customer>();
            using (var conn = new MySqlConnection(Kernel.Connection))
            using (var cmd = new MySqlCommand("SELECT * FROM customers WHERE " + Param + " LIKE '%" + Val + "%'", conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cus.Add(new Customer(reader.GetString("CustomerName"),
                            reader.GetString("PhoneNo"),
                            reader.GetString("Address"),
                            reader.GetString("IGUser"),
                            reader.GetString("Email"),
                            reader.GetInt32("ID")));
                    }
                    Found = true;
                }
            }
            return cus;
        }

        internal void Update()
        {
            using (var conn = new MySqlConnection(Kernel.Connection))
            using (var cmd = new MySqlCommand("UPDATE customers SET CustomerName=@name,PhoneNo=@phone,"
                + "Address=@address,IGUser=@insta,Email=@email WHERE ID=@id", conn))
            {
                conn.Open();
                try
                {
                    cmd.Parameters.AddWithValue("@name", Name);
                    cmd.Parameters.AddWithValue("@phone", Phone);
                    cmd.Parameters.AddWithValue("@address", ShippingAddress);
                    cmd.Parameters.AddWithValue("@insta", Instagram_user);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated customer.");
                }
                catch (Exception e)
                {
                    Kernel.LogError(e.Message);
                }
            }
        }
    }
}
