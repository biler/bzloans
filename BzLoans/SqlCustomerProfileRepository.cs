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
                customer.Zip = reader["zip"].ToString();
                customer.Email = reader["email"].ToString();
                customer.Phone = reader["phone_number"].ToString();
                customer.Telephone = reader["tel_no"].ToString();

                output.Add(customer);
            }
            reader.Close();
            return output;
        }

        public CustomerProfile Add(CustomerProfile profile)
        {
            string query = "INSERT INTO main.customer_profiles (" 
                + " first_name, middle_name, last_name, birthdate, title, customer_id, address1, address2,city, state, country, zip, email, phone_number, tel_no  "
                + ") VALUES (" 
                + " @first_name, @middle_name, @last_name, @birthdate, @title, @customer_id, @address1, @address2, @city, @state, @country, @zip, @email, @phone_number, @tel_no" + ")";


            SqlCommand cmd = new SqlCommand( query, Program.Connection);

            cmd.Parameters.Add("@first_name", SqlDbType.VarChar,50).Value = profile.FirstName;
            cmd.Parameters.Add("@middle_name", SqlDbType.VarChar, 50).Value = profile.MiddleName;
            cmd.Parameters.Add("@last_name", SqlDbType.VarChar, 50).Value = profile.LastName;
            cmd.Parameters.Add("@birthdate", SqlDbType.DateTime).Value = profile.Birthdate;
            cmd.Parameters.Add("@title", SqlDbType.VarChar, 50).Value = profile.Title;
            cmd.Parameters.Add("@customer_id",SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@address1", SqlDbType.VarChar, 50).Value = profile.Address1;
            cmd.Parameters.Add("@address2", SqlDbType.VarChar, 50).Value = profile.Address2;
            cmd.Parameters.Add("@city", SqlDbType.VarChar, 50).Value = profile.City;
            cmd.Parameters.Add("@state", SqlDbType.VarChar, 50).Value = profile.State;
            cmd.Parameters.Add("@country", SqlDbType.VarChar, 50).Value = profile.Country;
            cmd.Parameters.Add("@zip", SqlDbType.VarChar, 50).Value = profile.Zip;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = profile.Email;
            cmd.Parameters.Add("@phone_number", SqlDbType.VarChar, 50).Value = profile.Phone;
            cmd.Parameters.Add("@tel_no", SqlDbType.VarChar, 50).Value = profile.Telephone;

            cmd.ExecuteNonQuery();

            return profile;
        }
    }
}
