using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;

namespace Monitor
{
    public partial class ScriptView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Fields
        private string _database;
        public string Database
        {
            get { return _database; }
            set { _database = value; }
        }

        private string _sql;
        public string Sql
        {
            get { return _sql; }
            set { _sql = value; }
        }
        #endregion

        #region Ctor
        public ScriptView()
        {
            InitializeComponent();
        }

        public ScriptView(string database, string sql)
        {
            this.Database = database;
            this.Sql = sql;
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void ScriptView_Load(object sender, EventArgs e)
        {

            SqlParameter[] parameters = { new SqlParameter("@database", Database), new SqlParameter("@sql", Sql) };

            Helpers.Reader.GetStoreProcedureText(ref gridStora, "spMPGetStoreProcedureText", parameters, CommandType.StoredProcedure);

           // Helpers.Basic.FitGridColumns(ref gridViewStora);
        }
        #endregion

        #region Button Events
        private void barBtnIzlaz_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
        #endregion

        private void barBtnExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|SQL files (*.sql)|*.sql";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            DataTable table = new DataTable();

             //table.DataSet =  gridStora.DataSource;
            DataRow row;
            StringBuilder result = new StringBuilder();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = File.CreateText(saveFileDialog1.FileName))
                {
                    for (int i = 0; i < gridStora.MainView.RowCount; i++)
                    {
                        row = (DataRow)(((GridView)gridStora.MainView).GetDataRow(i));
                        sw.Write(row["Text9000"].ToString());
                    }
                }
            }

            //        For Each row As DataRow In dt.Rows
            //    For Each col As DataColumn In dt.Columns
            //        result.Append(row(col.ColumnName).ToString.PadLeft(widths(col.Ordinal)))
            //        result.Append(ColumnSeparator)
            //    Next
            //    result.AppendLine()
            //Next

            //Return result.ToString()

           
   
        }
    }
}