using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Monitor.Classes
{
    public class Script
    {
        #region Fields
        private int _mpskriptaId;
        public int MPSkriptaId
        {
            get { return _mpskriptaId; }
            set { _mpskriptaId = value; }
        }

        private string _oznaka;
        public string Oznaka
        {
            get { return _oznaka; }
            set { _oznaka = value; }
        }

        private string _naziv;
        public string Naziv
        {
            get { return _naziv; }
            set { _naziv = value; }
        }

        private string _sql;
        public string SQL
        {
            get { return _sql; }
            set { _sql = value; }
        }

        private string _info;
        public string Info
        {
            get { return _info; }
            set { _info = value; }
        }

        private string _tip;
        public string Tip
        {
            get { return _tip; }
            set { _tip = value; }
        }

        private string _statement;
        public string Statement
        {
            get { return _statement; }
            set { _statement = value; }
        }
        #endregion

        public Script()
        { 
        
        }


        public void Save(Script script)
        {
            int action = 0;

            switch (script.Statement.ToUpper())
            {
                case "INSERT": action = 2;
                    break;
                case "UPDATE": action = 3;
                    break;
                case "DELETE": action = 4;
                    break;
            }

            Helpers.Writer.InsertUpdateDelete((Script)script, "spMPMonitor", action, script.Statement); 
        
        }

       
    }
}
