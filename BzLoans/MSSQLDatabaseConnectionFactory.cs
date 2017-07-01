using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;


namespace BzLoans
{
    class MSSQLDatabaseConnectionFactory
    {
        public SqlConnection create() {
            String cs = "Persist Security Info = False; User ID = " +
                Program.settings.db_username +
                "; Password = " +
                Program.settings.db_username +
                "; Initial Catalog = " +
                Program.settings.db_name +
                "; Server = " +
                Program.settings.db_host;

            SqlConnection cn = new SqlConnection(cs);
            return cn;
        } // create
    }
}
