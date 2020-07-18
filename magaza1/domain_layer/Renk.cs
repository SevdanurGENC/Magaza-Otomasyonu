using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace magaza1.domain_layer
{
    public class Renk
    {
        private int renk_id;

        public int Renk_id
        {
            get { return renk_id; }
            set { renk_id = value; }
        }
        private string renk_adi;

        public string Renk_adi
        {
            get { return renk_adi; }
            set { renk_adi = value; }
        }
        private int urun_id;

        public int Urun_id
        {
            get { return urun_id; }
            set { urun_id = value; }
        }
        
        public Renk()
        { 
        
        }

        public Renk(int renkid, string renkad)
        {
            this.Renk_id = renkid;
            this.Renk_adi = renkad;
        }
        public override string ToString()
        {
            return Renk_adi;
        }
    }
}
