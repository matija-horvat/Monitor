using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Monitor.Classes
{
    public class Destination
    {
        #region Fields
        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _ip;
        public string IP
        {
            get { return _ip; }
            set { _ip = value; }
        }

        private string _userId;
        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        #endregion

        public Destination()
        { 
        
        }


        public void Save(Destination dest)
        {
            int action = 6;

            Helpers.Writer.InsertUpdateDelete((Destination)dest, "spMPMonitor", action, null); 
        
        }

       
    }
}
