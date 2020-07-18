using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace magaza1.domain_layer
{
    public class Resim
    {
        private int resim_id;

        public int Resim_id
        {
            get { return resim_id; }
            set { resim_id = value; }
        }
        private string resim_yol;

        public string Resim_yol
        {
            get { return resim_yol; }
            set { resim_yol = value; }
        }
        private string resim_ad;

        public string Resim_ad
        {
            get { return resim_ad; }
            set { resim_ad = value; }
        }
    }
}
