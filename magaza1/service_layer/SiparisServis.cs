using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using magaza1.domain_layer;
using magaza1.DAL;

namespace magaza1.service_layer
{
    public class SiparisServis
    {


        public void siparisekle(int kat_id, int magid,int urun_id, int adet,DateTime tarih)
        {
            ServisDAO sipekle = new ServisDAO();
            Siparis siparisim = new Siparis();

            siparisim.Kat_id = kat_id;
            siparisim.Mag_id = magid;
            siparisim.Urun_id = urun_id;
            siparisim.Adet = adet;
            siparisim.Tarih = tarih;
            sipekle.sipariskaydet(siparisim);
        }
    }
}
