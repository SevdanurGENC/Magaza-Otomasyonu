using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using magaza1.DAL;
using magaza1.domain_layer;


namespace magaza1
{
    public class MerkezServisi
    {
        public void magazaekle(string magazaad, int magazasifre,string iletisim, int ilid, int ilceid,int ytkid)
        {
            //MerkezDAO magazaekleme = new MerkezDAO();
            //magazaekleme.magazakaydet(magazaad, magazasifre, ilid, ilceid);
            MerkezDAO magazaekle = new MerkezDAO();
            Merkez magazam = new Merkez();
            magazam.Magaza_ad = magazaad;
            magazam.Magaza_sifre = magazasifre;
            magazam.Magaza_iletisim = iletisim;
            magazam.Il_id = ilid;
            magazam.Ilce_id = ilceid;
            magazam.Yetki_id = ytkid;
            magazaekle.magazakaydet(magazam);
        }

        public List<Magaza> magazagetir(int ilceid)
        {
            return new MerkezDAO().mgzlarigetir(ilceid);
        }

        public void magazasilme(int magid)
        {
            MerkezDAO sil = new MerkezDAO();
            Magaza mgz = new Magaza();
            mgz.Magaza_id = magid;
            sil.magazasil(mgz);
        }
        public void magazadegistir(int magid, string magad)
        {
            MerkezDAO degistir = new MerkezDAO();
            Magaza mgzm = new Magaza();
            mgzm.Magaza_id = magid;
            mgzm.Magaza_ad = magad;
            degistir.magazadegistirme(mgzm);
        }

        public List<Magaza> bilgigetir(int magid)
        {
            return new MerkezDAO().iletisim(magid);
        }



        internal void bilgidegistir(int mgzid, string iletisim)
        {
            MerkezDAO degistir = new MerkezDAO();
            Magaza mgzm = new Magaza();
            mgzm.Magaza_id = mgzid;
            mgzm.Magaza_iletisim = iletisim;
            degistir.bilgidegistirme(mgzm);
            
        }

        public void mgzbilgidegistir(int magid, string magad, string magiltsm)
        {
            MerkezDAO degistir = new MerkezDAO();
            Magaza mgzm = new Magaza();
            mgzm.Magaza_id = magid;
            mgzm.Magaza_ad = magad;
            mgzm.Magaza_iletisim = magiltsm;
            degistir.mgzbilgidegistirme(mgzm);
           
        }

        public void yetkiekle(string yetad)
        {
            MerkezDAO daom = new MerkezDAO();
            Yetkiler yetkim = new Yetkiler();
            yetkim.Yetki_ad = yetad;
            daom.yetkikaydet(yetkim);
        }

        public List<Yetkiler> yetkigetir()
        {
            return new MerkezDAO().yetkilergetir();
        }

        public List<Magaza> magazamgetir()
        {
            return new MerkezDAO().mgzlarimgetir();
        }
        public void mgzyetaddgst(int magid, string magad, int yetid)
        {
            MerkezDAO degistir = new MerkezDAO();
            Magaza mgzm = new Magaza();
            mgzm.Magaza_id = magid;
            mgzm.Magaza_ad = magad;
            mgzm.Yetki_id = yetid;
            degistir.mgzyetkiaddegistirme(mgzm);
        }

        public void mgzyetiltsmdgst(int magid, string magiltsm, int yetid)
        {
            MerkezDAO degistir = new MerkezDAO();
            Magaza mgzm = new Magaza();
            mgzm.Magaza_id = magid;
            mgzm.Magaza_iletisim = magiltsm;
            mgzm.Yetki_id = yetid;
            degistir.mgzyetkiiletisimdegistirme(mgzm);
        }

       public void mgzyetiltsmaddgst(int magid, string magad, string magiltsm, int yetid)
        {
            MerkezDAO degistir = new MerkezDAO();
            Magaza mgzm = new Magaza();
            mgzm.Magaza_ad = magad;
            mgzm.Magaza_id = magid;
            mgzm.Magaza_iletisim = magiltsm;
            mgzm.Yetki_id = yetid;
            degistir.mgzyetkiiletisimaddegistirme(mgzm);
        }

       public void yetkisilme(int yetid)
       {
           MerkezDAO daom = new MerkezDAO();
           Yetkiler yetkim = new Yetkiler();
           yetkim.Yetki_id = yetid;
           daom.yetkisil(yetkim);
       }
    }
}
