using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using magaza1.DAL;
using magaza1.domain_layer;

namespace magaza1
{
   public class SehirServisi
    {
       
       public void sehirekle(string sehirad, int plaka)
       {
           SehirDAO sehirlerim = new SehirDAO();
           Sehir sehrim = new Sehir();
           sehrim.Sehir_adi = sehirad;
           sehrim.Sehir_plaka = plaka;
           sehirlerim.sehirekle(sehrim);
         
       }

       public List<Sehir> sehirlerimigetir()
       {
           return new SehirDAO().sehirlergetir();
       }
       public void sehrimsil(int ilid)
       {
           SehirDAO ilsil = new SehirDAO();
           Sehir ilim = new Sehir();
           ilim.Sehir_id = ilid;
           ilsil.sehirsilme(ilim);
       }
       public void ildegistir(int ilid, string ilad, int plaka)
       {
           SehirDAO shrdgstr = new SehirDAO();
           Sehir shrim = new Sehir();
           shrim.Sehir_id = ilid;
           shrim.Sehir_adi = ilad;
           shrim.Sehir_plaka = plaka;
           shrdgstr.ildegistir(shrim);
       }

       public void ilceekle(Ilceler ilce)
       {
           SehirDAO ilcelerim = new SehirDAO();
           
           ilcelerim.ilceekle(ilce);

       }

       public List<Ilceler> ilcegetir(int ilid)
       {
           return new SehirDAO().ilcelergetir(ilid);
       }

       public void ilcesil(int ilceid)
       {
           SehirDAO ilcemsil = new SehirDAO();
           Ilceler ilcem = new Ilceler();
           ilcem.Ilce_id = ilceid;
           ilcemsil.sililce(ilcem);
       }

       public void ilcedegistir(int ilceidsi, string ilceadi)
       {
           SehirDAO ilcemdegis = new SehirDAO();
           Ilceler ilcm = new Ilceler();
           ilcm.Ilce_id = ilceidsi;
           ilcm.Ilce_adi = ilceadi;
           ilcemdegis.degistir(ilcm);
       }
    }
}
