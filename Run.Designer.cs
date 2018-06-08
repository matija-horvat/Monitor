namespace Monitor
{
    partial class Run
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Run));
            this.btnOdustani = new DevExpress.XtraEditors.SimpleButton();
            this.btnRun = new DevExpress.XtraEditors.SimpleButton();
            this.cmbBase1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbBase2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbTable2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbTable1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtString1 = new DevExpress.XtraEditors.TextEdit();
            this.richString2 = new DevExpress.XtraRichEdit.RichEditControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dateStart = new DevExpress.XtraEditors.DateEdit();
            this.dateEnd = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtScript = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.richInfo = new DevExpress.XtraRichEdit.RichEditControl();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBase1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBase2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTable2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTable1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtString1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScript.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.btnOdustani.Location = new System.Drawing.Point(335, 490);
            this.btnOdustani.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnOdustani.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(134, 31);
            this.btnOdustani.TabIndex = 12;
            this.btnOdustani.Text = "Zatvori";
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnRun
            // 
            this.btnRun.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.btnRun.Appearance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRun.Appearance.BackColor2 = System.Drawing.Color.DarkOliveGreen;
            this.btnRun.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRun.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnRun.Appearance.Options.UseBackColor = true;
            this.btnRun.Appearance.Options.UseFont = true;
            this.btnRun.Appearance.Options.UseForeColor = true;
            this.btnRun.Location = new System.Drawing.Point(3, 490);
            this.btnRun.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnRun.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(328, 31);
            this.btnRun.TabIndex = 11;
            this.btnRun.Text = "Run";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // cmbBase1
            // 
            this.cmbBase1.Location = new System.Drawing.Point(79, 187);
            this.cmbBase1.Name = "cmbBase1";
            this.cmbBase1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBase1.Size = new System.Drawing.Size(390, 20);
            this.cmbBase1.TabIndex = 14;
            this.cmbBase1.SelectedIndexChanged += new System.EventHandler(this.cmbBase1_SelectedIndexChanged);
            // 
            // cmbBase2
            // 
            this.cmbBase2.Location = new System.Drawing.Point(79, 213);
            this.cmbBase2.Name = "cmbBase2";
            this.cmbBase2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBase2.Size = new System.Drawing.Size(390, 20);
            this.cmbBase2.TabIndex = 15;
            this.cmbBase2.SelectedIndexChanged += new System.EventHandler(this.cmbBase2_SelectedIndexChanged);
            // 
            // cmbTable2
            // 
            this.cmbTable2.Location = new System.Drawing.Point(79, 265);
            this.cmbTable2.Name = "cmbTable2";
            this.cmbTable2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTable2.Size = new System.Drawing.Size(390, 20);
            this.cmbTable2.TabIndex = 17;
            // 
            // cmbTable1
            // 
            this.cmbTable1.Location = new System.Drawing.Point(79, 239);
            this.cmbTable1.Name = "cmbTable1";
            this.cmbTable1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTable1.Size = new System.Drawing.Size(390, 20);
            this.cmbTable1.TabIndex = 16;
            // 
            // txtString1
            // 
            this.txtString1.Location = new System.Drawing.Point(79, 291);
            this.txtString1.Name = "txtString1";
            this.txtString1.Size = new System.Drawing.Size(390, 20);
            this.txtString1.TabIndex = 18;
            // 
            // richString2
            // 
            this.richString2.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richString2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richString2.Location = new System.Drawing.Point(79, 317);
            this.richString2.Name = "richString2";
            this.richString2.Options.Fields.UseCurrentCultureDateTimeFormat = false;
            this.richString2.Options.HorizontalRuler.ShowLeftIndent = false;
            this.richString2.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.richString2.Options.MailMerge.KeepLastParagraph = false;
            this.richString2.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.richString2.Size = new System.Drawing.Size(390, 167);
            this.richString2.TabIndex = 19;
            this.richString2.Views.DraftView.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.richString2.Views.SimpleView.Padding = new System.Windows.Forms.Padding(0, 4, 4, 0);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 190);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Baza 1:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 216);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Baza 2:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 268);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Tablica 2:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 242);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 22;
            this.labelControl4.Text = "Tablica 1:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 317);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 13);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "String 2:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 294);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(41, 13);
            this.labelControl6.TabIndex = 24;
            this.labelControl6.Text = "String 1:";
            // 
            // dateStart
            // 
            this.dateStart.EditValue = null;
            this.dateStart.Location = new System.Drawing.Point(79, 135);
            this.dateStart.Name = "dateStart";
            this.dateStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStart.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dateStart.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dateStart.Size = new System.Drawing.Size(153, 20);
            this.dateStart.TabIndex = 26;
            // 
            // dateEnd
            // 
            this.dateEnd.EditValue = null;
            this.dateEnd.Location = new System.Drawing.Point(79, 161);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnd.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dateEnd.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dateEnd.Size = new System.Drawing.Size(153, 20);
            this.dateEnd.TabIndex = 27;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 138);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 13);
            this.labelControl7.TabIndex = 28;
            this.labelControl7.Text = "Datum od:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 164);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(50, 13);
            this.labelControl8.TabIndex = 29;
            this.labelControl8.Text = "Datum do:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 15);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(37, 13);
            this.labelControl9.TabIndex = 30;
            this.labelControl9.Text = "Skripta:";
            // 
            // txtScript
            // 
            this.txtScript.Enabled = false;
            this.txtScript.Location = new System.Drawing.Point(3, 34);
            this.txtScript.Name = "txtScript";
            this.txtScript.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtScript.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtScript.Properties.Appearance.Options.UseBackColor = true;
            this.txtScript.Properties.Appearance.Options.UseFont = true;
            this.txtScript.Size = new System.Drawing.Size(465, 20);
            this.txtScript.TabIndex = 31;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(12, 57);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(24, 13);
            this.labelControl10.TabIndex = 32;
            this.labelControl10.Text = "Info:";
            // 
            // richInfo
            // 
            this.richInfo.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richInfo.Appearance.Text.Font = new System.Drawing.Font("Arial", 5F);
            this.richInfo.Appearance.Text.ForeColor = System.Drawing.Color.Gray;
            this.richInfo.Appearance.Text.Options.UseFont = true;
            this.richInfo.Appearance.Text.Options.UseForeColor = true;
            this.richInfo.Enabled = false;
            this.richInfo.Location = new System.Drawing.Point(3, 72);
            this.richInfo.Name = "richInfo";
            this.richInfo.Options.Behavior.FontSource = DevExpress.XtraRichEdit.RichEditBaseValueSource.Control;
            this.richInfo.Options.Fields.UseCurrentCultureDateTimeFormat = false;
            this.richInfo.Options.HorizontalRuler.ShowLeftIndent = false;
            this.richInfo.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.richInfo.Options.MailMerge.KeepLastParagraph = false;
            this.richInfo.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.richInfo.Size = new System.Drawing.Size(465, 48);
            this.richInfo.TabIndex = 33;
            this.richInfo.Views.DraftView.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.richInfo.Views.SimpleView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richInfo.Views.SimpleView.Padding = new System.Windows.Forms.Padding(0, 4, 4, 0);
            // 
            // Run
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 523);
            this.Controls.Add(this.richInfo);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.txtScript);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.richString2);
            this.Controls.Add(this.txtString1);
            this.Controls.Add(this.cmbTable2);
            this.Controls.Add(this.cmbTable1);
            this.Controls.Add(this.cmbBase2);
            this.Controls.Add(this.cmbBase1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnRun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Run";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Run";
            this.Load += new System.EventHandler(this.Run_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbBase1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBase2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTable2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTable1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtString1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScript.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOdustani;
        private DevExpress.XtraEditors.SimpleButton btnRun;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBase1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBase2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTable2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTable1;
        private DevExpress.XtraEditors.TextEdit txtString1;
        private DevExpress.XtraRichEdit.RichEditControl richString2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dateStart;
        private DevExpress.XtraEditors.DateEdit dateEnd;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtScript;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraRichEdit.RichEditControl richInfo;
    }
}