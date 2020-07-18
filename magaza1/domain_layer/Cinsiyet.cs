using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace magaza1.domain_layer
{
    public class Cinsiyet
    {
        private int cins_id;

        public int Cins_id
        {
            get { return cins_id; }
            set { cins_id = value; }
        }
        private string cins_ad;

        public string Cins_ad
        {
            get { return cins_ad; }
            set { cins_ad = value; }
        }
        public Cinsiyet()
        { }
        public Cinsiyet(int id, string ad)
        { 
            this.Cins_id=id;
            this.Cins_ad = ad;
        }
        public override string ToString()
        {
            return this.Cins_ad;
        }
    }
}
