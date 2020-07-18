using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using magaza1.domain_layer;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace magaza1.DAL
{
    public class ServisDAO
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Sevdanur\Desktop\PrepToIletisimSoftware\magaza1\magaza1\magazam.mdf;Integrated Security=True;User Instance=True");
        public void sipariskaydet(Siparis siparisim)
        {
            baglanti.Open();
            SqlCommand siparis_ekle = baglanti.CreateCommand();
            try
            {
                siparis_ekle.CommandText = "insert into siparisler(siparis_tarihi,kategori_id,urun_id,adet,magaza_id) values('" + siparisim.Tarih + "','" + siparisim.Kat_id + "','" + siparisim.Urun_id + "','" + siparisim.Adet + "','" + siparisim.Mag_id + "')";
                siparis_ekle.ExecuteNonQuery();
                MessageBox.Show("Sipariş Gönderildi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("kayıt eklenemedi.hata:" + hata);
            }
        }
    }
}
