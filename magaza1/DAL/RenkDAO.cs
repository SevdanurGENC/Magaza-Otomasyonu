using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using magaza1.domain_layer;
using System.Windows.Forms;

namespace magaza1.DAL
{
   public class RenkDAO
    {
       SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Sevdanur\Desktop\PrepToIletisimSoftware\magaza1\magaza1\magazam.mdf;Integrated Security=True;User Instance=True");

       public void renklerekle(Renk rengim)
       {
           baglanti.Open();
           SqlCommand renk_ekle = baglanti.CreateCommand();
           try
           {
               renk_ekle.CommandText = "insert into renkler(renk_adi) values('" + rengim.Renk_adi + "')";
               renk_ekle.ExecuteNonQuery();
               MessageBox.Show("Renk Eklendi");
           }
           catch (Exception hata)
           {
               MessageBox.Show("Renk eklenemedi.hata:" + hata);
           }
           baglanti.Close();
       }

       public List<Renk> renklerimigetir()
       {
           baglanti.Open();
           SqlCommand renkkomut = new SqlCommand();
           renkkomut.Connection = baglanti;
           renkkomut.CommandText = "select * from renkler";
           SqlDataReader renkoku = renkkomut.ExecuteReader();
           List<Renk> renkler = new List<Renk>();
           while (renkoku.Read())
           {
               renkler.Add(new Renk(Convert.ToInt32(renkoku[0]), renkoku[1].ToString()));
           }
           baglanti.Close();
           return renkler;
       }

       public void renksilme(Renk rnk)
       {
           baglanti.Open();
           SqlCommand renk_sil = baglanti.CreateCommand();
           try
           {
               renk_sil.CommandText = "delete from renkler where renk_id=" + rnk.Renk_id;
               renk_sil.ExecuteNonQuery();
               MessageBox.Show("Renk Silindi");
           }
           catch(Exception hata)
           {
               MessageBox.Show("Renk Silinemedi.hata" + hata);
           }
           baglanti.Close();
       }

       public void renkdegistir(Renk rengim)
       {
           baglanti.Open();
           SqlCommand renk_degistir = baglanti.CreateCommand();
           try
           {
               renk_degistir.CommandText = "update renkler set renk_adi='"+rengim.Renk_adi+"' where renk_id=" + rengim.Renk_id;
               renk_degistir.ExecuteNonQuery();
               MessageBox.Show("Renk Değiştirildi");
           }
           catch (Exception hata)
           {
               MessageBox.Show("Renk Değiştirilemedi.hata" + hata);
           }
           baglanti.Close();   
       }
    }
 }
