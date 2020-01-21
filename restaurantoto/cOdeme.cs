using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantoto
{
    class cOdeme
    {

        #region Fields
        private int _OdemeID;
        private int _AdisyonID;
        private int _OdemeTurID;
        private decimal _AraToplam;
        private decimal _Indirim;
        private decimal _KdvTutari;
        private decimal _GenelToplam;
        private DateTime _Tarih;
        private int _MusteriId;

        #endregion

        #region Properties
        public int OdemeID
        {
            get { return _OdemeID; }
            set { _OdemeID = value; }
        }

        public int AdisyonID
        {
            get { return _AdisyonID; }
            set { _AdisyonID = value; }
        }

        public int OdemeTurId
        {
            get { return _OdemeTurID; }
            set { _OdemeTurID = value; }
        }

        public decimal AraToplam
        {
            get { return _AraToplam; }
            set { _AraToplam = value; }
        }

        public decimal Indirim
        {
            get { return _Indirim; }
            set { _Indirim = value; }
        }

        public decimal KdvTutari
        {
            get { return _KdvTutari; }
            set { _KdvTutari = value; }
        }

        public decimal GenelToplam
        {
            get { return _GenelToplam; }
            set { _GenelToplam = value; }
        }


        public DateTime Tarih
        {
            get { return _Tarih; }
            set { _Tarih = value; }
        }


        public int MusteriId
        {
            get { return _MusteriId; }
            set { _MusteriId = value; }
        }
        #endregion
    }
}
