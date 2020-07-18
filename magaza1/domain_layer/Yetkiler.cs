using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace magaza1.domain_layer
{
    public class Yetkiler
    {
        private int yetki_id;

        public int Yetki_id
        {
            get { return yetki_id; }
            set { yetki_id = value; }
        }
        private string yetki_ad;

        public string Yetki_ad
        {
            get { return yetki_ad; }
            set { yetki_ad = value; }
        }
        public Yetkiler()
        { }
        public Yetkiler(int yid, string yad)
        {
            this.Yetki_id = yid;
            this.Yetki_ad = yad;
        }
        public override string ToString()
        {
            return Yetki_ad;
        }
    }
}
