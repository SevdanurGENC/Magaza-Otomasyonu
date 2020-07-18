using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using magaza1.domain_layer;
using System.Windows.Forms;

namespace magaza1.DAL
{
    public class KategoriDAO
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Sevdanur\Desktop\PrepToIletisimSoftware\magaza1\magaza1\magazam.mdf;Integrated Security=True;User Instance=True");
        
        public void kategorilerekle(Kategori kategorim)
        {
            baglanti.Open();
            SqlCommand kat_ekle = baglanti.CreateCommand();
            try
            {
                kat_ekle.CommandText = "insert into kategoriler(kategori_adi) values('" + kategorim.Kategori_adi + "')";
                kat_ekle.ExecuteNonQuery();
                MessageBox.Show("Kategori Eklendi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("kayıt eklenemedi.hata:" + hata);
            }
            
        }

        public List<Kategori> kategorilerigetir()
        {
            baglanti.Open();
            SqlCommand komutkategori = new SqlCommand();
            komutkategori.Connection = baglanti;
            komutkategori.CommandText = "select * from kategoriler";
            SqlDataReader kategorileroku = komutkategori.ExecuteReader();
            List<Kategori> kateler = new List<Kategori>();
            while (kategorileroku.Read())
            {
                kateler.Add(new Kategori(Convert.ToInt32(kategorileroku[0]), kategorileroku[1].ToString()));
            }
            baglanti.Close();
            return kateler;
        }

        public void kategorisil(Kategori kategr)
        {
            baglanti.Open();
            SqlCommand kat_sil = baglanti.CreateCommand();
            try
            {
                kat_sil.CommandText = "delete from kategoriler where kategori_id= '" + kategr.Kategori_id + "'";
                kat_sil.ExecuteNonQuery();
                MessageBox.Show("Kategori Silindi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("kayıt eklenemedi.hata:" + hata);
            }
            baglanti.Close();
        }

        public void kategoridegistir(Kategori ktgr)
        {
            baglanti.Open();
            SqlCommand kat_degistir = baglanti.CreateCommand();
            try
            {
                kat_degistir.CommandText = "update kategoriler set kategori_adi='"+ktgr.Kategori_adi+"' where kategori_id="+ktgr.Kategori_id;
                kat_degistir.ExecuteNonQuery();
                MessageBox.Show("Kategori Değiştirildi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("kayıt eklenemedi.hata:" + hata);
            }
            baglanti.Close();
        }
    }
}
