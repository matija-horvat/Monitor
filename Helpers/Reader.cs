using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

namespace Monitor.Helpers
{
    class Reader: Helpers.ConnectionHelper
    {
        protected static string Sql = String.Empty;

        private static void ExecuteGridReader(ref GridControl grid)
        {
            try
            {
                if (ConnectionHelper.conn.State == ConnectionState.Open)
                    ConnectionHelper.conn.Close();
                try
                {
                    ConnectionHelper.conn.Open();
                }
                catch(SqlException ex)
                {
                    MessageErrorDialog error = new MessageErrorDialog("Izvor!?", "Spajanje na bazu nije uspjelo! Provjerite ConnString izvora.", ex.ToString());
                    error.ShowDialog();
                    return;
                }
                
                ConnectionHelper.ds = new DataSet();
                ConnectionHelper.adapter.Fill(ConnectionHelper.ds);
                ConnectionHelper.conn.Close();

                grid.DataSource = ConnectionHelper.ds.Tables[0];

            }
            catch (SqlException ex)
            {
                ConnectionHelper.conn.Close();
                MessageErrorDialog error = new MessageErrorDialog("Izvor!?", "Spajanje na bazu izvora nije uspjelo! Provjerite ConnString izvora i dostupnost.", ex.ToString());
                error.ShowDialog();
                
            }

            ConnectionHelper.conn.Dispose();

        }

        private static string Execute()
        {
            try
            {
                if (ConnectionHelper.conn.State == ConnectionState.Open)
                    ConnectionHelper.conn.Close();

                ConnectionHelper.conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Sql = reader.GetString(0);
                }
                
                conn.Close();
                ConnectionHelper.conn.Dispose();

            }
            catch (SqlException ex)
            {
                ConnectionHelper.conn.Close();
                MessageErrorDialog error = new MessageErrorDialog("Izvor!?", "Spajanje na bazu izvora nije uspjelo! Provjerite ConnString izvora i dostupnost.", ex.ToString());
                error.ShowDialog();
                ConnectionHelper.conn.Dispose();
                return String.Empty;
            }

            return Sql;

        }

        /// <summary>
        /// Method for fill gridview with data.
        /// </summary>
        /// <param name="grid">GridControl for fill.</param>
        /// <param name="sql">SQL query without parameters.</param>
        /// <param name="cmdType"></param>
        /// <param name="source">True - look for data on source, false - look for data on destination.</param>
        public static void GridDataSet(ref GridControl grid, string sql, CommandType cmdType, bool source)
        {
            //GetOpenVPN();
            if (source)
                PrepareSourceConn(cmdType);
            else
                PrepareDestConn(cmdType);
            

            adapter = new SqlDataAdapter(sql, conn);

            ExecuteGridReader(ref grid);
        }

        public static void GetStoreProcedureText(ref GridControl grid, string query, SqlParameter[] paramCollection,  CommandType cmdType)
        {
            PrepareSourceConn(cmdType);
            cmd.CommandText = query;
            
            foreach (SqlParameter param in paramCollection)
            {
                cmd.Parameters.Add(param);
            }

            
            adapter = new SqlDataAdapter(cmd);

            ExecuteGridReader(ref grid);

        }

        public static string GetSQL(string script, List<SqlParameter> paramCollection, CommandType cmdType)
        {
            PrepareSourceConn(cmdType);
            cmd.CommandText = Basic.ParseScriptForStoreName(script);
            
            foreach (SqlParameter param in paramCollection)
            {
                cmd.Parameters.Add(param);
            }

            return Execute();

        }

        private static void BuildStoreProcTextParam()
        {
           
        }

        public static void GetDatabases(ref ComboBoxEdit cmbDatabase, ComboBoxEdit cmbServer, string username, string password)
        {
            conn = new SqlConnection("Data source=" + cmbServer.SelectedItem.ToString() + ";User ID=" + username);

            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_databases";

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();
                reader = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                MessageErrorDialog error = new MessageErrorDialog("Izvor!?", "Čitanje baza na izvoru nije uspjelo! Provjerite ConnString izvora i dostupnost.", ex.ToString());
                error.ShowDialog();
                return;
            }

            cmbDatabase.Properties.Items.Clear();
            while (reader.Read())
            {
                cmbDatabase.Properties.Items.Add(reader.GetString(0));
            }

            reader.Close();
            conn.Close();
        }

        /// <summary>
        /// This procedure is used before destination ConnString was created. For any subsequent use GetDestDatabases2.
        /// </summary>
        /// <param name="cmbDatabase"></param>
        /// <param name="server"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public static void GetDestDatabases(ref ComboBoxEdit cmbDatabase, string server, string username, string password)
        {
            conn = new SqlConnection("Data source=" + server + ";User ID=" + username + ";Password=" + password);

            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_databases";

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();
                reader = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                MessageErrorDialog error = new MessageErrorDialog("Destinacija!?", "Čitanje baza na destinaciji nije uspjelo! Provjerite ConnString destinacije i VPN.", ex.ToString());
                error.ShowDialog();
                return;
            }

            cmbDatabase.Properties.Items.Clear();
            while (reader.Read())
            {
                cmbDatabase.Properties.Items.Add(reader.GetString(0));
            }

            reader.Close();
            conn.Close();
        }

        /// <summary>
        /// Use this procedure when destination connString is known.
        /// </summary>
        /// <param name="cmbDatabase"></param>
        public static void GetDestDatabases2(ref ComboBoxEdit cmbDatabase)
        {
            conn = new SqlConnection(GetDestConnString());

            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT name FROM master..sysdatabases";

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();
                reader = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                MessageErrorDialog error = new MessageErrorDialog("Destinacija!?", "Čitanje baza na destinaciji nije uspjelo! Provjerite ConnString destinacije i VPN.", ex.ToString());
                error.ShowDialog();
                return;
            }

            cmbDatabase.Properties.Items.Clear();
            while (reader.Read())
            {
                cmbDatabase.Properties.Items.Add(reader.GetString(0));
            }

            reader.Close();
            conn.Close();
        }

        /// <summary>
        /// Use this procedure when destination connString is known.
        /// </summary>
        /// <param name="combo"></param>
        /// <param name="query"></param>
        public static void FillComboDestData(ref ComboBoxEdit combo, string query)
        {
            conn = new SqlConnection(GetDestConnString());

            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();
                reader = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                MessageErrorDialog error = new MessageErrorDialog("Destinacija!?", "Čitanje podataka na destinaciji nije uspjelo! Provjerite ConnString destinacije i VPN.", ex.ToString());
                error.ShowDialog();
                return;
            }

            combo.Properties.Items.Clear();
            while (reader.Read())
            {
                combo.Properties.Items.Add(reader.GetString(0));
            }

            reader.Close();
            conn.Close();
        }

        public static string TestConnection(string connString)
        {
            PrepareSourceConn(CommandType.Text);
            conn.ConnectionString = connString;

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();
                conn.Close();
                return "Konekcija uspješna!";
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                MessageErrorDialog error = new MessageErrorDialog("Spajanje!?", "Spajanje sa navedenim ConnString-om nije uspjelo.", ex.ToString());
                error.ShowDialog();
                return  "Konekcija nije uspjela!";
            }
        }

        //public static void GetOpenVPN()
        //{
        //    bool state = false;
        //    VPNmanager vpn = new VPNmanager("Biovega VPN", "192.168.5.249");
        //    state = vpn.TestConnection();

        //    MessageBox.Show("Biovega VPN = " + state.ToString());


        //}

    }
}
