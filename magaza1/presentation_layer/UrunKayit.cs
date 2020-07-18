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

namespace magaza1.presentation_layer
{
    public partial class UrunKayit : Form
    {
        public UrunKayit()
        {
            InitializeComponent();
            kategorilerimigetir();
            renklerimigetir();
            cinsiyetgetir();
            numaraTxt.Enabled = false;
            bedenCbx.Enabled = false;
            button7.Enabled = false;
            button9.Enabled = false;
        }
        private void kategorilerimigetir()
        {
            UrunServis kategoriservis = new UrunServis();
            List<Kategori> kategorilerim = kategoriservis.kategorigetir();

            foreach (Kategori ktgr in kategorilerim)
            {
                ktgrCbx.Items.Add(ktgr);

            }
        }
        private void cinsiyetgetir()
        {
            UrunServis cinsgetir = new UrunServis();
            List<Cinsiyet> cinslerim = cinsgetir.cinsytgetir();
            foreach (Cinsiyet bdn in cinslerim)
            {
                cinsCbx.Items.Add(bdn);

            }
        }
        private void renklerimigetir()
        {
            UrunServis renkservisim = new UrunServis();
            List<Renk> renklerim = renkservisim.renklerigetir();
            foreach (Renk rnk in renklerim)
            {
                renkCbx.Items.Add(rnk);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Kategori ktg = (Kategori)ktgrCbx.SelectedItem;
            Renk rnk = (Renk)renkCbx.SelectedItem;
            Beden bdn = (Beden)bedenCbx.SelectedItem;
            Cinsiyet cns = (Cinsiyet)cinsCbx.SelectedItem;
            UrunServis urunkayit = new UrunServis();
            if (checkBox1.Checked == true)
            {
                urunkayit.urunekle(ktg.Kategori_id, urunadTxt.Text, resimTxt.Text, rnk.Renk_id, bdn.Beden_id, cns.Cins_id,Convert.ToInt64(alisTxt.Text), Convert.ToInt64(satisTxt.Text));
            }
            else if (checkBox2.Checked == true)
            {
                urunkayit.urunmekle(ktg.Kategori_id, urunadTxt.Text, resimTxt.Text, rnk.Renk_id, Convert.ToInt32(numaraTxt.Text), cns.Cins_id, Convert.ToInt64(alisTxt.Text), Convert.ToInt64(satisTxt.Text));
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true)
            {
                urunkayit.urnekle(ktg.Kategori_id, urunadTxt.Text, resimTxt.Text, rnk.Renk_id, Convert.ToInt64(alisTxt.Text), Convert.ToInt64(satisTxt.Text));  
            }
            checkBox3.Checked = false;
            ktgrCbx.Items.Clear();
            ktgrCbx.Text = "";
            urunadTxt.Text = "";
            resimTxt.Text = "";
            yolTxt.Text = "";
            renkCbx.Items.Clear();
            renkCbx.Text = "";
            bedenCbx.Items.Clear();
            bedenCbx.Text = "";
            numaraTxt.Text = "";
            cinsCbx.Items.Clear();
            cinsCbx.Text = "";
            alisTxt.Text = "";
            satisTxt.Text = "";
            kategorilerimigetir();
            renklerimigetir();
            bedengetir();
            cinsiyetgetir();

            
        }
        private void bedengetir()
        {
            UrunServis bedenigetir = new UrunServis();
            List<Beden> bedenlerim = bedenigetir.bedenlergetir();
            foreach (Beden bdn in bedenlerim)
            {
                bedenCbx.Items.Add(bdn);             

            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                bedenCbx.Enabled = false;
                checkBox1.Enabled = false;
                numaraTxt.Enabled = true;
            }
            else
            {
                checkBox1.Enabled = true;
                numaraTxt.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                bedenCbx.Enabled = true;
                checkBox2.Enabled = false;
                bedengetir();
                numaraTxt.Enabled = false;
            }
            else
            {
                bedenCbx.Enabled = false;
                checkBox2.Enabled = true;
                
            }
        }

        OpenFileDialog dosyaupload = new OpenFileDialog();
        private void button7_Click(object sender, EventArgs e)
        {
            dosyaupload.ShowDialog();
            button9.Enabled = true;
                       
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string ad = resimTxt.Text;
            string yol = Application.StartupPath.ToString().Replace(@"\bin\Debug", @"\resimler\");
            string[] dosyalar = Directory.GetFiles(yol);
            int i = 1;
            foreach (string s in dosyalar)
            {
                i++;
            }
            yol += i + ".jpg";
            File.Copy(dosyaupload.FileName, yol, true);
            UrunServis servis = new UrunServis();
            servis.resimKaydet(ad, yol);
            yolTxt.Text = dosyaupload.FileName;
            MessageBox.Show("Dosya kaydedildi");
            
        }

        private void resimTxt_TextChanged(object sender, EventArgs e)
        {
            button7.Enabled = true;
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                cinsCbx.Enabled = false;
            }
            else
            {
                cinsCbx.Enabled = true;
            }
        }
    }
}
