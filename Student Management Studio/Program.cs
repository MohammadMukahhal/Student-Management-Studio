using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_Studio
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                ConnectionStringSettingsCollection ConnectionStrings = ConfigurationManager.ConnectionStrings;
                string path = null;
                // Always program defensively when processing data that could be modified by a user, in case they screw it up
                if (ConnectionStrings != null && ConnectionStrings["MyConnectionString"] != null)
                    path = ConnectionStrings["MyConnectionString"].ConnectionString;
                //string path = @"Data Source=MUKAHHAL\SQLEXPRESS; Initial Catalog=student_management_studio;Integrated Security=True";
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Login(path));
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
