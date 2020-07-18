using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using magaza1.domain_layer;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace magaza1.DAL
{
    public class MerkezDAO
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Sevdanur\Desktop\PrepToIletisimSoftware\magaza1\magaza1\magazam.mdf;Integrated Security=True;User Instance=True");

        public void magazakaydet(Merkez magazam)
        {
            baglanti.Open();
            SqlCommand magaza_ekle = baglanti.CreateCommand();
            try
            {
                magaza_ekle.CommandText = "insert into magazalar(magaza_adi,magaza_sifre,magaza_bilgi,il_id,ilce_id,yetki_id) values ('" + magazam.Magaza_ad + "','" + magazam.Magaza_sifre + "','" + magazam.Magaza_iletisim + "','" + magazam.Il_id + "','" + magazam.Ilce_id + "','" + magazam.Yetki_id + "')";
                magaza_ekle.ExecuteNonQuery();
                MessageBox.Show("Mağaza Eklendi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Kayıt eklenmedi.Hata" + hata);
            }

        }

        public List<Magaza> mgzlarigetir(int ilceid)
        {
            baglanti.Open();
            SqlCommand mgzkomut = new SqlCommand();
            mgzkomut.Connection = baglanti;
            mgzkomut.CommandText = "select * from magazalar where ilce_id=" + ilceid;
            SqlDataReader mgzoku = mgzkomut.ExecuteReader();
            List<Magaza> mgzlar = new List<Magaza>();
            while (mgzoku.Read())
            {
                mgzlar.Add(new Magaza(Convert.ToInt32(mgzoku[0]), mgzoku[1].ToString()));
            }
            baglanti.Close();
            return mgzlar;
        }

        public void magazasil(Magaza mgz)
        {
            baglanti.Open();
            SqlCommand magaza_sil = baglanti.CreateCommand();
            try
            {
                magaza_sil.CommandText = "delete from magazalar where magaza_id="+mgz.Magaza_id;
                magaza_sil.ExecuteNonQuery();
                MessageBox.Show("Mağaza Silindi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Mağaza Silinemedi.Hata" + hata);
            }
            baglanti.Close();
        }

        public List<Magaza> iletisim(int magid)
        {
            baglanti.Open();
            SqlCommand mgzbilgi = new SqlCommand();
            mgzbilgi.Connection = baglanti;
            mgzbilgi.CommandText = "select * from magazalar where magaza_id=" + magid;
            SqlDataReader bilgioku = mgzbilgi.ExecuteReader();
            List<Magaza> blg = new List<Magaza>();
            while (bilgioku.Read())
            {
                blg.Add(new Magaza(bilgioku[5].ToString()));
            }
            baglanti.Close();
            return blg;

        }

        public void magazadegistirme(Magaza mgzm)
        {
            baglanti.Open();
            SqlCommand mgz_degistir = baglanti.CreateCommand();
            try
            {
                mgz_degistir.CommandText = "update magazalar set magaza_adi='" + mgzm.Magaza_ad + "'where magaza_id=" + mgzm.Magaza_id;
                mgz_degistir.ExecuteNonQuery();
                MessageBox.Show("Magaza Adı Güncellendi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Güncelleme Başarısız.hata" + hata);
            } baglanti.Close();
        }

        public void bilgidegistirme(Magaza mgzm)
        {
            baglanti.Open();
            SqlCommand bilgi_degistir = baglanti.CreateCommand();
            try
            {
                bilgi_degistir.CommandText = "update magazalar set magaza_bilgi='" + mgzm.Magaza_iletisim + "'where magaza_id=" + mgzm.Magaza_id;
                bilgi_degistir.ExecuteNonQuery();
                MessageBox.Show("Magaza Bilgileri Güncellendi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Güncelleme Başarısız.hata" + hata);
            } baglanti.Close();
        }

        public void mgzbilgidegistirme(Magaza mgzm)
        {
            baglanti.Open();
            SqlCommand mgzbilgi_degistir = baglanti.CreateCommand();
            try
            {
                mgzbilgi_degistir.CommandText = "update magazalar set magaza_bilgi='" + mgzm.Magaza_iletisim +"',magaza_adi='"+mgzm.Magaza_ad+"'where magaza_id=" + mgzm.Magaza_id;
                mgzbilgi_degistir.ExecuteNonQuery();
                MessageBox.Show("Magaza Bilgileri Güncellendi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Güncelleme Başarısız.hata" + hata);
            } baglanti.Close();
        }

        public void yetkikaydet(Yetkiler yetkim)
        {
            baglanti.Open();
            SqlCommand yetki_ekle = baglanti.CreateCommand();
            try
            {
                yetki_ekle.CommandText = "insert into yetkiler(yetki_adi) values ('" + yetkim.Yetki_ad+ "')";
                yetki_ekle.ExecuteNonQuery();
                MessageBox.Show("Yetki Eklendi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Kayıt eklenmedi.Hata" + hata);
            }
            baglanti.Close();            
        }

        public List<Yetkiler> yetkilergetir()
        {
            baglanti.Open();
            SqlCommand yetkikomut = new SqlCommand();
            yetkikomut.Connection = baglanti;
            yetkikomut.CommandText = "select * from yetkiler";
            SqlDataReader yetkioku = yetkikomut.ExecuteReader();
            List<Yetkiler> ytkler = new List<Yetkiler>();
            while (yetkioku.Read())
            {
                ytkler.Add(new Yetkiler(Convert.ToInt32(yetkioku[0]), yetkioku[1].ToString()));
            }
            baglanti.Close();
            return ytkler;
        }

        public List<Magaza> mgzlarimgetir()
        {
            baglanti.Open();
            SqlCommand mgzkomut = new SqlCommand();
            mgzkomut.Connection = baglanti;
            mgzkomut.CommandText = "select * from magazalar";
            SqlDataReader mgzoku = mgzkomut.ExecuteReader();
            List<Magaza> mgzlar = new List<Magaza>();
            while (mgzoku.Read())
            {
                mgzlar.Add(new Magaza(Convert.ToInt32(mgzoku[0]), mgzoku[1].ToString()));
            }
            baglanti.Close();
            return mgzlar;
        }

        public void mgzyetkiaddegistirme(Magaza mgzm)
        {
            baglanti.Open();
            SqlCommand mgzyetkiad_degistir = baglanti.CreateCommand();
            try
            {
                mgzyetkiad_degistir.CommandText = "update magazalar set yetki_id='" + mgzm.Yetki_id + "',magaza_adi='" + mgzm.Magaza_ad + "'where magaza_id=" + mgzm.Magaza_id;
                mgzyetkiad_degistir.ExecuteNonQuery();
                MessageBox.Show("Magaza Bilgileri Güncellendi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Güncelleme Başarısız.hata" + hata);
            } baglanti.Close();
        }

        public void mgzyetkiiletisimdegistirme(Magaza mgzm)
        {
            baglanti.Open();
            SqlCommand mgzykiiltsm_degistir = baglanti.CreateCommand();
            try
            {
                mgzykiiltsm_degistir.CommandText = "update magazalar set yetki_id='" + mgzm.Yetki_id + "',magaza_bilgi='" + mgzm.Magaza_iletisim+ "'where magaza_id=" + mgzm.Magaza_id;
                mgzykiiltsm_degistir.ExecuteNonQuery();
                MessageBox.Show("Magaza Bilgileri Güncellendi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Güncelleme Başarısız.hata" + hata);
            } baglanti.Close();
        }

        public void mgzyetkiiletisimaddegistirme(Magaza mgzm)
        {
            baglanti.Open();
            SqlCommand mgzykiiltsmad_degistir = baglanti.CreateCommand();
            try
            {
                mgzykiiltsmad_degistir.CommandText = "update magazalar set yetki_id='" + mgzm.Yetki_id + "',magaza_bilgi='" + mgzm.Magaza_iletisim + "',magaza_adi='" + mgzm.Magaza_ad + "'where magaza_id=" + mgzm.Magaza_id;
                mgzykiiltsmad_degistir.ExecuteNonQuery();
                MessageBox.Show("Magaza Bilgileri Güncellendi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Güncelleme Başarısız.hata" + hata);
            } baglanti.Close();
        }

       public void yetkisil(Yetkiler yetkim)
        {
            baglanti.Open();
            SqlCommand yetki_sil = baglanti.CreateCommand();
            try
            {
                yetki_sil.CommandText = "delete from yetkiler where yetki_id=" +yetkim.Yetki_id;
                yetki_sil.ExecuteNonQuery();
                MessageBox.Show("Yetki Silindi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yetki Silinemedi.Hata" + hata);
            }
            baglanti.Close();
        }
    }
}

