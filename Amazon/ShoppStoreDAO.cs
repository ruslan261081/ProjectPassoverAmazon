using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    class ShoppStoreDAO : IShoppStore
    {
       
        public Customer GetCustomerName(string name)
        {
            Customer customer = new Customer();

            using (SqlConnection conn = new SqlConnection(@"Data Source =;Initial Catalog=Amazon;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("ADD_NEW_CUSTOMER_BY_ID", conn);
                cmd.Parameters.Add(new SqlParameter("@FirstName",name));

                cmd.Connection.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.Default);

                while (reader.Read())
                {
                    Customer c = new Customer
                    {
                        Id = (int) reader ["ID"],
                        FirstName = (string) reader ["FIRST NAME"],
                        LastName = (string) reader ["LAST NAME"],
                        CreditNumber = (int) reader ["CREDIT NUMBER"]

                    };
                }

                cmd.Connection.Close();

            }

                return customer;
        }
        public void GetNewCustomer(Customer customer)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=;Initial Catalog= Amazon;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("ADD_NEW_CUSTOMER", conn);
                cmd.Parameters.Add(new SqlParameter("@Id", customer.Id));
                cmd.Parameters.Add(new SqlParameter("@FirstName", customer.FirstName));
                cmd.Parameters.Add(new SqlParameter("@LastName", customer.LastName));
                cmd.Parameters.Add(new SqlParameter("@CreditNumber", customer.CreditNumber));

                cmd.Connection.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

                cmd.Connection.Close();

            }
            
        }
        public void GetOrders(int id)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source =;Initial Catalog=Amazon;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("ADD_NEW_ORDERS_BY_ID", conn);
                cmd.Parameters.Add(new SqlParameter("@ID", id));

                cmd.Connection.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.Default);

                while (reader.Read())
                {
                    Orders c = new Orders
                    {
                        Id = (int)reader["ID"],
                        FirstName = (string)reader["FIRST NAME"],
                        LastName = (string)reader["LAST NAME"],
                        Product = (string)reader["PRODUCT"],
                        Price = (float)reader ["PRICE"]

                    };
                }

                cmd.Connection.Close();

            }
        }
        public void GetNewOrders(Orders orders)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=;Initial Catalog= Amazon;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("ADD_NEW_CUSTOMER", conn);
                cmd.Parameters.Add(new SqlParameter("@Id", orders.Id));
                cmd.Parameters.Add(new SqlParameter("@FirstName", orders.FirstName));
                cmd.Parameters.Add(new SqlParameter("@LastName", orders.LastName));
                cmd.Parameters.Add(new SqlParameter("@Product", orders.Product));
                cmd.Parameters.Add(new SqlParameter("@Price", orders.Price));

                cmd.Connection.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

                cmd.Connection.Close();

            }
            
        }

        public  Supplier GetSupplierByName(string name)
        {
            Supplier supplier = new Supplier();

            using (SqlConnection conn = new SqlConnection(@"Data Source =;Initial Catalog=Amazon;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("ADD_NEW_SUPPLIER_BY_NAME", conn);
                cmd.Parameters.Add(new SqlParameter("@FirstName", name));

                cmd.Connection.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.Default);

                while (reader.Read())
                {
                    Supplier c = new Supplier
                    {
                        Id = (int)reader["ID"],
                        FirstName = (string)reader["FIRST NAME"],
                        LastName = (string)reader["LAST NAME"],
                        Country = (string)reader ["COUNTRY"],
                        Address = (string)reader ["ADDRESS"],
                        NumberOfProduct = (float)reader ["NUMBER OF PRODUCT"]

                    };
                }
                

                cmd.Connection.Close();

            }
            return supplier;
            
        }
        public void  GetSupplierNewSupplier(Supplier supplier)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=;Initial Catalog= Amazon;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("ADD_NEW_SUPPLIER", conn);
                cmd.Parameters.Add(new SqlParameter("@Id", supplier.Id));
                cmd.Parameters.Add(new SqlParameter("@FirstName", supplier.FirstName));
                cmd.Parameters.Add(new SqlParameter("@LastName", supplier.LastName));
                cmd.Parameters.Add(new SqlParameter("@Country", supplier.Country));
                cmd.Parameters.Add(new SqlParameter("@Address", supplier.Address));
                cmd.Parameters.Add(new SqlParameter("@NumberofProduct", supplier.NumberOfProduct));

                cmd.Connection.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

                cmd.Connection.Close();

            }
            
        }
       

       

    }
}
