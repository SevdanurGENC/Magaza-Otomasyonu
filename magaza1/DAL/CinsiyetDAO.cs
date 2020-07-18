using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using magaza1.DAL;
using magaza1.domain_layer;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace magaza1
{
   public class CinsiyetDAO
    {
       SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Sevdanur\Desktop\PrepToIletisimSoftware\magaza1\magaza1\magazam.mdf;Integrated Security=True;User Instance=True");

       public void cinskaydet(Cinsiyet cns)
        {
            baglanti.Open();
            SqlCommand cins_ekle = baglanti.CreateCommand();
            try 
            {
                cins_ekle.CommandText = "insert into cinsiyet(cins_adi) values('" + cns.Cins_ad + "')";
                cins_ekle.ExecuteNonQuery();
                MessageBox.Show("Kayıt Eklendi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Kayıt eklenemedi.hata:" + hata);
            }
            baglanti.Close();
            
           
        }

       public List<Cinsiyet> cinsiyetlerigetir()
       {
           baglanti.Open();
           SqlCommand komutcins = new SqlCommand();
           komutcins.Connection = baglanti;
           komutcins.CommandText = "select * from cinsiyet";
           SqlDataReader cinsoku = komutcins.ExecuteReader();
           List<Cinsiyet> cnsler = new List<Cinsiyet>();
           while (cinsoku.Read())
           {
               cnsler.Add(new Cinsiyet(Convert.ToInt32(cinsoku[0]), cinsoku[1].ToString()));
           }
           baglanti.Close();
           return cnsler;
       }

       public void silcins(Cinsiyet cins)
       {
           baglanti.Open();
           SqlCommand cins_sil = baglanti.CreateCommand();
           try 
           {
               cins_sil.CommandText = "delete from cinsiyet where cins_id=" + cins.Cins_id;
               cins_sil.ExecuteNonQuery();
               MessageBox.Show("Cinsiyet Silindi");
           }
           catch (Exception hata)
           {
               MessageBox.Show("Kayıt Silinmedi.hata:" + hata);
           }
           baglanti.Close();
           
       }
    }
}
