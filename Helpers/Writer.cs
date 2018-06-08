using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Monitor.Classes;

namespace Monitor.Helpers
{
    class Writer: Helpers.ConnectionHelper
    {

        private static void Execute()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageErrorDialog error = new MessageErrorDialog("Izvor!?", "Ažuriranje podataka na izvoru nije uspjelo! Provjerite ConnString izvora i dostupnost.", ex.ToString());
                error.ShowDialog();
            }
        }

        /// <summary>
        /// Insert, update or delete script from database. Store procedure spMPMonitor required. 
        /// </summary>
        /// <param name="data">Object to work for.</param>
        /// <param name="procedureName">Store procedure for query. Must be in source database.</param>
        /// <param name="action">Action in stored procedure wich will trigger on.</param>
        /// <param name="statement">String represent statement: 'insert' or 'update'.</param>
        public static void InsertUpdateDelete(object data, string procedureName, int action, string statement)
        {
            PrepareSourceConn(CommandType.StoredProcedure);
            cmd.CommandText = procedureName;
            cmd.Parameters.Add(new SqlParameter("@action", action));
            
            switch (data.GetType().ToString())
            {
                case "Monitor.Classes.Script": BuildScriptParam((Script)data, statement);
                    break;
                case "Monitor.Classes.Destination": BuildDestParam((Destination)data, null);
                    break;
            }

            Execute();
        }

        private static void BuildScriptParam(Script script, string statement)
        {
            if (statement.ToUpper() == "UPDATE" || statement.ToUpper() == "DELETE")
                cmd.Parameters.Add(new SqlParameter("@mpskriptaid", script.MPSkriptaId));

            cmd.Parameters.Add(new SqlParameter("@Oznaka", script.Oznaka));
            cmd.Parameters.Add(new SqlParameter("@Naziv", script.Naziv));
            cmd.Parameters.Add(new SqlParameter("@Sql", script.SQL));
            cmd.Parameters.Add(new SqlParameter("@info", script.Info));
        }

        private static void BuildDestParam(Destination dest, string statement)
        {
            cmd.Parameters.Add(new SqlParameter("@ip", dest.IP));
            cmd.Parameters.Add(new SqlParameter("@userid", dest.UserId));
            cmd.Parameters.Add(new SqlParameter("@password", dest.Password));
            
        }
    }
}
