using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace BzLoans
{
    class SqlCustomerProfileRepository : RepositoryInterface
    {
        public List<CustomerProfile> All()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM main.customer_profiles", Program.Connection);

            List<CustomerProfile> output = new List<CustomerProfile>();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CustomerProfile customer = new CustomerProfile();

                customer.Id = (Int32)reader["id"];
                customer.FirstName = reader["first_name"].ToString();
                customer.MiddleName = reader["middle_name"].ToString();
                customer.LastName = reader["last_name"].ToString();
                customer.Title = reader["title"].ToString();
                customer.Birthdate = (DateTime) reader["birthdate"];
                customer.CustomerId = (Int32) reader["customer_id"];
                customer.Address1 = reader["address1"].ToString();
                customer.Address2 = reader["address2"].ToString();
                customer.City = reader["city"].ToString();
                customer.State = reader["state"].ToString();
                customer.Country = reader["country"].ToString();
                customer.Zip = (Int32)reader["zip"];
                customer.Email = reader["email"].ToString();
                customer.Phone = reader["phone_number"].ToString();
                customer.Telephone = reader["tel_no"].ToString();

                output.Add(customer);
            }
            reader.Close();
            return output;
        }
    }
}
