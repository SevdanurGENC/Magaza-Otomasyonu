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
    public partial class YetkiPanel : Form
    {
        public YetkiPanel()
        {
            InitializeComponent();
            label1.Enabled = false;
            label2.Enabled = false;
            yetkiTxt.Enabled = false;
            yetkiCbx.Enabled = false;
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MerkezServisi yetki = new MerkezServisi();
                yetki.yetkiekle(yetkiTxt.Text);
                yetkiTxt.Text = "";
            }
            else if (checkBox2.Checked == true)
            {
                MerkezServisi yetki = new MerkezServisi();
                Yetkiler ytk = (Yetkiler)yetkiCbx.SelectedItem;
                yetki.yetkisilme(ytk.Yetki_id);
                yetkiCbx.Text="";
                yetkiCbx.Items.Clear();
                yetkilerigetir();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label1.Enabled = true;
                yetkiTxt.Enabled = true;
                checkBox2.Enabled = false;
            }
            else
            {
                yetkiTxt.Text = "";
                label1.Enabled = false;
                yetkiTxt.Enabled = false;
                checkBox2.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                yetkiCbx.Items.Clear();
                yetkilerigetir();
                label2.Enabled = true;
                yetkiCbx.Enabled = true;
                checkBox1.Enabled = false;
            }
            else
            {
                yetkiCbx.Text = "";
                label2.Enabled = false;
                yetkiCbx.Enabled = false;
                checkBox1.Enabled = true;
                yetkiCbx.Items.Clear();
            }
        }
    }
}
