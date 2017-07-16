using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BzLoans
{
    class CustomerProfile
    {
        public Int32 Id { get; set; }
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public String Title { get; set; }
        public Int32 CustomerId { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Country { get; set; }
        public String Zip { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public String Telephone { get; set; }
    }
}
