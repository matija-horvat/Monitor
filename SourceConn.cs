using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Sql;
using DevExpress.XtraEditors.Controls;
using System.IO;
using Monitor.Helpers;
using Monitor.Classes;

namespace Monitor
{
    public partial class SourceConn : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private DataTable tblServer = null;
        ServerSource serverSource = null;
        #endregion

        #region Ctor
        public SourceConn(ref ServerSource serverSource)
        {
            InitializeComponent();
            this.serverSource = serverSource;
            btnOdustani.Appearance.BackColor = Color.RosyBrown;
            btnOdustani.Appearance.BackColor2 = Color.LightCoral;
            btnOdustani.Appearance.ForeColor = Color.Maroon;
            btnOdustani.Text = "Zatvori";
        }

        public SourceConn()
        {
            InitializeComponent();
            btnOdustani.Appearance.BackColor = Color.CadetBlue;
            btnOdustani.Appearance.BackColor2 = Color.LightCoral;
            btnOdustani.Appearance.ForeColor = Color.LightBlue;
            btnOdustani.Text = "Pokreni Monitor";
        }
        #endregion

        #region Form Events
        private void SourceConn_Load(object sender, EventArgs e)
        {
            
            memConnString.Text = ConnectionHelper.GetSourceConnString();
            txtLogin.Text = "sa";
            
            if (cmbServer.Properties.Items.Count == 0)
            {
                if (serverSource == null)
                {
                    tblServer = new DataTable();
                    tblServer = SqlDataSourceEnumerator.Instance.GetDataSources();
                    serverSource = new ServerSource();
                    serverSource.List = new string[tblServer.Rows.Count];

                    for (int i = 0; i < tblServer.Rows.Count; i++)
                    {
                        cmbServer.Properties.Items.Add(tblServer.Rows[i].ItemArray.First().ToString());
                        serverSource.List[i] = tblServer.Rows[i].ItemArray.First().ToString();
                    }
                }
                else
                {
                    for (int i = 0; i < serverSource.List.Count(); i++)
                    {
                        cmbServer.Properties.Items.Add(serverSource.List[i].ToString());
                    }
                }
                
            }
        }
        #endregion

        #region UI Events
        private void cmbServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDatabase.Properties.Items.Clear();
            Helpers.Reader.GetDatabases(ref cmbDatabase, cmbServer, txtLogin.Text, txtPassword.Text);
        }

        private void cmbServer_Click(object sender, EventArgs e)
        {
           
        }
        #endregion

        #region Button Events
        private void btnBuildConnString_Click(object sender, EventArgs e)
        {
            memConnString.Text = "Data source=" + cmbServer.SelectedItem.ToString() + ";Initial Catalog=" + cmbDatabase.SelectedItem.ToString() + ";User ID=" + txtLogin.Text + ";Password=" + txtPassword.Text;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            lblInfo.Text = Reader.TestConnection(memConnString.Text);
            lblInfo.Visible = true;

            ComboBoxItemCollection itemsCollection = cmbServer.Properties.Items;
            itemsCollection.BeginUpdate();

            lblInfo.Text = "Konekcija uspješna!";
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionHelper.SetSourceConnString(memConnString.Text);
                lblInfo.Text = "ConnString za izvor je pohranjen.";
                lblInfo.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            //if (!Basic.CheckOpened("ScriptsUpdate"))
            //{
            //    ScriptsUpdate main = new ScriptsUpdate(serverSource);
            //    main.Show();
            //    this.Visible = false;
            //}
        
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {

            if (!Basic.CheckOpened("ScriptsUpdate"))
            {
                ScriptsUpdate main = new ScriptsUpdate(serverSource);
                main.Show();
                this.Visible = false;
            }
            else
            {
                this.Close();
            }
        }
        #endregion


        private bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnOdustani_MouseHover(object sender, EventArgs e)
        {
            if (btnOdustani.Appearance.BackColor == Color.CadetBlue)
            {
                btnOdustani.Appearance.ForeColor = Color.CadetBlue;
            }
            
        }

        private void btnOdustani_MouseLeave(object sender, EventArgs e)
        {
            if (btnOdustani.Appearance.BackColor == Color.CadetBlue)
            {
                btnOdustani.Appearance.ForeColor = Color.LightBlue;
            }
        }
    }
}