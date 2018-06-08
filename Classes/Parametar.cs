using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monitor.Classes
{
    class Parametar
    {

        


        #region Fields
        private int _mpSkriptaId;
        public int MPSkriptaId
        {
            get { return _mpSkriptaId; }
            set { _mpSkriptaId = value; }
        }

        private DateTime _startDate;
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        private DateTime _endDate;
        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }
        
        private string _database;
        public string Database
        {
            get { return _database; }
            set { _database = value; }
        }

        private string _database2;
        public string Database2
        {
            get { return _database2; }
            set { _database2 = value; }
        }

        private string _table;
        public string Table
        {
            get { return _table; }
            set { _table = value; }
        }

        private string _table2;
        public string Table2
        {
            get { return _table2; }
            set { _table2 = value; }
        }

        private string _text;
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        private string _text2;
        public string Text2
        {
            get { return _text2; }
            set { _text2 = value; }
        }
        #endregion





    }
}
