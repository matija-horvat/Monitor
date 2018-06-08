using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Monitor.Classes;
using System.Data.SqlClient;
using Monitor.Helpers;

namespace Monitor
{
    public partial class Run : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        Parametar param = new Parametar();
        string database = String.Empty;
        Script script = null;
        string sql = String.Empty;
        #endregion

        #region Ctor
        public Run()
        {
            InitializeComponent();
        }

        public Run(Script skripta)
        {
            InitializeComponent();
            param.MPSkriptaId = skripta.MPSkriptaId;
            script = skripta;
            txtScript.Text = skripta.Naziv;
            richInfo.Text = skripta.Info;
        }
        #endregion

        #region Form Events
        private void Run_Load(object sender, EventArgs e)
        {
            dateStart.EditValue = new System.DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dateStart.Properties.Mask.EditMask = "dd, MMMM, yyyy";
            dateStart.Properties.Mask.UseMaskAsDisplayFormat = true;

            dateEnd.EditValue = new System.DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dateEnd.Properties.Mask.EditMask = "dd, MMMM, yyyy";
            dateEnd.Properties.Mask.UseMaskAsDisplayFormat = true;

            Helpers.Reader.FillComboDestData(ref cmbBase1, "SELECT name FROM master..sysdatabases");
            Helpers.Reader.FillComboDestData(ref cmbBase2, "SELECT name FROM master..sysdatabases");
            database = Helpers.Basic.ParseDatabase(Helpers.ConnectionHelper.GetDestConnString());

            for (int i = 0; i < cmbBase1.Properties.Items.Count; i++)
            {
                if (cmbBase1.Properties.Items[i].ToString().ToUpper() == database)
                {
                    cmbBase1.SelectedIndex = i;
                }
            }

            cmbBase2.SelectedIndex = 0;
        }
        #endregion

        #region Button Events
        private void btnRun_Click(object sender, EventArgs e)
        {

            //Building sql for results gridview.
            //If script is store call without default parameters.
            if (script.SQL.Substring(0, 4).ToLower() == "exec")
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@database", cmbBase1.SelectedItem.ToString()));
                parameters.Add(new SqlParameter("@database2", cmbBase2.SelectedItem.ToString()));
                parameters.Add(new SqlParameter("@datumod", dateStart.DateTime.Year + dateStart.DateTime.Month + dateStart.DateTime.Day));
                parameters.Add(new SqlParameter("@datumdo", dateEnd.DateTime.Year + dateEnd.DateTime.Month + dateEnd.DateTime.Day));
                parameters.Add(new SqlParameter("@table", cmbTable1.SelectedItem.ToString()));
                parameters.Add(new SqlParameter("@table2", cmbTable2.SelectedItem.ToString()));
                parameters.Add(new SqlParameter("@string", txtString1.Text));
                parameters.Add(new SqlParameter("@string2", richString2.Text));

                sql = Helpers.Reader.GetSQL(script.SQL, parameters, CommandType.StoredProcedure);

            }
            else
            {
                //If script isnt store call.
                sql = script.SQL.Replace("@database", cmbBase1.SelectedItem.ToString());
                sql = script.SQL.Replace("@database2", cmbBase2.SelectedItem.ToString());
                sql = script.SQL.Replace("@datumod", (dateStart.DateTime.Year + dateStart.DateTime.Month + dateStart.DateTime.Day).ToString());
                sql = script.SQL.Replace("@datumdo", (dateEnd.DateTime.Year + dateEnd.DateTime.Month + dateEnd.DateTime.Day).ToString());
                sql = script.SQL.Replace("@table", cmbTable1.SelectedItem.ToString());
                sql = script.SQL.Replace("@table2", cmbTable2.SelectedItem.ToString());
                sql = script.SQL.Replace("@string", txtString1.Text);
                sql = script.SQL.Replace("@string2", richString2.Text);
            }

            Results result = new Results(sql);
            result.Show();

            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region UI Events
        private void cmbBase1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTable1.Properties.Items.Clear();
            Helpers.Reader.FillComboDestData(ref cmbTable1, "use " + cmbBase1.SelectedItem.ToString() + "; SELECT name as name_id, name FROM sys.Tables order by name");
            cmbTable1.SelectedIndex = 0;
        }

        private void cmbBase2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTable2.Properties.Items.Clear();
            Helpers.Reader.FillComboDestData(ref cmbTable2, "use " + cmbBase2.SelectedItem.ToString() + "; SELECT name as name_id, name FROM sys.Tables order by name");
            cmbTable2.SelectedIndex = 0;
        }
        #endregion
    }
}