using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Databases_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartScreen());
        }
        //"Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
        public static String connectionString = "Data Source=KAAN-HP\\SQLEXPRESS;Initial Catalog=JourneyGame_DBClass;User ID=Kaan;Password=admin";
    }
}
