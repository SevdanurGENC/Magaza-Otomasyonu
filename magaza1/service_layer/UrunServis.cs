using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using magaza1.domain_layer;
using magaza1.DAL;


namespace magaza1
{
    public class UrunServis
    {

        public void kategoriekle(string kateadi)
        {
            KategoriDAO kategorilerim = new KategoriDAO();
            Kategori kategorim = new Kategori();
            kategorim.Kategori_adi = kateadi;
            kategorilerim.kategorilerekle(kategorim);
        }

        public List<Kategori> kategorigetir()
        {
            return new KategoriDAO().kategorilerigetir();
        }
        public void kategorisil(int kateid)
        {
            KategoriDAO silktgr = new KategoriDAO();
            Kategori kategr = new Kategori();
            kategr.Kategori_id = kateid;
            silktgr.kategorisil(kategr);

        }
        public void kategoriguncelle(string katad, int katid)
        {
            KategoriDAO degistir = new KategoriDAO();
            Kategori ktgr = new Kategori();
            ktgr.Kategori_adi = katad;
            ktgr.Kategori_id = katid;
            degistir.kategoridegistir(ktgr);

        }

        public void renkekle(string renkad)
        {
            RenkDAO renklerim = new RenkDAO();
            Renk rengim = new Renk();
            rengim.Renk_adi = renkad;
            renklerim.renklerekle(rengim);

        }

        public List<Renk> renklerigetir()
        {
            return new RenkDAO().renklerimigetir();
        }
        public void rengisil(int renkid)
        {
            RenkDAO sil = new RenkDAO();
            Renk rnk = new Renk();
            rnk.Renk_id = renkid;
            sil.renksilme(rnk);
        }
        public void renkdgstr(int renkid, string renkad)
        {
            RenkDAO dgstr = new RenkDAO();
            Renk rengim = new Renk();
            rengim.Renk_id = renkid;
            rengim.Renk_adi = renkad;
            dgstr.renkdegistir(rengim);

        }

        public void bedenimekle(string bedenad)
        {
            BedenDAO bedenler = new BedenDAO();
            Beden bdnm = new Beden();
            bdnm.Beden_adi = bedenad;
            bedenler.bedenekle(bdnm);
        }

        public List<Beden> bedenlergetir()
        {
            return new BedenDAO().bedenlerigetir();
        }
        public void bedenisil(int bedid)
        {
            BedenDAO silbeden = new BedenDAO();
            Beden bedenim = new Beden();
            bedenim.Beden_id = bedid;
            silbeden.bedensil(bedenim);
        }
        public void bedenguncelle(int bedid, string bedad)
        {
            BedenDAO bdndegistir = new BedenDAO();
            Beden bdn = new Beden();
            bdn.Beden_id = bedid;
            bdn.Beden_adi = bedad;
            bdndegistir.bedendegistir(bdn);
        }

        public void cinsiyetekle(string cinsad)
        {
            CinsiyetDAO cinsiyetler = new CinsiyetDAO();
            Cinsiyet cns = new Cinsiyet();
            cns.Cins_ad = cinsad;
            cinsiyetler.cinskaydet(cns);
        }

        public List<Cinsiyet> cinsytgetir()
        {
            return new CinsiyetDAO().cinsiyetlerigetir();
        }
        public void cinssil(int cinsid)
        {
            CinsiyetDAO cnsytsil = new CinsiyetDAO();
            Cinsiyet cins = new Cinsiyet();
            cins.Cins_id = cinsid;
            cnsytsil.silcins(cins);
        }
                
        public void resimKaydet(string ad, string yol)
        {                    
            ResimDAO daom = new ResimDAO();
            Resim resmim = new Resim();
            resmim.Resim_ad = ad;
            resmim.Resim_yol = yol;
            daom.resimkayit(resmim);
        }

        public void urunekle(int ktg_id, string urunad, string rsmyol, int rnkid, int bdnid,int cinsid, float alisfiy, float satisfiy)
        {
            UrunDAO urundaom = new UrunDAO();
            Urun urunum = new Urun();
            urunum.Kate_id = ktg_id;
            urunum.Urun_adi = urunad;
            urunum.Resim_yol = rsmyol;
            urunum.Renk_id = rnkid;
            urunum.Beden_id = bdnid;
            urunum.Cins_id = cinsid;
            urunum.Alisfiyati = alisfiy;
            urunum.Satisfiyati = satisfiy;
            urundaom.urunkayit(urunum);
        }

        public void urunmekle(int ktg_id, string urunad, string rsmyol, int rnkid, int numara, int cinsid, float alisfiy, float satisfiy)
        {
            UrunDAO urundaom = new UrunDAO();
            Urun urunum = new Urun();
            urunum.Kate_id = ktg_id;
            urunum.Urun_adi = urunad;
            urunum.Resim_yol = rsmyol;
            urunum.Renk_id = rnkid;
            urunum.Numara = numara;
            urunum.Cins_id = cinsid;
            urunum.Alisfiyati = alisfiy;
            urunum.Satisfiyati = satisfiy;
            urundaom.urunmkayit(urunum);
        }


        public List<Urun> urungetir(int katid)   
        {
            return new UrunDAO().urunlerigetir(katid);
        }

        public void silurun(int urunid)
        {
            UrunDAO sildaom = new UrunDAO();
            Urun urnmsil = new Urun();
            urnmsil.Urun_id = urunid;
            sildaom.urunsil(urnmsil);
        }

        public void renkguncel(int urunid,int renkid)
        {
            UrunDAO rnkdao = new UrunDAO();
            Urun urunrenk = new Urun();
            urunrenk.Urun_id = urunid;
            urunrenk.Renk_id = renkid;
            rnkdao.urunrenkgncl(urunrenk);
        }

        public void resimguncel(int urunid, string yol)
        {
            UrunDAO resimdao = new UrunDAO();
            Urun urunresim = new Urun();
            urunresim.Urun_id = urunid;
            urunresim.Resim_yol = yol;
            resimdao.urunresimgncl(urunresim);
        }

        public void urnekle(int ktg_id, string urunad, string rsmyol, int rnkid, float alisfiy, float satisfiy)
        {
            UrunDAO urundaom = new UrunDAO();
            Urun urunum = new Urun();
            urunum.Kate_id = ktg_id;
            urunum.Urun_adi = urunad;
            urunum.Resim_yol = rsmyol;
            urunum.Renk_id = rnkid;
            urunum.Alisfiyati = alisfiy;
            urunum.Satisfiyati = satisfiy;
            urundaom.urnmkayit(urunum);
        }

        public void bedenguncel(int urunid, int bedid)
        {
            UrunDAO bedendao = new UrunDAO();
            Urun urunbeden = new Urun();
            urunbeden.Urun_id = urunid;
            urunbeden.Beden_id = bedid;
            bedendao.urunbedengncl(urunbeden);
        }

        public void numaraguncel(int urunid, int numara)
        {
            UrunDAO numaradao = new UrunDAO();
            Urun urunno = new Urun();
            urunno.Urun_id = urunid;
            urunno.Numara = numara;
            numaradao.urunnogncl(urunno);
        }

        public void cnsytguncel(int urunid, int cinsid)
        {
            UrunDAO cinsadao = new UrunDAO();
            Urun uruncns = new Urun();
            uruncns.Urun_id = urunid;
            uruncns.Cins_id = cinsid;
            cinsadao.uruncnsytgncl(uruncns);
        }

       public void alisfiyguncel(int urunid, long alisfiy)
        {
            UrunDAO alisdao = new UrunDAO();
            Urun urunalis = new Urun();
            urunalis.Urun_id = urunid;
            urunalis.Alisfiyati= alisfiy;
            alisdao.urunalisgncl(urunalis);
        }

       public void satisfiyguncel(int urunid, long satisfiy)
       {
           UrunDAO satisdao = new UrunDAO();
           Urun urunsatis = new Urun();
           urunsatis.Urun_id = urunid;
           urunsatis.Satisfiyati= satisfiy;
           satisdao.urunsatisgncl(urunsatis);
       }

       public List<Urun> siparisgonder(int katid)//silinecek
       {
           return new UrunDAO().urunsiparisr(katid);
       }
    }
}
