using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using magaza1.domain_layer;

namespace magaza1.presentation_layer
{
    public partial class PanelGiris : Form
    {
        public int magazaidal;//mağaza id çekebilmek için texbox kullanıldı

        public PanelGiris()
        {
            InitializeComponent();
            yetkilerigetir();
            magazalarimigetir();
        }      
      
        private void yetkilerigetir()
        {
            MerkezServisi yetki = new MerkezServisi();
            List<Yetkiler> yetkilerim = yetki.yetkigetir();
            foreach (Yetkiler ytk in yetkilerim)
            {
                yetkiCbx.Items.Add(ytk);
            }
        }
        private void magazalarimigetir()
        {
            MerkezServisi magazam = new MerkezServisi();
            List<Magaza> mgzlrm = magazam.magazamgetir();
            foreach (Magaza mgz in mgzlrm)
            {
                mgzCbx.Items.Add(mgz);
            }
        
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Sevdanur\Desktop\PrepToIletisimSoftware\magaza1\magaza1\magazam.mdf;Integrated Security=True;User Instance=True");
        SqlCommand Komut;
        SqlDataReader Dr;
        
        private void button1_Click(object sender, EventArgs e)
        {
            magazaidal = ((Magaza)mgzCbx.SelectedItem).Magaza_id;
            MagazaPanel mgzpnl = new MagazaPanel(magazaidal);
           
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();

            Komut = new SqlCommand("select magaza_id, magaza_sifre,yetki_id from magazalar where magaza_id=@magaza_id and magaza_sifre=@magaza_sifre and yetki_id=@yetki_id", baglanti);
            Komut.Parameters.Add("@magaza_id", SqlDbType.Int).Value = ((Magaza)mgzCbx.SelectedItem).Magaza_id; 
            Komut.Parameters.Add("@magaza_sifre", SqlDbType.Int).Value = sifreTxt.Text;
            Komut.Parameters.Add("@yetki_id", SqlDbType.Int).Value = ((Yetkiler)yetkiCbx.SelectedItem).Yetki_id;
            Dr = Komut.ExecuteReader();
           
            if (!Dr.Read())
            {
                Dr.Close();
                Dr.Dispose();
                MessageBox.Show("kullanici adiniz yada sifreniz hatali");
                return;
            }

            Dr.Close();
            Dr.Dispose();
            MessageBox.Show("Hoş Geldiniz");
        
            if (((Yetkiler)yetkiCbx.SelectedItem).Yetki_id == 1)
            {
               new MerkezPanel().ShowDialog();
      
            }

            if (((Yetkiler)yetkiCbx.SelectedItem).Yetki_id == 2)
            {
                mgzpnl.Show();
            }
            mgzCbx.Text = "";
            sifreTxt.Text = "";
            yetkiCbx.Text = "";
            }

        private void PanelGiris_Load(object sender, EventArgs e)
        {

        }
        }
    }

