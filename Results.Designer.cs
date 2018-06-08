namespace Monitor
{
    partial class Results
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Results));
            this.gridResults = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnOdustani = new DevExpress.XtraEditors.SimpleButton();
            this.richSql = new DevExpress.XtraRichEdit.RichEditControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridResults
            // 
            this.gridResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridResults.Location = new System.Drawing.Point(12, 12);
            this.gridResults.MainView = this.gridView1;
            this.gridResults.Name = "gridResults";
            this.gridResults.Size = new System.Drawing.Size(860, 681);
            this.gridResults.TabIndex = 12;
            this.gridResults.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridResults;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdustani.Appearance.BackColor = System.Drawing.Color.RosyBrown;
            this.btnOdustani.Appearance.BackColor2 = System.Drawing.Color.LightCoral;
            this.btnOdustani.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnOdustani.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnOdustani.Appearance.Options.UseBackColor = true;
            this.btnOdustani.Appearance.Options.UseFont = true;
            this.btnOdustani.Appearance.Options.UseForeColor = true;
            this.btnOdustani.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdustani.Location = new System.Drawing.Point(12, 699);
            this.btnOdustani.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnOdustani.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(860, 30);
            this.btnOdustani.TabIndex = 13;
            this.btnOdustani.Text = "Zatvori";
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // richSql
            // 
            this.richSql.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richSql.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richSql.Location = new System.Drawing.Point(76, 528);
            this.richSql.Name = "richSql";
            this.richSql.Options.Fields.UseCurrentCultureDateTimeFormat = false;
            this.richSql.Options.HorizontalRuler.ShowLeftIndent = false;
            this.richSql.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.richSql.Options.MailMerge.KeepLastParagraph = false;
            this.richSql.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.richSql.Size = new System.Drawing.Size(241, 152);
            this.richSql.TabIndex = 14;
            this.richSql.Views.DraftView.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.richSql.Views.SimpleView.Padding = new System.Windows.Forms.Padding(0, 4, 4, 0);
            this.richSql.Visible = false;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOdustani;
            this.ClientSize = new System.Drawing.Size(884, 734);
            this.Controls.Add(this.richSql);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.gridResults);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Results";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridResults;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnOdustani;
        private DevExpress.XtraRichEdit.RichEditControl richSql;
    }
}