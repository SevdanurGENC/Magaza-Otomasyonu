using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace magaza1.domain_layer
{
   public class Urun
    {
        private int kate_id;

        public int Kate_id
        {
            get { return kate_id; }
            set { kate_id = value; }
        }
        private string urun_adi;

        public string Urun_adi
        {
            get { return urun_adi; }
            set { urun_adi = value; }
        }
        private int urun_id;

        public int Urun_id
        {
            get { return urun_id; }
            set { urun_id = value; }
        }
        private string resim_yol;

        public string Resim_yol
        {
            get { return resim_yol; }
            set { resim_yol = value; }
        }
        
        private int renk_id;

        public int Renk_id
        {
            get { return renk_id; }
            set { renk_id = value; }
        }
        private int beden_id;

        public int Beden_id
        {
            get { return beden_id; }
            set { beden_id = value; }
        }
        private int cins_id;

        public int Cins_id
        {
            get { return cins_id; }
            set { cins_id = value; }
        }
        private int numara;

        public int Numara
        {
            get { return numara; }
            set { numara = value; }
        }
        private float alisfiyati;

        public float Alisfiyati
        {
            get { return alisfiyati; }
            set { alisfiyati = value; }
        }
        private float satisfiyati;

        public float Satisfiyati
        {
            get { return satisfiyati; }
            set { satisfiyati = value; }
        }
       //private Kategori ktgr;

       // public Kategori Ktgr
       // {
       //   get { return ktgr; }
       //   set { ktgr = value; }
       // }
        //public Urun(string katad)
        //{ 
        //    Kategori asd=new Kategori();
        //    asd.Kategori_adi=katad;
        //    this.Ktgr=asd;            
        //}


        public Urun()
        { }
       
        public Urun(int urunid, string urunad)
        {
            this.Urun_id = urunid;
            this.Urun_adi = urunad;
        }
        public Urun(string urunad)//silncek
        {
            this.Urun_adi = urunad;
        }
        public Urun(int urunid, string ad, int katid, int renkid,int bedenid/*,int num,int cins,long alis, long satis*/)
        {
            this.Urun_id = urunid;
            this.Urun_adi = ad;
            this.Renk_id = renkid;
            this.Kate_id = katid;
            this.Beden_id = bedenid;
            //this.Numara = num;
            //this.Cins_id = cins;
            //this.Alisfiyati = alis;
            //this.Satisfiyati = satis;
        }
        public override string ToString()
        {
            return this.Urun_adi;
        }
    }
}
