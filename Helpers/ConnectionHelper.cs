using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;

namespace Monitor.Helpers
{
    class ConnectionHelper
    {
        #region Fields
        public static String sourceConnString = String.Empty;
        public static String destConnString = String.Empty;
        public static string[] serverSourceList = null;
        protected static SqlConnection conn = null;
        protected static SqlCommand cmd = null;
        protected static SqlDataReader reader = null;
        protected static SqlDataAdapter adapter = null;
        protected DataTable table = null;
        protected static DataSet ds = null;
        protected static string appPath = String.Empty;
        
        #endregion

        protected static void PrepareSourceConn(CommandType cmdType)
        {
            conn = new SqlConnection(GetSourceConnString());
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = cmdType;
        }

        protected static void PrepareDestConn(CommandType cmdType)
        {
            conn = new SqlConnection(GetDestConnString());
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = cmdType;
        }

        public static void SetSpinConnString(String provider, String server, String database, String username, String password)
        {
            //OLEDB Provider=SQLOLEDB.1;User ID=sa;Initial Catalog=EU3
            //connStrSpin = "Provider=" + provider + ";User Id=" + username + ";Password=" + ";Initial Catalog=" + database;
            //myConnection = "server=localhost; Integrated Security=SSPI;User ID=sa;Initial Catalog=Example;Data Source=PPL\SQLSERVER;Trusted_Connection=yes;"
            //MSDE default = "Server=MATIJAH;Database=EU3;UID=sa;PWD=";
            //SQL Server 2008 r2 = "Data Source=JUPITER2008R2;Initial Catalog=Pekarstvo;User ID=sa"
            sourceConnString = "Data Source=" + server + ";Database=" + database + ";UID=" + username + ";PWD=";

        }

        public static string GetSourceConnString()
        {
            appPath = Path.GetDirectoryName(Application.ExecutablePath);

            try
            {
                if (System.IO.File.Exists(appPath + "\\SourceConnString.txt"))
                {
                    return System.IO.File.ReadAllText(appPath + "\\SourceConnString.txt");
                }
                else
                {
                    //create file
                    System.IO.File.WriteAllText(appPath + "\\SourceConnString.txt", "");
                    return String.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageErrorDialog error = new MessageErrorDialog(".txt datoteka!?", "Čitanje i pisanje iz datoteke SourceConnString.txt nije uspjelo.", ex.ToString());
                error.ShowDialog();
                return String.Empty;

            }
        }

        public static string GetDestConnString()
        {
            appPath = Path.GetDirectoryName(Application.ExecutablePath);

            try
            {
                if (System.IO.File.Exists(appPath + "\\DestConnString.txt"))
                {
                    return System.IO.File.ReadAllText(appPath + "\\DestConnString.txt");
                }
                else
                {
                    //create file
                    System.IO.File.WriteAllText(appPath + "\\DestConnString.txt", "");
                    return "";
                }
            }
            catch (Exception ex)
            {
                MessageErrorDialog error = new MessageErrorDialog(".txt datoteka!?", "Čitanje i pisanje iz datoteke DestConnString.txt nije uspjelo.", ex.ToString());
                error.ShowDialog();
                return ex.ToString();

            }
        }

        public static void SetSourceConnString(string connString)
        {
            // write a line of text to the file
            System.IO.File.WriteAllText(appPath + "\\SourceConnString.txt", connString);
        }

        public static void SetDestConnString(string connString)
        {
            // write a line of text to the file
            System.IO.File.WriteAllText(appPath + "\\DestConnString.txt", connString);
        }

        public static void GetOpenVPN()
        {
            bool state = false;
            VPNmanager vpn = new VPNmanager("", "");
            state = vpn.TestConnection();
        
        
        }
       
    }
}
