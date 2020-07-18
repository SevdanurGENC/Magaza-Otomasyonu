using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace magaza1.domain_layer
{
    public class Siparis
    {
        private int kat_id;

        public int Kat_id
        {
            get { return kat_id; }
            set { kat_id = value; }
        }
        private int urun_id;

        public int Urun_id
        {
            get { return urun_id; }
            set { urun_id = value; }
        }
        private int mag_id;

        public int Mag_id
        {
            get { return mag_id; }
            set { mag_id = value; }
        }

        private int sip_id;

        public int Sip_id
        {
            get { return sip_id; }
            set { sip_id = value; }
        }

        //private Kategori ktgr;

        //public Kategori Ktgr
        //{
        //    get { return ktgr; }
        //    set { ktgr = value; }
        //}
        //private Magaza mgz;

        //public Magaza Mgz
        //{
        //    get { return mgz; }
        //    set { mgz = value; }
        //}
        //private Urun urn;

        //public Urun Urn
        //{
        //    get { return urn; }
        //    set { urn = value; }
        //}
        private DateTime tarih;

        public DateTime Tarih
        {
            get { return tarih; }
            set { tarih = value; }
        }
        private int adet;

        public int Adet
        {
            get { return adet; }
            set { adet = value; }
        }
        public Siparis()
        { }

        //public Siparis(int sip_id, DateTime tarih, int mag_id, int kat_id, int urun_id, int adet)
        //{
        //    this.Sip_id = sip_id;
        //    this.Tarih = tarih;

        //    Magaza mg = new Magaza();
        //    mg.Magaza_id = mag_id;
        //    this.Mgz = mg;
            
        //    Kategori kt = new Kategori();
        //    kt.Kategori_id = kat_id;
        //    this.Ktgr = kt;
            
        //    Urun ur = new Urun();
        //    ur.Urun_id = urun_id;
        //    this.Urn = ur;

        //    this.Adet = adet;
        //}

    }
}
