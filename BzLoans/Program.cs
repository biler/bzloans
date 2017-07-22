using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleInjector;
using System.Data.SqlClient;
using LazyCache;

namespace BzLoans
{
    static class Program
    {
        public static Container container;
        public static Settings settings;
        public static SqlConnection Connection;
        public static IAppCache Cache;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            ConnectToDB();

            Application.Run(new frmMain());
        }

        private static void Bootstrap()
        {
            settings = new Settings();

            container = new Container();

            container.Register<RepositoryInterface, SqlCustomerRepository>();
            container.Verify();

            Cache = new CachingService();

        }

        private static void ConnectToDB() {

            MSSQLDatabaseConnectionFactory factory = new MSSQLDatabaseConnectionFactory();
            Connection = factory.create();

            try
            {
                Connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
}
    }
}
