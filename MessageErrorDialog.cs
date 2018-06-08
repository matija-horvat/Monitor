using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Monitor
{
    public partial class MessageErrorDialog : DevExpress.XtraEditors.XtraForm
    {

        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        
        private string _friendlyMessage;
        public string FriendlyMessage
        {
            get { return _friendlyMessage; }
            set { _friendlyMessage = value; }
        }
        
        private string _detailMessage;
        public string DetailMessage
        {
            get { return _detailMessage; }
            set { _detailMessage = value; }
        }
        private TextBox detail = null;

        
        public MessageErrorDialog()
        {
            InitializeComponent();
        }

        public MessageErrorDialog(string title, string friendlyMessage, string detailMessage)
        {
            InitializeComponent();
            this.Title = title;
            this.FriendlyMessage = friendlyMessage;
            this.DetailMessage = detailMessage;
            lblFriendlyMessage.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {

            if (this.Size.Height <= 170)
            {
                detail = new TextBox();
                detail.Location = new Point(12, 126);
                detail.Multiline = true;
                detail.Size = new Size(495, 150);
                detail.Text = DetailMessage;
                detail.ScrollBars = ScrollBars.Vertical;
                detail.Font = new Font(new FontFamily("Arial"), 7);
                this.Size = new Size(this.Size.Width + 200, this.Size.Height + 150);
                this.Controls.Add(detail);
                btnDetails.Image = Properties.Resources.ArrowUp;
                
            }
            else
            {
                this.Size = new Size(this.Size.Width - 200, this.Size.Height - 150);
                btnDetails.Image = Properties.Resources.ArrowDown;
                this.Controls.Remove(detail);
            }
            
        }

        private void MessageErrorDialog_Load(object sender, EventArgs e)
        {
            this.Text = Title;
            lblFriendlyMessage.Text = FriendlyMessage;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}