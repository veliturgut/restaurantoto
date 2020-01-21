using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantoto
{
    class cRezervasyon
    {


        #region Fields

        private int _ID;
        private int _TableId;
        private int _ClientId;
        private DateTime _Date;
        private int _ClientCount;
        private string _Description;
        private int _AdditionId;
        #endregion

        #region Properties
        public int TableId
        {
            get { return _TableId; }
            set { _TableId = value; }
        }

        public int ClientId
        {
            get { return _ClientId; }
            set { _ClientId = value; }
        }

        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        public int AdditionId
        {
            get { return _AdditionId; }
            set { _AdditionId = value; }
        }

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public int ClientCount
        {
            get { return _ClientCount; }
            set { _ClientCount = value; }
        }
        #endregion

    }
}
