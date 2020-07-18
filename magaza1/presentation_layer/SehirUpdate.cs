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
    public partial class SehirUpdate : Form
    {
        public SehirUpdate()
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
                sehirCbx.Items.Clear();
                sehirlerigetir();
                sehirCbx.Enabled = false;
                label1.Enabled = false;

            }
            else
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                sehirCbx.Enabled = true;
                sehirCbx.Items.Clear();
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
                sehirCbx.Items.Clear();
                sehirlerigetir();
                sehirTxt.Enabled = false;
                plakaTxt.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
                sehirTxt.Enabled = true;
                plakaTxt.Enabled = true;
                label16.Enabled = true;
                label17.Enabled = true;
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
                sehirCbx.Items.Clear();
                sehirlerigetir();
                
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                sehirCbx.Items.Clear();
                panel1.Enabled = false;


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                SehirServisi sehirler = new SehirServisi();
                sehirler.sehirekle(sehirTxt.Text, Convert.ToInt32(plakaTxt.Text));
                sehirCbx.Items.Clear();
                sehirlerigetir();
                sehirTxt.Clear();
                plakaTxt.Clear();
            }
            else if(checkBox2.Checked==true)
            {
                SehirServisi sehirsil = new SehirServisi();
                Sehir shr = (Sehir)sehirCbx.SelectedItem;
                sehirsil.sehrimsil(shr.Sehir_id);
                sehirCbx.Text = "";
                sehirCbx.Items.Clear();
                sehirlerigetir();
            }
            else if (checkBox3.Checked == true)
            {
                SehirServisi dgstr = new SehirServisi();
                Sehir shrm = (Sehir)sehirCbx.SelectedItem;
                dgstr.ildegistir(shrm.Sehir_id, sehirTxt.Text, Convert.ToInt32(plakaTxt.Text));
                sehirCbx.Text = "";
                sehirTxt.Text = "";
                plakaTxt.Text = "";
                sehirCbx.Items.Clear();
                sehirlerigetir();
            }
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
    }
}
