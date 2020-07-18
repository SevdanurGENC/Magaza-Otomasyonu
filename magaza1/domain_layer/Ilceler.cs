using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace magaza1.domain_layer
{
   public class Ilceler
    {
        private int ilce_id;

        public int Ilce_id
        {
            get { return ilce_id; }
            set { ilce_id = value; }
        }
        private string ilce_adi;

        public string Ilce_adi
        {
            get { return ilce_adi; }
            set { ilce_adi = value; }
        }
       
        private int il_id;

        public int Il_id
        {
            get { return il_id; }
            set { il_id = value; }
        }
        public Ilceler(int ilceid,string ilcead)
        {
            this.Ilce_id = ilceid;
            this.Ilce_adi = ilcead;        
        }
     
        public override string ToString()
        {
            return this.Ilce_adi;
        }
    }
}
