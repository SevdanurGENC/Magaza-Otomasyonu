using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using magaza1.domain_layer;
using System.Windows.Forms;

namespace magaza1.DAL
{
    public class UrunDAO
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Sevdanur\Desktop\PrepToIletisimSoftware\magaza1\magaza1\magazam.mdf;Integrated Security=True;User Instance=True");
        
        public void urunkayit(Urun urunum)
        {
            baglanti.Open();
            SqlCommand urun_ekle = baglanti.CreateCommand();
            try
            {
                urun_ekle.CommandText = "insert into urunler(urun_adi,kategori_id,resim_yol,renk_id,beden_id,cinsiyet_id,alis_fiyat,satis_fiyat) values('" + urunum.Urun_adi + "','" + urunum.Kate_id + "','" + urunum.Resim_yol + "','" + urunum.Renk_id + "','" + urunum.Beden_id + "','" + urunum.Cins_id + "','" + urunum.Alisfiyati + "','" + urunum.Satisfiyati + "')";
                urun_ekle.ExecuteNonQuery();
                MessageBox.Show("Urun Eklendi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("kayıt eklenemedi.hata:" + hata);
            }
        }

        public void urunmkayit(Urun urunum)
        {
            baglanti.Open();
            SqlCommand urun_ekle = baglanti.CreateCommand();
            try
            {
                urun_ekle.CommandText = "insert into urunler(urun_adi,kategori_id,resim_yol,renk_id,numara,cinsiyet_id,alis_fiyat,satis_fiyat) values('" + urunum.Urun_adi + "','" + urunum.Kate_id + "','" + urunum.Resim_yol + "','" + urunum.Renk_id + "','" + urunum.Numara + "','" + urunum.Cins_id + "','" + urunum.Alisfiyati + "','" + urunum.Satisfiyati + "')";
                urun_ekle.ExecuteNonQuery();
                MessageBox.Show("Urun Eklendi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("kayıt eklenemedi.hata:" + hata);
            }
        }
        public void urnmkayit(Urun urunum)
        {
            baglanti.Open();
            SqlCommand urun_ekle = baglanti.CreateCommand();
            try
            {
                urun_ekle.CommandText = "insert into urunler(urun_adi,kategori_id,resim_yol,renk_id,alis_fiyat,satis_fiyat) values('" + urunum.Urun_adi + "','" + urunum.Kate_id + "','" + urunum.Resim_yol + "','" + urunum.Renk_id + "','" + urunum.Alisfiyati + "','" + urunum.Satisfiyati + "')";
                urun_ekle.ExecuteNonQuery();
                MessageBox.Show("Urun Eklendi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("kayıt eklenemedi.hata:" + hata);
            }
        }

        public List<Urun> urunlerigetir(int katid)
        {
            baglanti.Open();
            SqlCommand urunkomut = new SqlCommand();
            urunkomut.Connection = baglanti;
            urunkomut.CommandText = "select * from urunler where kategori_id=" + katid;
            SqlDataReader urunoku = urunkomut.ExecuteReader();
            List<Urun> urunlr = new List<Urun>();
            while (urunoku.Read())
            {
                urunlr.Add(new Urun(Convert.ToInt32(urunoku[0]), urunoku[1].ToString()));
            }
            baglanti.Close();
            return urunlr;
        }

        public void urunsil(Urun urnmsil)
        {
            baglanti.Open();
            SqlCommand urun_sil = baglanti.CreateCommand();
            try
            {
                urun_sil.CommandText = "delete from urunler where urun_id=" + urnmsil.Urun_id;
                urun_sil.ExecuteNonQuery();
                MessageBox.Show("Ürün Silindi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Ürün Silinemedi.Hata" + hata);
            }
            baglanti.Close();
        }

        public void urunrenkgncl(Urun urunrenk)
        {
            baglanti.Open();
            SqlCommand rnk_degistir = baglanti.CreateCommand();
            try
            {
                rnk_degistir.CommandText = "update urunler set renk_id='" + urunrenk.Renk_id + "'where urun_id=" + urunrenk.Urun_id;
                rnk_degistir.ExecuteNonQuery();
                MessageBox.Show("Ürün Rengi Güncellendi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Güncelleme Başarısız.hata" + hata);
            }
            baglanti.Close();
        }

        public void urunresimgncl(Urun urunresim)
        {
            baglanti.Open();
            SqlCommand resim_degistir = baglanti.CreateCommand();
            try
            {
                resim_degistir.CommandText = "update urunler set resim_yol='" + urunresim.Resim_yol+ "'where urun_id=" + urunresim.Urun_id;
                resim_degistir.ExecuteNonQuery();
                MessageBox.Show("Ürün Resmi Güncellendi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Güncelleme Başarısız.hata" + hata);
            }
            baglanti.Close();
        }

        public void urunbedengncl(Urun urunbeden)
        {
            baglanti.Open();
            SqlCommand beden_degistir = baglanti.CreateCommand();
            try
            {
                beden_degistir.CommandText = "update urunler set beden_id='" + urunbeden.Beden_id + "'where urun_id=" + urunbeden.Urun_id;
                beden_degistir.ExecuteNonQuery();
                MessageBox.Show("Ürün Beden Güncellendi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Güncelleme Başarısız.hata" + hata);
            }
            baglanti.Close();
        }

        public void urunnogncl(Urun urunno)
        {
            baglanti.Open();
            SqlCommand no_degistir = baglanti.CreateCommand();
            try
            {
                no_degistir.CommandText = "update urunler set numara='" + urunno.Numara + "'where urun_id=" + urunno.Urun_id;
                no_degistir.ExecuteNonQuery();
                MessageBox.Show("Ürün Numarası Güncellendi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Güncelleme Başarısız.hata" + hata);
            }
            baglanti.Close();
        }

        public void uruncnsytgncl(Urun uruncns)
        {
            baglanti.Open();
            SqlCommand cns_degistir = baglanti.CreateCommand();
            try
            {
                cns_degistir.CommandText = "update urunler set cinsiyet_id='" + uruncns.Cins_id + "'where urun_id=" + uruncns.Urun_id;
                cns_degistir.ExecuteNonQuery();
                MessageBox.Show("Ürün Cinsiyet Bilgisi Güncellendi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Güncelleme Başarısız.hata" + hata);
            }
            baglanti.Close();
        }

       public void urunalisgncl(Urun urunalis)
        {
            baglanti.Open();
            SqlCommand alis_degistir = baglanti.CreateCommand();
            try
            {
                alis_degistir.CommandText = "update urunler set alis_fiyat='" + urunalis.Alisfiyati + "'where urun_id=" + urunalis.Urun_id;
                alis_degistir.ExecuteNonQuery();
                MessageBox.Show("Ürün Alış Fiyatı Güncellendi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Güncelleme Başarısız.hata" + hata);
            }
            baglanti.Close();
        }

      public void urunsatisgncl(Urun urunsatis)
       {
           baglanti.Open();
           SqlCommand satis_degistir = baglanti.CreateCommand();
           try
           {
               satis_degistir.CommandText = "update urunler set satis_fiyat='" + urunsatis.Satisfiyati + "'where urun_id=" + urunsatis.Urun_id;
               satis_degistir.ExecuteNonQuery();
               MessageBox.Show("Ürün Satış Fiyatı Güncellendi.");
           }
           catch (Exception hata)
           {
               MessageBox.Show("Güncelleme Başarısız.hata" + hata);
           }
           baglanti.Close();
       }

      public List<Urun> urunsiparisr(int katid)//düzgün çalışmıyor
      {
          baglanti.Open();
          SqlCommand urunsprs = new SqlCommand();
          urunsprs.Connection = baglanti;
          urunsprs.CommandText = "select * from urunler where kategori_id=" + katid;
          SqlDataReader urunsprsoku = urunsprs.ExecuteReader();
          List<Urun> urunsprslr = new List<Urun>();
          while (urunsprsoku.Read())
          {
              urunsprslr.Add(new Urun(Convert.ToInt32(urunsprsoku[0]), urunsprsoku[1].ToString(), Convert.ToInt32(urunsprsoku[2]), Convert.ToInt32(urunsprsoku[4]),Convert.ToInt32(urunsprsoku[5])));
          }
          baglanti.Close();
          return urunsprslr;   
      }
    }
}
