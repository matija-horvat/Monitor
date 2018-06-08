using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraRichEdit.Services;
using Monitor.Classes;
using System.IO;
using Monitor.Helpers;

namespace Monitor
{
    public partial class RunLive : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        private string sql = String.Empty;
        public RunLive()
        {
            InitializeComponent();
            //richSql.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft;
            richSql.ReplaceService<ISyntaxHighlightService>(new CustomSyntaxHighlightService(richSql.Document));
           
        }

        private void RunLive_Load(object sender, EventArgs e)
        {
            richSql.Document.DefaultCharacterProperties.FontSize = 12;
            this.gridView1.OptionsBehavior.Editable = false;
        }

        private void barBtnRun_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            if (richSql.Document.GetText(richSql.Document.Selection).Length > 0)
            {
                sql = richSql.Document.GetText(richSql.Document.Selection);
            }
            else
            {
                sql = richSql.Text;
            }

            gridView1.Columns.Clear();
            gridResults.DataSource = null;
            Helpers.Reader.GridDataSet(ref gridResults, sql, CommandType.Text, false);
            //Helpers.Basic.FitGridColumns(ref gridView1, false, String.Empty);

        }

        private void barBtnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void barBtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {

            SaveFileDialog saveFileDialog1 = Basic.PrepareSaveDialog();

            StringBuilder result = new StringBuilder();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = File.CreateText(saveFileDialog1.FileName))
                {
                    sw.Write(richSql.Text);
                }    
                
            }
        }


    }
}