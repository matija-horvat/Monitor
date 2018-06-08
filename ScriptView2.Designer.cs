namespace Monitor
{
    partial class ScriptView2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptView2));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.barBtnExport = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnIzlaz = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.richSql = new DevExpress.XtraRichEdit.RichEditControl();
            this.gridSkripte = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSkripte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Images = this.imageCollection1;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barBtnExport,
            this.barBtnIzlaz});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(893, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(64, 64);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "FAQ.png");
            this.imageCollection1.Images.SetKeyName(1, "Help.png");
            this.imageCollection1.Images.SetKeyName(2, "Shutdown.png");
            this.imageCollection1.Images.SetKeyName(3, "Server.png");
            this.imageCollection1.Images.SetKeyName(4, "Edit.png");
            this.imageCollection1.Images.SetKeyName(5, "find.png");
            this.imageCollection1.Images.SetKeyName(6, "Delete2.png");
            this.imageCollection1.Images.SetKeyName(7, "New.png");
            this.imageCollection1.Images.SetKeyName(8, "Edit3.png");
            this.imageCollection1.Images.SetKeyName(9, "Run.png");
            this.imageCollection1.Images.SetKeyName(10, "Edit4.png");
            this.imageCollection1.Images.SetKeyName(11, "Earth.png");
            this.imageCollection1.Images.SetKeyName(12, "Home2.png");
            this.imageCollection1.Images.SetKeyName(13, "Export.png");
            // 
            // barBtnExport
            // 
            this.barBtnExport.Caption = "Export";
            this.barBtnExport.Id = 1;
            this.barBtnExport.ImageIndex = 13;
            this.barBtnExport.Name = "barBtnExport";
            this.barBtnExport.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnExport_ItemClick);
            // 
            // barBtnIzlaz
            // 
            this.barBtnIzlaz.Caption = "Izlaz";
            this.barBtnIzlaz.Id = 2;
            this.barBtnIzlaz.ImageIndex = 2;
            this.barBtnIzlaz.Name = "barBtnIzlaz";
            this.barBtnIzlaz.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnIzlaz.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnIzlaz_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Menu";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnExport);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Izvezi skriptu";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnIzlaz);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 774);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(893, 31);
            // 
            // richSql
            // 
            this.richSql.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richSql.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richSql.Location = new System.Drawing.Point(12, 150);
            this.richSql.MenuManager = this.ribbon;
            this.richSql.Name = "richSql";
            this.richSql.Options.Fields.UseCurrentCultureDateTimeFormat = false;
            this.richSql.Options.HorizontalRuler.ShowLeftIndent = false;
            this.richSql.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.richSql.Options.MailMerge.KeepLastParagraph = false;
            this.richSql.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.richSql.Size = new System.Drawing.Size(871, 617);
            this.richSql.TabIndex = 15;
            this.richSql.Views.DraftView.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.richSql.Views.SimpleView.Padding = new System.Windows.Forms.Padding(0, 4, 4, 0);
            // 
            // gridSkripte
            // 
            this.gridSkripte.Location = new System.Drawing.Point(853, 150);
            this.gridSkripte.MainView = this.gridView1;
            this.gridSkripte.Name = "gridSkripte";
            this.gridSkripte.Size = new System.Drawing.Size(30, 617);
            this.gridSkripte.TabIndex = 16;
            this.gridSkripte.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridSkripte.Visible = false;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridSkripte;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ScriptView2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 805);
            this.Controls.Add(this.gridSkripte);
            this.Controls.Add(this.richSql);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScriptView2";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Pregled store";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ScriptView2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSkripte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraRichEdit.RichEditControl richSql;
        private DevExpress.XtraGrid.GridControl gridSkripte;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem barBtnExport;
        private DevExpress.XtraBars.BarButtonItem barBtnIzlaz;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}