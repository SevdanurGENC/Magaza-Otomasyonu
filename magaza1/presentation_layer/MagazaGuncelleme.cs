using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using magaza1.domain_layer;

namespace magaza1.presentation_layer
{
    public partial class MagazaGuncelleme : Form
    {
        public MagazaGuncelleme()
        {
            InitializeComponent();
            sehirlerigetir();
            
            ymgzTxt.Enabled = false;
            yiltsmTxt.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            yetkiCbx.Enabled = false;
        }
        private void sehirlerigetir()
        {
            SehirServisi sehirgetir = new SehirServisi();
            List<Sehir> sehirlerim = sehirgetir.sehirlerimigetir();
            foreach (Sehir shr in sehirlerim)
            {
                sehirCbx.Items.Add(shr);
            }
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

        private void sehirCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SehirServisi ilceler = new SehirServisi();
            List<Ilceler> ilcelerim = ilceler.ilcegetir(((Sehir)(sehirCbx.SelectedItem)).Sehir_id);
            ilceCbx.Items.Clear();
            foreach (Ilceler ilcem in ilcelerim)
            {
                ilceCbx.Items.Add(ilcem);
            }
        }

        private void ilceCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            MerkezServisi mgzlar = new MerkezServisi();
            List<Magaza> magazam = mgzlar.magazagetir(((Ilceler)(ilceCbx.SelectedItem)).Ilce_id);
            mgzadCbx.Items.Clear();
            foreach (Magaza mgz in magazam)
            {
                mgzadCbx.Items.Add(mgz);
            }
        }

        private void mgzadCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MerkezServisi yorum = new MerkezServisi();
            List<Magaza> mgzm = yorum.bilgigetir(((Magaza)(mgzadCbx.SelectedItem)).Magaza_id);
            foreach (Magaza yrm in mgzm)
            {
                listBox1.Items.Add(yrm.Magaza_iletisim);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked==false)
            {
                MerkezServisi guncel = new MerkezServisi();
                Magaza mgzm = (Magaza)mgzadCbx.SelectedItem;
                guncel.magazadegistir(mgzm.Magaza_id, ymgzTxt.Text);
                listBox1.Items.Clear();
                ilceCbx.Items.Clear();
                mgzadCbx.Items.Clear();
                checkBox1.Checked = false;
                sehirCbx.Text = "";
                ilceCbx.Text = "";
                mgzadCbx.Text = "";
                sehirCbx.Items.Clear();
                sehirlerigetir();
                ymgzTxt.Enabled = false;
            }
            else if (checkBox2.Checked == true && checkBox1.Checked == false && checkBox3.Checked==false)
            {
                MerkezServisi guncel = new MerkezServisi();
                Magaza mgzm = (Magaza)mgzadCbx.SelectedItem;
                guncel.bilgidegistir(mgzm.Magaza_id, yiltsmTxt.Text);
                listBox1.Items.Clear();
                ilceCbx.Items.Clear();
                mgzadCbx.Items.Clear();                
                checkBox2.Checked = false;
                sehirCbx.Text = "";
                ilceCbx.Text = "";
                yiltsmTxt.Text = "";
                mgzadCbx.Text = "";
                sehirCbx.Items.Clear();
                sehirlerigetir();
                yiltsmTxt.Enabled = false;
                
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked==false)
            {
                MerkezServisi guncel = new MerkezServisi();
                Magaza mgzm = (Magaza)mgzadCbx.SelectedItem;
                guncel.mgzbilgidegistir(mgzm.Magaza_id, ymgzTxt.Text, yiltsmTxt.Text);
                listBox1.Items.Clear();
                ilceCbx.Items.Clear();
                mgzadCbx.Items.Clear();               
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                sehirCbx.Text = "";
                ymgzTxt.Text = "";
                ilceCbx.Text = "";
                yiltsmTxt.Text = "";
                mgzadCbx.Text = "";
                sehirCbx.Items.Clear();
                sehirlerigetir();
                yiltsmTxt.Enabled = false;
                ymgzTxt.Enabled = false;
            }
            else if (checkBox1.Checked == true && checkBox3.Checked == true && checkBox2.Checked == false)
            {
                MerkezServisi guncel = new MerkezServisi();
                Magaza mgzm = (Magaza)mgzadCbx.SelectedItem;
                Yetkiler ytkm = (Yetkiler)yetkiCbx.SelectedItem;
                guncel.mgzyetaddgst(mgzm.Magaza_id, ymgzTxt.Text, ytkm.Yetki_id);
                ilceCbx.Items.Clear();
                mgzadCbx.Items.Clear();
                listBox1.Items.Clear();
                checkBox3.Checked = false;
                checkBox1.Checked = false;
                sehirCbx.Text = "";
                ymgzTxt.Text = "";
                ilceCbx.Text = "";
                mgzadCbx.Text = "";
                sehirCbx.Items.Clear();
                sehirlerigetir();
                yetkiCbx.Text = "";
                yetkiCbx.Items.Clear();
                yetkilerigetir();
                yetkiCbx.Enabled = false;
                ymgzTxt.Enabled = false;
            
            }
            else if (checkBox2.Checked == true && checkBox3.Checked == true && checkBox1.Checked == false)
            {
                MerkezServisi guncel = new MerkezServisi();
                Magaza mgzm = (Magaza)mgzadCbx.SelectedItem;
                Yetkiler ytkm = (Yetkiler)yetkiCbx.SelectedItem;
                guncel.mgzyetiltsmdgst(mgzm.Magaza_id, yiltsmTxt.Text, ytkm.Yetki_id);
                ilceCbx.Items.Clear();
                mgzadCbx.Items.Clear();
                listBox1.Items.Clear();
                checkBox3.Checked = false;
                checkBox2.Checked = false;
                sehirCbx.Text = "";
                yiltsmTxt.Text = "";
                ilceCbx.Text = "";
                mgzadCbx.Text = "";
                sehirCbx.Items.Clear();
                sehirlerigetir();
                yetkiCbx.Text = "";
                yetkiCbx.Items.Clear();
                yetkilerigetir();
                yetkiCbx.Enabled = false;
                yiltsmTxt.Enabled = false; 
            }
            else if (checkBox2.Checked == true && checkBox3.Checked == true && checkBox1.Checked == true)
            {
                MerkezServisi guncel = new MerkezServisi();
                Magaza mgzm = (Magaza)mgzadCbx.SelectedItem;
                Yetkiler ytkm = (Yetkiler)yetkiCbx.SelectedItem;
                guncel.mgzyetiltsmaddgst(mgzm.Magaza_id, ymgzTxt.Text, yiltsmTxt.Text, ytkm.Yetki_id);
                ilceCbx.Items.Clear();
                mgzadCbx.Items.Clear();
                listBox1.Items.Clear();
                checkBox3.Checked = false;
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                sehirCbx.Text = "";
                yiltsmTxt.Text = "";
                ilceCbx.Text = "";
                mgzadCbx.Text = "";
                sehirCbx.Items.Clear();
                sehirlerigetir();
                yetkiCbx.Text = "";
                yetkiCbx.Items.Clear();
                yetkilerigetir();
                yetkiCbx.Enabled = false;
                yiltsmTxt.Enabled = false;
                ymgzTxt.Text = "";
                ymgzTxt.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label5.Enabled = true;
                ymgzTxt.Enabled = true;
            }
            else
            {
                ymgzTxt.Text = "";
                ymgzTxt.Enabled = false;
                label5.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                label6.Enabled = true;
                yiltsmTxt.Enabled = true;
            }
            else
            {
                
                yiltsmTxt.Text = "";
                label6.Enabled = false;
                yiltsmTxt.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                yetkilerigetir();
                label7.Enabled = true;
                yetkiCbx.Enabled = true;
            }
            else
            {
                yetkiCbx.Text = "";
                yetkiCbx.Items.Clear();
                label7.Enabled = false;
                yetkiCbx.Enabled = false;
            }
        }

    }
}
