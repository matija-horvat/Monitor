namespace Monitor
{
    partial class DestinationConn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DestinationConn));
            this.lblInfo = new DevExpress.XtraEditors.LabelControl();
            this.btnTest = new DevExpress.XtraEditors.SimpleButton();
            this.btnBuildConnString = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnOdustani = new DevExpress.XtraEditors.SimpleButton();
            this.btnSpremi = new DevExpress.XtraEditors.SimpleButton();
            this.memConnString = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.cmbDatabase = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtServer = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnServer = new DevExpress.XtraEditors.SimpleButton();
            this.gridDestination = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbServer = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.memConnString.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbServer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.lblInfo.Location = new System.Drawing.Point(7, 291);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(54, 11);
            this.lblInfo.TabIndex = 30;
            this.lblInfo.Text = "labelControl6";
            this.lblInfo.Visible = false;
            // 
            // btnTest
            // 
            this.btnTest.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.btnTest.Appearance.BackColor2 = System.Drawing.Color.LightCoral;
            this.btnTest.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.btnTest.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnTest.Appearance.Options.UseBackColor = true;
            this.btnTest.Appearance.Options.UseFont = true;
            this.btnTest.Appearance.Options.UseForeColor = true;
            this.btnTest.Location = new System.Drawing.Point(6, 308);
            this.btnTest.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnTest.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(393, 19);
            this.btnTest.TabIndex = 26;
            this.btnTest.Text = "Testiraj vezu";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnBuildConnString
            // 
            this.btnBuildConnString.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBuildConnString.Appearance.BackColor2 = System.Drawing.Color.DarkOrange;
            this.btnBuildConnString.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildConnString.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.btnBuildConnString.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnBuildConnString.Appearance.Options.UseBackColor = true;
            this.btnBuildConnString.Appearance.Options.UseFont = true;
            this.btnBuildConnString.Appearance.Options.UseForeColor = true;
            this.btnBuildConnString.Location = new System.Drawing.Point(131, 155);
            this.btnBuildConnString.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnBuildConnString.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnBuildConnString.Name = "btnBuildConnString";
            this.btnBuildConnString.Size = new System.Drawing.Size(131, 21);
            this.btnBuildConnString.TabIndex = 22;
            this.btnBuildConnString.Text = "Build ConnString";
            this.btnBuildConnString.Click += new System.EventHandler(this.btnBuildConnString_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
            this.labelControl5.Location = new System.Drawing.Point(6, 162);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(90, 13);
            this.labelControl5.TabIndex = 29;
            this.labelControl5.Text = "Connection String:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Appearance.BackColor = System.Drawing.Color.RosyBrown;
            this.btnOdustani.Appearance.BackColor2 = System.Drawing.Color.LightCoral;
            this.btnOdustani.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnOdustani.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnOdustani.Appearance.Options.UseBackColor = true;
            this.btnOdustani.Appearance.Options.UseFont = true;
            this.btnOdustani.Appearance.Options.UseForeColor = true;
            this.btnOdustani.Location = new System.Drawing.Point(6, 331);
            this.btnOdustani.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnOdustani.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(393, 33);
            this.btnOdustani.TabIndex = 28;
            this.btnOdustani.Text = "Zatvori";
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.btnSpremi.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.btnSpremi.Appearance.BackColor2 = System.Drawing.Color.DarkOliveGreen;
            this.btnSpremi.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSpremi.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnSpremi.Appearance.Options.UseBackColor = true;
            this.btnSpremi.Appearance.Options.UseFont = true;
            this.btnSpremi.Appearance.Options.UseForeColor = true;
            this.btnSpremi.Location = new System.Drawing.Point(268, 155);
            this.btnSpremi.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnSpremi.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(131, 21);
            this.btnSpremi.TabIndex = 27;
            this.btnSpremi.Text = "Spremi ConnString";
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // memConnString
            // 
            this.memConnString.Location = new System.Drawing.Point(6, 182);
            this.memConnString.Name = "memConnString";
            this.memConnString.Size = new System.Drawing.Size(393, 103);
            this.memConnString.TabIndex = 24;
            this.memConnString.UseOptimizedRendering = true;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Location = new System.Drawing.Point(6, 122);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 16);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "Lozinka";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Location = new System.Drawing.Point(6, 95);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 16);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Korisničko ime";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(6, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 16);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Baza";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(113, 120);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Size = new System.Drawing.Size(286, 22);
            this.txtPassword.TabIndex = 18;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(113, 92);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtLogin.Properties.Appearance.Options.UseFont = true;
            this.txtLogin.Size = new System.Drawing.Size(286, 22);
            this.txtLogin.TabIndex = 20;
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.Location = new System.Drawing.Point(113, 64);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbDatabase.Properties.Appearance.Options.UseFont = true;
            this.cmbDatabase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDatabase.Size = new System.Drawing.Size(286, 22);
            this.cmbDatabase.TabIndex = 17;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(113, 38);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(164, 20);
            this.txtServer.TabIndex = 31;
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Location = new System.Drawing.Point(6, 39);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(104, 16);
            this.labelControl6.TabIndex = 32;
            this.labelControl6.Text = "IP ili naziv servera";
            // 
            // btnServer
            // 
            this.btnServer.Appearance.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnServer.Appearance.BackColor2 = System.Drawing.Color.DarkOrange;
            this.btnServer.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServer.Appearance.ForeColor = System.Drawing.Color.LightGray;
            this.btnServer.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnServer.Appearance.Options.UseBackColor = true;
            this.btnServer.Appearance.Options.UseFont = true;
            this.btnServer.Appearance.Options.UseForeColor = true;
            this.btnServer.Location = new System.Drawing.Point(268, 38);
            this.btnServer.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnServer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(131, 19);
            this.btnServer.TabIndex = 33;
            this.btnServer.Text = "Potvrdi server";
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // gridDestination
            // 
            this.gridDestination.Location = new System.Drawing.Point(296, 291);
            this.gridDestination.MainView = this.gridView2;
            this.gridDestination.Name = "gridDestination";
            this.gridDestination.Size = new System.Drawing.Size(103, 11);
            this.gridDestination.TabIndex = 34;
            this.gridDestination.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridDestination.Visible = false;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridDestination;
            this.gridView2.Name = "gridView2";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(6, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 16);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Otvoreni VPN";
            // 
            // cmbServer
            // 
            this.cmbServer.Location = new System.Drawing.Point(113, 12);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbServer.Properties.Appearance.Options.UseFont = true;
            this.cmbServer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbServer.Size = new System.Drawing.Size(286, 22);
            this.cmbServer.TabIndex = 35;
            // 
            // DestinationConn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 368);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmbServer);
            this.Controls.Add(this.gridDestination);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnBuildConnString);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.memConnString);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.cmbDatabase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DestinationConn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Destinacija - Connection String";
            this.Load += new System.EventHandler(this.DestinationConn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memConnString.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbServer.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblInfo;
        private DevExpress.XtraEditors.SimpleButton btnTest;
        private DevExpress.XtraEditors.SimpleButton btnBuildConnString;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnOdustani;
        private DevExpress.XtraEditors.SimpleButton btnSpremi;
        private DevExpress.XtraEditors.MemoEdit memConnString;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtLogin;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDatabase;
        private DevExpress.XtraEditors.TextEdit txtServer;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnServer;
        private DevExpress.XtraGrid.GridControl gridDestination;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbServer;

    }
}