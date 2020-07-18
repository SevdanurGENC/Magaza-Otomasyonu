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
    public partial class RenkUpdate : Form
    {
        public RenkUpdate()
        {
            InitializeComponent();
            panel4.Enabled = false;
            renklerimigetir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                UrunServis renkler = new UrunServis();
                renkler.renkekle(renkTxt.Text);
                renkTxt.Text = "";
                renkCbx.Items.Clear();
                renklerimigetir();
            }
            else if (checkBox2.Checked == true)
            {
                UrunServis renksil = new UrunServis();
                Renk rnk = (Renk)renkCbx.SelectedItem;
                renksil.rengisil(rnk.Renk_id);
                renkCbx.Text = "";
                renkCbx.Items.Clear();
                renklerimigetir();
            }
            else if (checkBox3.Checked == true)
            {
                UrunServis degistir = new UrunServis();
                Renk rnk = (Renk)renkCbx.SelectedItem;
                degistir.renkdgstr(rnk.Renk_id, renkTxt.Text);
                renkCbx.Text = "";
                renkTxt.Text="";
                renkCbx.Items.Clear();
                renklerimigetir();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                panel4.Enabled = true;
                renkCbx.Enabled = false;
                label1.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                panel4.Enabled = false;
                renkCbx.Enabled = true;
                label1.Enabled = true;            
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
                panel4.Enabled = true;
                renkTxt.Enabled = false;
                label15.Enabled = false;
                renkCbx.Items.Clear();
                renklerimigetir();
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
                panel4.Enabled = false;
                renkTxt.Enabled = true;
                label15.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                panel4.Enabled = true;
                renkCbx.Items.Clear();
                renklerimigetir();

            }
            else
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                panel4.Enabled = false;
            }
        }

    }
}
