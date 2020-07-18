using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace magaza1.domain_layer
{
    public class Sehir
    {
        private int sehir_id;

        public int Sehir_id
        {
            get { return sehir_id; }
            set { sehir_id = value; }
        }
        private int sehir_plaka;

        public int Sehir_plaka
        {
            get { return sehir_plaka; }
            set { sehir_plaka = value; }
        }
        
        private string sehir_adi;
        
        public string Sehir_adi
        {
            get { return sehir_adi; }
            set { sehir_adi = value; }
        }
        public Sehir()
        { 
        }
        public Sehir(int sehirid, string sehirad)
        {
            this.Sehir_id = sehirid;
            this.Sehir_adi = sehirad;
        }
        public override string ToString()
        {
            return this.Sehir_adi;
        }
    }
}
