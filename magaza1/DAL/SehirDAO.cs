using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using magaza1.domain_layer;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace magaza1.DAL
{
    public class SehirDAO
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Sevdanur\Desktop\PrepToIletisimSoftware\magaza1\magaza1\magazam.mdf;Integrated Security=True;User Instance=True");
        
        public void sehirekle(Sehir sehrim)
        {
            baglanti.Open();
            SqlCommand sehir_ekle = baglanti.CreateCommand();
            try
            {
                sehir_ekle.CommandText = "insert into sehirler(sehir_adi,sehir_plaka) values('" + sehrim.Sehir_adi + "','" + sehrim.Sehir_plaka + "')";
                sehir_ekle.ExecuteNonQuery();
                MessageBox.Show("Şehir Eklendi");
            }
            catch(Exception hata)
            {
                MessageBox.Show("Kayıt eklenmedi.Hata" + hata);
            }
            baglanti.Close();

            
        }

        public List<Sehir> sehirlergetir()
        {
            baglanti.Open();
            SqlCommand sehirkomut = new SqlCommand();
            sehirkomut.Connection = baglanti;
            sehirkomut.CommandText = "select * from sehirler";
            SqlDataReader sehiroku = sehirkomut.ExecuteReader();
            List<Sehir> sehirler = new List<Sehir>();
            while (sehiroku.Read())
            {
                sehirler.Add(new Sehir(Convert.ToInt32(sehiroku[0]), sehiroku[1].ToString()));
            }
            baglanti.Close();
            return sehirler;
        }
        public void sehirsilme(Sehir ilim)
        {
            baglanti.Open();
            SqlCommand il_sil = baglanti.CreateCommand();
            try
            {
                il_sil.CommandText = "delete from sehirler where sehir_id=" + ilim.Sehir_id;
                il_sil.ExecuteNonQuery();
                MessageBox.Show("Şehir Silindi");
            }
            catch(Exception hata)
            {
                MessageBox.Show("Şehir Silinemedi.Hata" + hata);
            }
        }
        public void ildegistir(Sehir shrim)
        {
            baglanti.Open();
            SqlCommand il_dgstr = baglanti.CreateCommand();
            try
            {
                il_dgstr.CommandText = "update sehirler set sehir_adi='" + shrim.Sehir_adi + "', sehir_plaka='" + shrim.Sehir_plaka + "'where sehir_id=" + shrim.Sehir_id;
                il_dgstr.ExecuteNonQuery();
                MessageBox.Show("Şehir Değiştirildi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Şehir Değiştirilemedi.Hata" + hata);
            }
            baglanti.Close();
        }
        public void ilceekle(Ilceler ilce)
        {
            baglanti.Open();
            SqlCommand ilce_ekle = baglanti.CreateCommand();
            try
            {
                ilce_ekle.CommandText = "insert into ilceler(ilce_adi,il_id) values('" + ilce.Ilce_adi + "','" + ilce.Il_id + "')";
                ilce_ekle.ExecuteNonQuery();
                MessageBox.Show("İlçe Eklendi");
            }
            catch(Exception hata)
            {
                MessageBox.Show("Kayıt eklenmedi.Hata" + hata);
            }
            baglanti.Close();
        }

        public List<Ilceler> ilcelergetir(int ilid)
        {
            baglanti.Open();
            SqlCommand ilcekomut = new SqlCommand();
            ilcekomut.Connection = baglanti;
            ilcekomut.CommandText = "select * from ilceler where il_id=" + ilid;
            SqlDataReader ilcemoku = ilcekomut.ExecuteReader();
            List<Ilceler> ilceler = new List<Ilceler>();
            while (ilcemoku.Read())
            {
                ilceler.Add(new Ilceler(Convert.ToInt32(ilcemoku[0]), ilcemoku[1].ToString()));
            }
            baglanti.Close();
            return ilceler;
            
        }

        public void sililce(Ilceler ilcem)
        {
            baglanti.Open();
            SqlCommand ilce_sil = baglanti.CreateCommand();
            try
            {
                ilce_sil.CommandText = "delete from ilceler where ilce_id=" + ilcem.Ilce_id;
                ilce_sil.ExecuteNonQuery();
                MessageBox.Show("İlçe Silindi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İlçe Silinemedi.hata:" + hata);
            }
            baglanti.Close();
            
        }

        public void degistir(Ilceler ilcm)
        {
            baglanti.Open();
            SqlCommand ilce_dgstr = baglanti.CreateCommand();
            try
            {
                ilce_dgstr.CommandText = "update ilceler set ilce_adi='"+ilcm.Ilce_adi+ "'where ilce_id=" + ilcm.Ilce_id;
                ilce_dgstr.ExecuteNonQuery();
                MessageBox.Show("İlçe Değiştirildi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İlçe Değiştirilmedi.hata:" + hata);
            }
            baglanti.Close();
            
        }
        
    }
}
