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
using DevExpress.XtraGrid.Columns;
using Monitor.Classes;
using DevExpress.XtraRichEdit.Services;
using DevExpress.Office.Utils;
using Monitor.Helpers;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;


namespace Monitor
{
    public partial class ScriptsUpdate : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Fields
        Script skripta = null;
        ServerSource serverSource = null;
        string sql = String.Empty;

        
       
        #endregion

        #region Ctor
        public ScriptsUpdate()
        {
            InitializeComponent();
            //richSql.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft;
            richSql.ReplaceService<ISyntaxHighlightService>(new CustomSyntaxHighlightService(richSql.Document));
        }

        public ScriptsUpdate(ServerSource serverSource)
        {
            InitializeComponent();
            //richSql.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft;
            richSql.ReplaceService<ISyntaxHighlightService>(new CustomSyntaxHighlightService(richSql.Document));
            this.serverSource = serverSource;

        }
        #endregion

        #region Form Events
        private void RibbonForm1_Load(object sender, EventArgs e)
        {
            //string[] openVPNs = GetOpenConnections();
            //DisplayIPAddresses();

            //IEnumerable<IPAddress> list = GetIpAddress();
            //string host = System.Net.Dns.GetHostName();
            //System.Net.IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(host);
            //System.Net.IPAddress[] ipAddr = ipEntry.AddressList;
            //for (int i = 0; i < ipAddr.Length; i++)
            //{
            //    if (ipAddr[i].AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
            //        Console.WriteLine(ipAddr[i]);

            //}

            Helpers.Reader.GridDataSet(ref gridSkripte, "select * from mpskripta", CommandType.Text, true);
            Helpers.Basic.FitGridColumns(ref gridView1, true, "Naziv");

            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            gridView1.InvertRowSelection(0);
            //gridView1.OptionsView.ShowAutoFilterRow = true;
            skripta = new Script();
            richSql.Document.DefaultCharacterProperties.FontName = "Courier New";
            EnableFields(true, false, true);
            txtNaziv.Focus();
        }
        #endregion


        #region UI Events
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int[] selRows = ((GridView)gridSkripte.MainView).GetSelectedRows();
            DataRowView selRow = (DataRowView)(((GridView)gridSkripte.MainView).GetRow(selRows[0]));

            if (selRow == null)
            {
                return;
            }

            skripta.MPSkriptaId = (int)selRow["mpskriptaid"];
            txtOznaka.Text = skripta.Oznaka = selRow["oznaka"].ToString();
            txtNaziv.Text = skripta.Naziv = selRow["Naziv"].ToString();
            richSql.Text = (selRow["Sql"].ToString());
            memInfo.Text = skripta.Info = selRow["Info"].ToString();
        }

        private void txtOznaka_TextChanged(object sender, EventArgs e)
        {
            skripta.Oznaka = txtOznaka.Text;
        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {
            skripta.Naziv = txtNaziv.Text;
        }

        private void memInfo_TextChanged(object sender, EventArgs e)
        {
            skripta.Info = memInfo.Text;
        }

        private void richEditControl1_TextChanged(object sender, EventArgs e)
        {
            skripta.SQL = richSql.Text;
        }
        #endregion

        #region Menu Events
        private void barBtnDodaj_ItemClick(object sender, ItemClickEventArgs e)
        {
            EnableFields(false, true, true);

            txtOznaka.Focus();
            skripta = new Script();
            skripta.Statement = "Insert";

        }

        private void barBtnIzmjeni_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (skripta.MPSkriptaId == 0)
            {
                MessageBox.Show("Odaberite skriptu koju želite izmjeniti.");
                return;
            }

            skripta.Statement = "Update";
            EnableFields(false, true, false);
            txtOznaka.Focus();
        }

        private void barBtnObrisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            EnableFields(false, true, false);
           
            btnSpremi.Enabled = true;
            btnOdustani.Enabled = true;

            btnSpremi.Text = "Potvrdi";
            skripta.Statement = "Delete";
        }

        private void barBtnPregledStore_ItemClick(object sender, ItemClickEventArgs e)
        {
            ScriptView2 view = new ScriptView2("Pekarstvo", skripta.SQL);
            view.Show();
        }

        private void barBtnPokreni_ItemClick(object sender, ItemClickEventArgs e)
        {
            //If script is store call with default parameters Run script immediately.
            if (skripta.SQL.Substring(0, 4).ToLower() == "exec" && skripta.SQL.IndexOf("@") != -1)
            {
                sql = Helpers.Reader.GetSQL(skripta.SQL, Basic.ParseScriptForParameters(skripta.SQL), CommandType.StoredProcedure);
                Results result = new Results(sql);
                result.Show();
            }
            else
            {
                Run param = new Run(skripta);
                param.Show();
            }
            
        }

        private void barBtnAir_ItemClick(object sender, ItemClickEventArgs e)
        {
            RunLive air = new RunLive();
            air.Show();
        }

        private void barBtnIzvor_ItemClick(object sender, ItemClickEventArgs e)
        {
            SourceConn source = new SourceConn(ref serverSource);
            source.Show();
        }

        private void barBtnDestinacija_ItemClick(object sender, ItemClickEventArgs e)
        {
            DestinationConn destination = new DestinationConn(ref serverSource);
            destination.Show();
        }

        private void barBtnIzlaz_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Methods
        private void EnableFields(bool enableMenu, bool enableGroupDetalji, bool emptyFields)
        {
            barBtnIzmjeni.Enabled = enableMenu;
            barBtnPokreni.Enabled = enableMenu;
            barBtnObrisi.Enabled = enableMenu;
            barBtnDodaj.Enabled = enableMenu;
            barBtnPregledStore.Enabled = enableMenu;
            barBtnPokreni.Enabled = enableMenu;
            barBtnAir.Enabled = enableMenu;
            barBtnIzvor.Enabled = enableMenu;
            barBtnDestinacija.Enabled = enableMenu;


            btnSpremi.Visible = enableGroupDetalji;
            btnOdustani.Visible = enableGroupDetalji;

            if (emptyFields)
            {
                txtNaziv.Text = String.Empty;
                txtOznaka.Text = String.Empty;
                memInfo.Text = String.Empty;
                richSql.Text = String.Empty;
            }
            
            txtNaziv.Enabled = enableGroupDetalji;
            txtOznaka.Enabled = enableGroupDetalji;
            richSql.Enabled = enableGroupDetalji;
            memInfo.Enabled = enableGroupDetalji;

            if (enableGroupDetalji)
            {
                txtNaziv.BackColor = Color.White;
                txtOznaka.BackColor = Color.White;
                richSql.ActiveView.BackColor = Color.White;
                memInfo.BackColor = Color.White;
                
            }
            else
            {
                txtNaziv.BackColor = System.Drawing.SystemColors.ControlLight;
                txtOznaka.BackColor = System.Drawing.SystemColors.ControlLight;
                richSql.ActiveView.BackColor = System.Drawing.SystemColors.ControlLight;
                memInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            }

        }
        #endregion

        #region Button Events
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            skripta.Save(skripta);

            EnableFields(true, false, true);
            btnSpremi.Text = "Spremi";

            Helpers.Reader.GridDataSet(ref gridSkripte, "select * from mpskripta", CommandType.Text, true);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            EnableFields(true, false, false);
            btnSpremi.Text = "Spremi";
        }
        #endregion

        /// <summary> 
        /// This utility function displays all the IP (v4, not v6) addresses of the local computer. 
        /// </summary> 
        public static void DisplayIPAddresses()
        {
            StringBuilder sb = new StringBuilder();

            // Get a list of all network interfaces (usually one per network card, dialup, and VPN connection) 
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface network in networkInterfaces)
            {
                // Read the IP configuration for each network 
                IPInterfaceProperties properties = network.GetIPProperties();

                // Each network interface may have multiple IP addresses 
                foreach (IPAddressInformation address in properties.UnicastAddresses)
                {
                    // We're only interested in IPv4 addresses for now 
                    if (address.Address.AddressFamily != AddressFamily.InterNetwork)
                        continue;

                    // Ignore loopback addresses (e.g., 127.0.0.1) 
                    if (IPAddress.IsLoopback(address.Address))
                        continue;

                    sb.AppendLine(address.Address.ToString() + " (" + network.Name + ")");
                }
            }

            MessageBox.Show(sb.ToString());
        }

        public static IEnumerable<IPAddress> GetIpAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            return (from ip in host.AddressList where !IPAddress.IsLoopback(ip) select ip).ToList();
        }

        private void barBtnDeadlock_ItemClick(object sender, ItemClickEventArgs e)
        {
            Deadlocks deadlock = new Deadlocks();
            deadlock.Show();
        }

        
        
        //private string[] GetOpenConnections()
        //{
        //    List<String> results = new List<string>();
        //    foreach (RasConnection connection in RasConnection.GetActiveConnections())
        //    {
        //        RasConnectionStatus status = connection.GetConnectionStatus();
        //        //connection.GetConnectionStatus().ConnectionState 
        //        if (status != null)
        //        {
        //            Trace.WriteLine(String.Format("Name: {0} \r\n Status: {1}", connection.EntryName, status.ConnectionState.ToString()));
        //            results.Add(connection.EntryName);

        //            string path = connection.PhoneBookPath;
        //            RasPhoneBook pbk = new RasPhoneBook();
        //            pbk.Open(path);

        //            foreach (RasEntry entry in pbk.Entries)
        //            {
        //                if (entry.Name == connection.EntryName)
        //                {
        //                    MessageBox.Show(entry.Name);//82.193.219.42
        //                }
                        
        //            }
        //        }
        //    }
        //    return results.ToArray();
        //}


    }
}