using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using magaza1.domain_layer;
using System.Windows.Forms;

namespace magaza1.DAL
{
    public class BedenDAO
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Sevdanur\Desktop\PrepToIletisimSoftware\magaza1\magaza1\magazam.mdf;Integrated Security=True;User Instance=True");
        public void bedenekle(Beden bdnm)
        {
            baglanti.Open();
            SqlCommand beden_ekle = baglanti.CreateCommand();
            try
            {
                beden_ekle.CommandText = "insert into beden(b_adi) values('" + bdnm.Beden_adi + "')";
                beden_ekle.ExecuteNonQuery();
                MessageBox.Show("Beden Eklendi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Kayıt eklenemedi.hata:" + hata);
            }
            baglanti.Close();
        }



        public List<Beden> bedenlerigetir()
        {
            baglanti.Open();
            SqlCommand komutbeden = new SqlCommand();
            komutbeden.Connection = baglanti;
            komutbeden.CommandText = "select * from beden";
            SqlDataReader bedenoku = komutbeden.ExecuteReader();
            List<Beden> bdnler = new List<Beden>();
            while (bedenoku.Read())
            {
                bdnler.Add(new Beden(Convert.ToInt32(bedenoku[0]), bedenoku[1].ToString()));
            }
            baglanti.Close();
            return bdnler;
           
        }

        public void bedensil(Beden bedenim)
        {
            baglanti.Open();
            SqlCommand beden_sil = baglanti.CreateCommand();
            try
            {
                beden_sil.CommandText = "delete from beden where b_id=" + bedenim.Beden_id;
                beden_sil.ExecuteNonQuery();
                MessageBox.Show("Beden Silindi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Kayıt eklenemedi.hata:" + hata);
            }
            baglanti.Close();
        }

       public void bedendegistir(Beden bdn)
        {
            baglanti.Open();
            SqlCommand beden_dgstr = baglanti.CreateCommand();
            try
            {
                beden_dgstr.CommandText = "update beden set b_adi='"+bdn.Beden_adi+"' where b_id=" + bdn.Beden_id;
                beden_dgstr.ExecuteNonQuery();
                MessageBox.Show("Beden Değiştirildi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Kayıt Değiştirilmedi.hata:" + hata);
            }
            baglanti.Close();
        }
    }
    }

