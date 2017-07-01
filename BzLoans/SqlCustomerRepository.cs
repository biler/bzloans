using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace BzLoans
{
    class SqlCustomerRepository : RepositoryInterface
    {
        public List<Customer> All() {
            SqlCommand cmd = new SqlCommand("SELECT * FROM main.customers", Program.Connection);

            List<Customer> output  = new List<Customer>();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.name = (String) reader[0];
                output.Add(customer);
            }
            reader.Close();
            return output;
        }
    }
}
