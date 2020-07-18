using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace magaza1.domain_layer
{
    public class Magaza:Merkez
    {
        public Magaza()
        { 
        
        }
        public Magaza(int magid, string magad)
        {
            this.Magaza_id = magid;
            this.Magaza_ad = magad;            
        }
        public override string ToString()
        {
            return Magaza_ad;
        }
        public Magaza(string bilgim)
        {
            this.Magaza_iletisim = bilgim;
        }
        
    }
}
