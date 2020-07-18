using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using magaza1.domain_layer;

namespace magaza1
{
    public class Merkez
    {
        private int magaza_id;

        public int Magaza_id
        {
            get { return magaza_id; }
            set { magaza_id = value; }
        }
        private string magaza_ad;

        public string Magaza_ad
        {
            get { return magaza_ad; }
            set { magaza_ad = value; }
        }
        private int magaza_sifre;

        public int Magaza_sifre
        {
            get { return magaza_sifre; }
            set { magaza_sifre = value; }
        }
        private string magaza_iletisim;

        public string Magaza_iletisim
        {
            get { return magaza_iletisim; }
            set { magaza_iletisim = value; }
        }
        private int il_id;

        public int Il_id
        {
            get { return il_id; }
            set { il_id = value; }
        }
        private int ilce_id;

        public int Ilce_id
        {
            get { return ilce_id; }
            set { ilce_id = value; }
        }
        private int yetki_id;

        public int Yetki_id
        {
            get { return yetki_id; }
            set { yetki_id = value; }
        }
        public Merkez()
        {
            //Sehir shr = new Sehir();
            //shr.Sehir_adi = "";
            //shr.Sehir_id = 0;
            //shr.Sehir_plaka = 0;
            //this.Illerm = shr;
            //Ilceler ilcelr = new Ilceler();
            //ilcelr.Il_id = 0;
            //ilcelr.Ilce_adi = "";
            //ilcelr.Il_id = 0;
            //this.Ilcelerm = ilcelr;            
        }
        
       
    }
}
