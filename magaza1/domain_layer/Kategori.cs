using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace magaza1.domain_layer
{
   public class Kategori
    {
        private int kategori_id;

        public int Kategori_id
        {
            get { return kategori_id; }
            set { kategori_id = value; }
        }
        private string kategori_adi;

        public string Kategori_adi
        {
            get { return kategori_adi; }
            set { kategori_adi = value; }
        }
        public Kategori()
        { 
        
        }
        public Kategori(int kat_id,string kat_adi)
        {
            this.Kategori_id = kat_id;
            this.Kategori_adi = kat_adi;        
        }
        public override string ToString()
        {
            return Kategori_adi;
        }

    }
}
