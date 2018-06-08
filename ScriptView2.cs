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
using Monitor.Classes;
using DevExpress.XtraRichEdit.Services;
using Monitor.Helpers;

namespace Monitor
{
    public partial class ScriptView2 : DevExpress.XtraBars.Ribbon.RibbonForm
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

        
        DataRow row;
        StringBuilder result = new StringBuilder();
        #endregion

        #region Ctor
        public ScriptView2()
        {
            InitializeComponent();
            //richSql.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft;
            richSql.ReplaceService<ISyntaxHighlightService>(new CustomSyntaxHighlightService(richSql.Document));
        }

        public ScriptView2(string database, string sql)
        {
            this.Database = database;
            this.Sql = sql;
            InitializeComponent();
            //richSql.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft;
            richSql.ReplaceService<ISyntaxHighlightService>(new CustomSyntaxHighlightService(richSql.Document));
        }
        #endregion

        #region Form Events
        private void ScriptView2_Load(object sender, EventArgs e)
        {
            SqlParameter[] parameters = { new SqlParameter("@database", Database), new SqlParameter("@sql", Sql) };

            Helpers.Reader.GetStoreProcedureText(ref gridSkripte, "spMPGetStoreProcedureText", parameters, CommandType.StoredProcedure);

            for (int i = 0; i < gridSkripte.MainView.RowCount; i++)
            {
                row = (DataRow)(((GridView)gridSkripte.MainView).GetDataRow(i));
                //sw.Write(row["Text9000"].ToString());
                result.Append(row["Text9000"].ToString());
            }

            richSql.Text = result.ToString();

        }
        #endregion

        #region Button Events
        private void barBtnExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = Basic.PrepareSaveDialog();

            DataRow row;
            StringBuilder result = new StringBuilder();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = File.CreateText(saveFileDialog1.FileName))
                {
                    for (int i = 0; i < gridSkripte.MainView.RowCount; i++)
                    {
                        row = (DataRow)(((GridView)gridSkripte.MainView).GetDataRow(i));
                        sw.Write(row["Text9000"].ToString());
                    }
                }
            }
        }

        private void barBtnIzlaz_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}