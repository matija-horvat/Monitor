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
using Monitor.Helpers;
using Monitor.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace Monitor
{
    public partial class DestinationConn : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private DataTable tblServer = null;
        ServerSource serverSource = null;
        Destination dest = null;
        #endregion

        #region Ctor
        public DestinationConn()
        {
            InitializeComponent();
        }

        public DestinationConn(ref ServerSource serverSource)
        {
            InitializeComponent();
            this.serverSource = serverSource;
        }
        #endregion

        #region Form Events
        private void DestinationConn_Load(object sender, EventArgs e)
        {
            memConnString.Text = ConnectionHelper.GetDestConnString();
            txtLogin.Text = "sa";

            if (cmbServer.Properties.Items.Count == 0)
            {
                if (serverSource == null)
                {
                    //tblServer = new DataTable();
                    //tblServer = SqlDataSourceEnumerator.Instance.GetDataSources();
                    //serverSource = new ServerSource();
                    //serverSource.List = new string[tblServer.Rows.Count];

                    string host = System.Net.Dns.GetHostName();
                    System.Net.IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(host);
                    System.Net.IPAddress[] ipAddr = ipEntry.AddressList;

                    for (int i = 0; i < ipAddr.Length; i++)
                    {
                        if (ipAddr[i].AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            cmbServer.Properties.Items.Add(ipAddr[i].ToString());

                        //serverSource.List[i] = tblServer.Rows[i].ItemArray.First().ToString();
                    }

                    //for (int i = 0; i < tblServer.Rows.Count; i++)
                    //{
                    //    cmbServer.Properties.Items.Add(tblServer.Rows[i].ItemArray.First().ToString());
                    //    serverSource.List[i] = tblServer.Rows[i].ItemArray.First().ToString();
                    //}
                }
                else
                {
                    for (int i = 0; i < serverSource.List.Count(); i++)
                    {
                        cmbServer.Properties.Items.Add(serverSource.List[i].ToString());
                    }
                }

            }

            Helpers.Reader.GridDataSet(ref gridDestination, "select * from MonitorDest", CommandType.Text, true);
        }
        #endregion

        #region UI Events
       

        private void txtServer_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ((GridView)gridDestination.MainView).RowCount; i++)
            {
                DataRowView selRow = (DataRowView)(((GridView)gridDestination.MainView).GetRow(i));

                if (selRow["ip_name"].ToString() == txtServer.Text)
                {
                    txtLogin.Text = selRow["userid"].ToString();
                    txtPassword.Text = selRow["password"].ToString();
                    return;
                }
            }
        }
        #endregion

        #region Button Events
        private void btnBuildConnString_Click(object sender, EventArgs e)
        {
            if (txtServer.Text == String.Empty || cmbDatabase.SelectedItem == null)
            {
                MessageErrorDialog error = new MessageErrorDialog("Nedostaju podaci", "Server i baza nisu odabrani.", null);
                error.ShowDialog();
                return;
            }

            memConnString.Text = "Data source=" + txtServer.Text + ";Initial Catalog=" + cmbDatabase.SelectedItem.ToString() + ";User ID=" + txtLogin.Text + ";Password=" + txtPassword.Text;


        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            lblInfo.Text = Reader.TestConnection(memConnString.Text);
            lblInfo.Visible = true;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionHelper.SetDestConnString(memConnString.Text);
                lblInfo.Text = "ConnString za destinaciju je pohranjen.";
                lblInfo.Visible = true;

                dest = new Destination();
                dest.IP = txtServer.Text;
                dest.UserId = txtLogin.Text;
                dest.Password = txtPassword.Text;

                dest.Save(dest);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void btnServer_Click(object sender, EventArgs e)
        {
            cmbDatabase.Properties.Items.Clear();
            bool state = false;

            try
            {
                System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();

                if (ping.Send(txtServer.Text).Status == System.Net.NetworkInformation.IPStatus.Success)
                    state = true;
            }
            catch (Exception ex)
            {
                MessageErrorDialog error = new MessageErrorDialog("Destinacija!?", "Ping destinacije nije uspio! Provjerite IP.", ex.ToString());
                error.ShowDialog();
            }
            

            if (state)
            {
                //Helpers.Reader.GetDatabases(ref cmbDatabase, cmbServer, txtLogin.Text, txtPassword.Text);

                Helpers.Reader.GetDestDatabases(ref cmbDatabase, txtServer.Text, txtLogin.Text, txtPassword.Text);
                btnServer.Text = "VPN ok!";
                btnServer.Appearance.BackColor = Color.DarkSeaGreen;
            }
            else
            {
                btnServer.Text = "VPN??";
                btnServer.Appearance.BackColor = Color.IndianRed;
            }
            
        }

        
    
    }
}