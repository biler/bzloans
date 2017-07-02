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
                customer.Id = (Int32)reader[0];
                output.Add(customer);
            }
            reader.Close();
            return output;
        }
    }
}
