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
    public partial class BedenUpdate : Form
    {
        public BedenUpdate()
        {
            InitializeComponent();
            panel7.Enabled = false;
            bedengetir();
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
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                panel7.Enabled = true;
                bedenCbx.Enabled = false;
                label1.Enabled = false;
            }
            else
            {
                checkBox3.Enabled = true;
                checkBox2.Enabled = true;
                panel7.Enabled = false;
                bedenCbx.Enabled = true;
                label1.Enabled = true;
            }
                
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
                panel7.Enabled = true;
                bedenTxt.Enabled = false;
                label20.Enabled = false;
            }
            else
            {
                checkBox3.Enabled = true;
                checkBox1.Enabled = true;
                panel7.Enabled = false;
                bedenTxt.Enabled = true;
                label20.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                UrunServis bedenkaydet = new UrunServis();
                bedenkaydet.bedenimekle(bedenTxt.Text);
                bedenTxt.Text = "";
                bedenCbx.Items.Clear();
                bedengetir();
            }
            else if (checkBox2.Checked == true)
            {
                UrunServis bedensil = new UrunServis();
                Beden bdn = (Beden)bedenCbx.SelectedItem;
                bedensil.bedenisil(bdn.Beden_id);
                bedenCbx.Text = "";
                bedenCbx.Items.Clear();
                bedengetir();
            }
            else if (checkBox3.Checked == true)
            {
                UrunServis degistir = new UrunServis();
                Beden bdn = (Beden)bedenCbx.SelectedItem;
                degistir.bedenguncelle(bdn.Beden_id, bedenTxt.Text);
                bedenTxt.Text = "";
                bedenCbx.Text = "";
                bedenCbx.Items.Clear();
                bedengetir();
            }
        }

        private void bedenCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                panel7.Enabled = true;
                
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox1.Enabled = true;
                panel7.Enabled = false;
                
            }
        }
    }
}
