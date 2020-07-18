using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using magaza1.domain_layer;
using System.Data.SqlClient;

namespace magaza1.DAL
{
    public class ResimDAO
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Sevdanur\Desktop\PrepToIletisimSoftware\magaza1\magaza1\magazam.mdf;Integrated Security=True;User Instance=True");

        public void resimkayit(Resim resmim)
        {
            baglanti.Open();
            SqlCommand komutum = new SqlCommand();
            komutum.Connection = baglanti;
            komutum.CommandText = "insert into resimler (resim_ad,resim_yol) values ('" + resmim.Resim_ad + "','" + resmim.Resim_yol + "')";
            komutum.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
