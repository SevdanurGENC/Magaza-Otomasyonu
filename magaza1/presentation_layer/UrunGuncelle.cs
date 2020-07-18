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
    public partial class UrunGuncelle : Form
    {
        public UrunGuncelle()
        {
            InitializeComponent();
            textBox1.Hide();
            comboBox1.Hide();
            textBox2.Hide();
            button2.Hide();
            button3.Hide();
        }
        private void kategorilerimigetir()
        {
            UrunServis kategoriservis = new UrunServis();
            List<Kategori> kategorilerim = kategoriservis.kategorigetir();

            foreach (Kategori ktgr in kategorilerim)
            {
                kategoCbx.Items.Add(ktgr);
            }
        }
        private void bedengetir()
        {
            UrunServis bedenigetir = new UrunServis();
            List<Beden> bedenlerim = bedenigetir.bedenlergetir();
            foreach (Beden bdn in bedenlerim)
            {
                comboBox1.Items.Add(bdn);

            }

        }
        private void cinsiyetgetir()
        {
            UrunServis cinsgetir = new UrunServis();
            List<Cinsiyet> cinslerim = cinsgetir.cinsytgetir();
            foreach (Cinsiyet bdn in cinslerim)
            {
               comboBox1.Items.Add(bdn);

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                UrunServis servis = new UrunServis();
                Urun urunm = (Urun)urunCbx.SelectedItem;
                Renk rnk = (Renk)comboBox1.SelectedItem;
                servis.renkguncel(urunm.Urun_id,rnk.Renk_id);
                kategoCbx.Text="";
                urunCbx.Text = "";
                comboBox1.Text = ""; 
                kategoCbx.Items.Clear();
                urunCbx.Items.Clear();
                comboBox1.Items.Clear();
            }
            else if (checkBox4.Checked == true)
            {
                UrunServis servis = new UrunServis();
                Urun urunm = (Urun)urunCbx.SelectedItem;                
                servis.resimguncel(urunm.Urun_id, textBox2.Text);
                kategoCbx.Text = "";
                urunCbx.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                kategoCbx.Items.Clear();
                urunCbx.Items.Clear();                
            }
            else if (checkBox5.Checked == true)
            {
                UrunServis servis = new UrunServis();
                Urun urunm = (Urun)urunCbx.SelectedItem;
                Beden bdn = (Beden)comboBox1.SelectedItem;
                servis.bedenguncel(urunm.Urun_id, bdn.Beden_id);
                kategoCbx.Text = "";
                urunCbx.Text = "";
                comboBox1.Text = "";
                kategoCbx.Items.Clear();
                urunCbx.Items.Clear();
                
            }
            else if (checkBox6.Checked == true)
            {
                UrunServis servis = new UrunServis();
                Urun urunm = (Urun)urunCbx.SelectedItem;
                servis.numaraguncel(urunm.Urun_id, Convert.ToInt32(textBox1.Text));
                kategoCbx.Text = "";
                urunCbx.Text = "";
                textBox1.Text = "";
                kategoCbx.Items.Clear();
                urunCbx.Items.Clear();
                kategorilerimigetir();
            }
            else if (checkBox7.Checked == true)
            {
                UrunServis servis = new UrunServis();
                Urun urunm = (Urun)urunCbx.SelectedItem;
                Cinsiyet cns = (Cinsiyet)comboBox1.SelectedItem;
                servis.cnsytguncel(urunm.Urun_id, cns.Cins_id);
                kategoCbx.Text = "";
                urunCbx.Text = "";
                comboBox1.Text = "";
                kategoCbx.Items.Clear();
                urunCbx.Items.Clear();
            }
            else if (checkBox8.Checked == true)
            {
                UrunServis servis = new UrunServis();
                Urun urunm = (Urun)urunCbx.SelectedItem;
                servis.alisfiyguncel(urunm.Urun_id, Convert.ToInt64(textBox1.Text));
                kategoCbx.Text = "";
                urunCbx.Text = "";
                textBox1.Text = "";
                kategoCbx.Items.Clear();
                urunCbx.Items.Clear();
                kategorilerimigetir();
            }
            else if (checkBox9.Checked == true)
            {
                UrunServis servis = new UrunServis();
                Urun urunm = (Urun)urunCbx.SelectedItem;
                servis.satisfiyguncel(urunm.Urun_id, Convert.ToInt64(textBox1.Text));
                kategoCbx.Text = "";
                urunCbx.Text = "";
                textBox1.Text = "";
                kategoCbx.Items.Clear();
                urunCbx.Items.Clear();
                kategorilerimigetir();
            }
        }

        private void kategoCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrunServis kateler = new UrunServis();
            List<Urun> urunum = kateler.urungetir(((Kategori)(kategoCbx.SelectedItem)).Kategori_id);
            urunCbx.Items.Clear();
            foreach (Urun urunm in urunum)
            {
                urunCbx.Items.Add(urunm);
            }
        }
        private void renklerimigetir()
        {
            UrunServis renkservisim = new UrunServis();
            List<Renk> renklerim = renkservisim.renklerigetir();
            foreach (Renk rnk in renklerim)
            {
                comboBox1.Items.Add(rnk);
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                kategoCbx.Items.Clear();
                kategorilerimigetir();
                comboBox1.Show();
                label3.Text = "Renk Seçiniz:";
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                renklerimigetir();
                
            }
            else
            {
                comboBox1.Text = "";
                comboBox1.Hide();
                label3.Text = "";
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
                checkBox7.Enabled = true;
                checkBox8.Enabled = true;
                checkBox9.Enabled = true;
                kategoCbx.Text = "";
                urunCbx.Text = "";

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                kategoCbx.Items.Clear();
                kategorilerimigetir();
                textBox1.Show();
                label3.Text = "Resim Adı:";
                button2.Show();
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
            }
            else
            {
                textBox1.Text = "";
                textBox1.Hide();
                textBox2.Text = "";
                textBox2.Hide();
                button2.Hide();
                button3.Hide();
                label3.Text = "";
                label4.Text = "";
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
                checkBox7.Enabled = true;
                checkBox8.Enabled = true;
                checkBox9.Enabled = true;
                kategoCbx.Text = "";
                urunCbx.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        OpenFileDialog dosyaupload = new OpenFileDialog();
        private void button2_Click(object sender, EventArgs e)
        {
            dosyaupload.ShowDialog();
            textBox2.Show();
            label4.Text = "Resmin Konumu:";
            button3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
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
            textBox2.Text = dosyaupload.FileName;
            MessageBox.Show("Dosya kaydedildi");
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                
                kategoCbx.Items.Clear();
                kategorilerimigetir();
                
                comboBox1.Show();
                label3.Text = "Beden Seçiniz:";
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox4.Enabled = false;
                checkBox3.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                bedengetir();
            }
            else
            {
                comboBox1.Text = "";
                comboBox1.Hide();
                label3.Text = "";
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox4.Enabled = true;
                checkBox3.Enabled = true;
                checkBox6.Enabled = true;
                checkBox7.Enabled = true;
                checkBox8.Enabled = true;
                checkBox9.Enabled = true;
                
           }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                kategoCbx.Items.Clear();
                kategorilerimigetir();
                textBox1.Show();
                label3.Text = "Numara Giriniz:";
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox5.Enabled = false;
                checkBox4.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
            }
            else
            {
                kategoCbx.Text = "";
                urunCbx.Text = "";
                textBox1.Text = "";
                textBox1.Hide();           
                label3.Text = "";
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox5.Enabled = true;
                checkBox4.Enabled = true;
                checkBox7.Enabled = true;
                checkBox8.Enabled = true;
                checkBox9.Enabled = true;

            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                
                kategoCbx.Items.Clear();
                kategorilerimigetir();
                comboBox1.Show();
                comboBox1.Items.Clear();
                cinsiyetgetir();
                label3.Text = "Cinsiyet Seçiniz:";
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox4.Enabled = false;
                checkBox3.Enabled = false;
                checkBox6.Enabled = false;
                checkBox5.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
            }
            else
            {
                comboBox1.Text = "";
                comboBox1.Hide();
                label3.Text = "";
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox4.Enabled = true;
                checkBox3.Enabled = true;
                checkBox6.Enabled = true;
                checkBox5.Enabled = true;
                checkBox8.Enabled = true;
                checkBox9.Enabled = true;
                kategoCbx.Text = "";
                urunCbx.Text = "";
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                kategoCbx.Items.Clear();
                kategorilerimigetir();
                textBox1.Show();
                label3.Text = "Alış Fiyatı:";
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox5.Enabled = false;
                checkBox4.Enabled = false;
                checkBox7.Enabled = false;
                checkBox6.Enabled = false;
                checkBox9.Enabled = false;
            }
            else
            {
                kategoCbx.Text = "";
                urunCbx.Text = "";
                textBox1.Text = "";
                textBox1.Hide();
                label3.Text = "";
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox5.Enabled = true;
                checkBox4.Enabled = true;
                checkBox7.Enabled = true;
                checkBox6.Enabled = true;
                checkBox9.Enabled = true;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                kategoCbx.Items.Clear();
                kategorilerimigetir();
                textBox1.Show();
                label3.Text = "SatışFiyatı:";
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox5.Enabled = false;
                checkBox4.Enabled = false;
                checkBox7.Enabled = false;
                checkBox6.Enabled = false;
                checkBox8.Enabled = false;
            }
            else
            {
                kategoCbx.Text = "";
                urunCbx.Text = "";
                textBox1.Text = "";
                textBox1.Hide();
                label3.Text = "";
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox5.Enabled = true;
                checkBox4.Enabled = true;
                checkBox7.Enabled = true;
                checkBox6.Enabled = true;
                checkBox8.Enabled = true;
            }
        }
    }
}
