using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;

namespace Monitor
{
    public partial class Deadlocks : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Fields
        private string _sql;
        public string Sql
        {
            get { return _sql; }
            set { _sql = value; }
        }

        private string _xml;
        public string Xml
        {
            get { return _xml; }
            set { _xml = value; }
        }

        private string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        #endregion

        public Deadlocks()
        {
            InitializeComponent();
        }

        private void Deadlocks_Load(object sender, EventArgs e)
        {

            Sql = @"set arithabort on;"
                   +  " WITH SystemHealth "
                   +  " AS ("
                   +  " SELECT CAST(target_data as xml) AS TargetData"
                   +  " FROM sys.dm_xe_session_targets st"
                   +  " JOIN sys.dm_xe_sessions s"
                   +  " ON s.address = st.event_session_address"
                   +  " WHERE name = 'system_health'"
                   +  " AND st.target_name = 'ring_buffer')"
 
                   +  " SELECT cast(XEventData.XEvent.value('(data/value)[1]','VARCHAR(MAX)') as xml) AS DeadLockGraph"
                   +  " into #t_xmldata"
                   +  " FROM SystemHealth"
                   +  " CROSS APPLY TargetData.nodes('//RingBufferTarget/event') AS XEventData (XEvent)"
                   +  " WHERE XEventData.XEvent.value('@name','varchar(4000)') = 'xml_deadlock_report'"
                   +  " select * from #t_xmldata;"
                   +  " set arithabort off;";



            Helpers.Reader.GridDataSet(ref gridResults, Sql, CommandType.Text, true);
            Helpers.Basic.FitGridColumns(ref gridView1, false, String.Empty);
            this.gridView1.OptionsBehavior.Editable = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int[] selRows = ((GridView)gridResults.MainView).GetSelectedRows();
            DataRowView selRow = (DataRowView)(((GridView)gridResults.MainView).GetRow(selRows[0]));

            if (selRow == null)
            {
                return;
            }

            Xml = selRow["DeadLockGraph"].ToString();


            try
            {
                if (System.IO.File.Exists(appPath + "\\data.xml"))
                {
                    //ako postoji obriši pa snimi
                    System.IO.File.Delete(appPath + "\\data.xml");
                    System.IO.File.WriteAllText(appPath + "\\data.xml", Xml);
                }
                else
                {
                    //samo snimi
                    System.IO.File.WriteAllText(appPath + "\\data.xml", Xml);

                }
            }
            catch (Exception ex)
            {
                MessageErrorDialog error = new MessageErrorDialog(".txt datoteka!?", "Pisanje xml-a u datoteku nije uspjelo.", ex.ToString());
                error.ShowDialog();
            }


            DataSet dataSet = new DataSet();
            dataSet.ReadXml(appPath + "\\data.xml");
            //treeDeadlock.DataSource = dataSet.Tables[0];
            gridControl1.DataSource = dataSet.Tables[0];
        }
    }
}