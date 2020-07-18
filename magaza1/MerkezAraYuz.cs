using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using magaza1.domain_layer;
using System.IO;

namespace magaza1
{
    public partial class MerkezAraYuz : Form
    {
        public MerkezAraYuz()
        {
            InitializeComponent();
            sehirlerigetir();
            kategorilerimigetir();
            renklerimigetir();
            numaraTxt.Enabled = false;
            bedenCbx.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sehir ilim=(Sehir)milCbx.SelectedItem;
            //Ilceler ilcem=(Ilceler)milceCbx.SelectedItem;
            //magazasifreTxt.MaxLength = 5;
            //MerkezServisi magazakaydet = new MerkezServisi();
            //magazakaydet.magazaekle(magazaadTxt.Text, Convert.ToInt32(magazasifreTxt.Text), ilim.Sehir_id, ilcem.Ilce_id);
            
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            SehirServisi sehirler = new SehirServisi();
            sehirler.sehirekle(sehirTxt.Text, Convert.ToInt32(plakaTxt.Text));
            sehirCbx.Items.Clear();
            sehirlerigetir();
            sehirTxt.Clear();
            plakaTxt.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sehir sehirlerim = (Sehir)sehirCbx.SelectedItem;
            Ilceler ilcem = new Ilceler();
            ilcem.Il_id = sehirlerim.Sehir_id;
            ilcem.Ilce_adi = ilceTxt.Text;
            SehirServisi ilcekayit = new SehirServisi();
            ilcekayit.ilceekle(ilcem);
            sehirCbx.Text = "";
            ilceTxt.Text = "";
        }
        private void sehirlerigetir()
        {
            SehirServisi sehirgetir = new SehirServisi();
            List<Sehir> sehirlerim = sehirgetir.sehirlerimigetir();
            foreach (Sehir shr in sehirlerim)
            {
                sehirCbx.Items.Add(shr);
                milCbx.Items.Add(shr);
            }
        }

        private void milCbx_SelectedIndexChanged(object sender, EventArgs e)
        {

            SehirServisi ilceler = new SehirServisi();
            List<Ilceler> ilcelerim = ilceler.ilcegetir(((Sehir)(milCbx.SelectedItem)).Sehir_id);
            milceCbx.Items.Clear();
            milceCbx.Text = "";
            foreach (Ilceler ilcem in ilcelerim)
            {
                milceCbx.Items.Add(ilcem);
            }

        }

        private void button3_Click(object sender, EventArgs e)//eklendi
        {
            UrunServis kategori = new UrunServis();
            kategori.kategoriekle(KategoriTxt.Text);
            KategoriTxt.Text = "";
            ktgrCbx.Items.Clear();
            kategorilerimigetir();

        }
        private void kategorilerimigetir() //eklendi
        {
            UrunServis kategoriservis = new UrunServis();
            List<Kategori> kategorilerim = kategoriservis.kategorigetir();
            
            foreach (Kategori ktgr in kategorilerim)
            {
                ktgrCbx.Items.Add(ktgr);

            }
        }
        private void renklerimigetir()
        {
            UrunServis renkservisim= new UrunServis();
            List<Renk> renklerim=renkservisim.renklerigetir();
            foreach(Renk rnk in renklerim)
            {
                renkCbx.Items.Add(rnk);
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            UrunServis renkler = new UrunServis();
            renkler.renkekle(renkTxt.Text);
            renkTxt.Text = "";
            renkCbx.Items.Clear();
            renklerimigetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                numaraTxt.Enabled = false;
                bedenCbx.Enabled = true;
                checkBox1.Checked = false;
            }
            else
            {
                bedenCbx.Enabled = false;
                
            }
            
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                numaraTxt.Enabled = true;
                bedenCbx.Enabled = false;
                checkBox2.Checked = false;
            }
            else
            {
                numaraTxt.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UrunServis bedenkaydet = new UrunServis();
            bedenkaydet.bedenimekle(bedenTxt.Text);

        }
        OpenFileDialog dosyaupload = new OpenFileDialog();
        private void button7_Click(object sender, EventArgs e)
        {
            dosyaupload.ShowDialog();
        }
        
    }
}
