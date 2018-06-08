using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Services;
using Monitor.Classes;

namespace Monitor
{
    public partial class Results : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private string _sql;
        public string Sql
        {
            get { return _sql; }
            set { _sql = value; }
        }
        #endregion

        #region Ctor
        public Results()
        {
            InitializeComponent();
            richSql.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft;
            richSql.ReplaceService<ISyntaxHighlightService>(new CustomSyntaxHighlightService(richSql.Document));
           
        }

        public Results(string sql)
        {
            InitializeComponent();
            
            richSql.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft;
            richSql.ReplaceService<ISyntaxHighlightService>(new CustomSyntaxHighlightService(richSql.Document));
            richSql.Text = sql;
            this.Sql = sql;
        }
        #endregion

        #region Form Events
        private void Results_Load(object sender, EventArgs e)
        {
            Helpers.Reader.GridDataSet(ref gridResults, Sql, CommandType.Text, false);
            Helpers.Basic.FitGridColumns(ref gridView1, false, String.Empty);
            this.gridView1.OptionsBehavior.Editable = false;
        }
        #endregion

        #region Button Events
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}