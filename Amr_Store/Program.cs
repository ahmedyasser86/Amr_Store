using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motaz_Store
{
    public static class Program
    {
        public static MainForm main;
        public static LogIn logIn;
        public static string Backup;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Check DB Conniction and Open it
            myDB.OpenConn();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Open Login Form
            logIn = new LogIn();
            Application.Run(logIn);
            // Real User
            if(Session.username != null)
            {
                // Check For Update
                Update.CheckForUpdates();
                // Open the app
                main = new MainForm();
                Application.Run(main);
                // Backup after application close
                myDB.BackUp(Backup);
            }
            // Finaly Close DB
            myDB.CloseConn();
        }
    }
}
