namespace Monitor
{
    partial class MessageErrorDialog
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
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.lblFriendlyMessage = new DevExpress.XtraEditors.LabelControl();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnDetails = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(210, 96);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(97, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblFriendlyMessage
            // 
            this.lblFriendlyMessage.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblFriendlyMessage.Location = new System.Drawing.Point(77, 27);
            this.lblFriendlyMessage.Name = "lblFriendlyMessage";
            this.lblFriendlyMessage.Size = new System.Drawing.Size(228, 50);
            this.lblFriendlyMessage.TabIndex = 2;
            this.lblFriendlyMessage.Text = "lblFriendlyMessage";
            // 
            // pic
            // 
            this.pic.Image = global::Monitor.Properties.Resources.danger;
            this.pic.Location = new System.Drawing.Point(12, 27);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(51, 50);
            this.pic.TabIndex = 3;
            this.pic.TabStop = false;
            // 
            // btnDetails
            // 
            this.btnDetails.Image = global::Monitor.Properties.Resources.ArrowDown;
            this.btnDetails.Location = new System.Drawing.Point(12, 96);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(97, 23);
            this.btnDetails.TabIndex = 1;
            this.btnDetails.Text = "&Detalji";
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // MessageErrorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 132);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.lblFriendlyMessage);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageErrorDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageErrorDialog";
            this.Load += new System.EventHandler(this.MessageErrorDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnDetails;
        private DevExpress.XtraEditors.LabelControl lblFriendlyMessage;
        private System.Windows.Forms.PictureBox pic;

    }
}