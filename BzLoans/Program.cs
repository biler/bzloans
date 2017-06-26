using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleInjector;

namespace BzLoans
{
    static class Program
    {
        public static Container container;
        public static Settings settings;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(new frmMain());
        }

        private static void Bootstrap()
        {
            settings = new Settings();

            container = new Container();

            container.Register<RepositoryInterface, SqlCustomerRepository>();
            container.Verify();
        }
    }
}
