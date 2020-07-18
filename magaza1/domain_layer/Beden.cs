using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace magaza1.domain_layer
{
    public class Beden
    {
        private int beden_id;

        public int Beden_id
        {
            get { return beden_id; }
            set { beden_id = value; }
        }
        private string beden_adi;

        public string Beden_adi
        {
            get { return beden_adi; }
            set { beden_adi = value; }
        }
        public override string ToString()
        {
            return Beden_adi;
        }        
        public Beden()
        {
           
        }
        public Beden(int bedid, string bedadi)
        {
            this.Beden_id = bedid;
            this.Beden_adi = bedadi;
        
        }
    }
}
