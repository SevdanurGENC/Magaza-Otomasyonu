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
    public partial class CinsiyetBilgileri : Form
    {
        public CinsiyetBilgileri()
        {
            InitializeComponent();
            panel1.Enabled = false;
            cinsiyetgetir();
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
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Enabled = false;
                panel1.Enabled = true;
                label1.Enabled = false;
                cinsCbx.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                panel1.Enabled = false;
                label1.Enabled = true;
                cinsCbx.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Enabled = false;
                panel1.Enabled = true;
                label2.Enabled = false;
                cinsTxt.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                panel1.Enabled = false;
                label2.Enabled = true;
                cinsTxt.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                UrunServis cinskaydet = new UrunServis();
                cinskaydet.cinsiyetekle(cinsTxt.Text);
                cinsTxt.Text = "";
                cinsCbx.Items.Clear();
                cinsiyetgetir();
            }
            else if (checkBox2.Checked == true)
            {
                UrunServis sil = new UrunServis();
                Cinsiyet cns = (Cinsiyet)cinsCbx.SelectedItem;
                sil.cinssil(cns.Cins_id);
                cinsCbx.Text = "";
                cinsCbx.Items.Clear();
                cinsiyetgetir();
            }
        }
    }
}
