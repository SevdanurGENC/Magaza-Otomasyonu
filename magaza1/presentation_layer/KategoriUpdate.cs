using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using magaza1.domain_layer;

namespace magaza1
{
    public partial class KategoriUpdate : Form
    {
        public KategoriUpdate()
        {
            InitializeComponent();
            panel1.Enabled = false;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                panel1.Enabled = true;
                kategoCbx.Enabled = false;
                label1.Enabled = false;
                
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                kategoCbx.Enabled = true;
                kategoCbx.Items.Clear();
                label1.Enabled = true;
                panel1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
                panel1.Enabled = true;
                kategorilerimigetir();
                KategoriTxt.Enabled = false;
                label3.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
                kategoCbx.Items.Clear();
                KategoriTxt.Enabled = true;
                label3.Enabled = true;
                panel1.Enabled = false;

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox1.Enabled = false;
                panel1.Enabled = true;
                kategorilerimigetir();
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                kategoCbx.Items.Clear();
                panel1.Enabled = false;
                

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                UrunServis kategori = new UrunServis();
                kategori.kategoriekle(KategoriTxt.Text);
                KategoriTxt.Text = "";
                kategoCbx.Items.Clear();
                kategorilerimigetir();
            }
            else if (checkBox2.Checked == true)
            {
                UrunServis silkategori = new UrunServis();
                Kategori ktgr = (Kategori)kategoCbx.SelectedItem;
                silkategori.kategorisil(ktgr.Kategori_id);
                kategoCbx.Text = "";
                kategoCbx.Items.Clear();
                kategorilerimigetir();
            }
            else if(checkBox3.Checked==true)
            {
                UrunServis degistir = new UrunServis();
                Kategori ktgr = (Kategori)kategoCbx.SelectedItem;
                degistir.kategoriguncelle(KategoriTxt.Text, ktgr.Kategori_id);
                kategoCbx.Text = "";
                KategoriTxt.Text = "";
                kategoCbx.Items.Clear();
                kategorilerimigetir();
            }
            else
            {
                kategoCbx.Items.Clear();
                kategorilerimigetir();
            }
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

    }
}
