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
    public partial class IlceUpdate : Form
    {
        public IlceUpdate()
        {
            InitializeComponent();
            panel1.Enabled = false;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                panel1.Enabled = true;
                sehirCbx.Items.Clear();
                sehirlerigetir();
                ilceCbx.Enabled = false;
                label1.Enabled = false;

            }
            else
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                sehirCbx.Enabled = true;
                sehirCbx.Items.Clear();
                label1.Enabled = true;
                ilceCbx.Enabled = true;
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
                ilceCbx.Enabled = true;
                sehirCbx.Items.Clear();
                ilceCbx.Items.Clear();
                sehirlerigetir();
                ilceTxt.Enabled = false;
                label19.Enabled = false;
                

            }
            else
            {
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
                ilceTxt.Enabled = true;
                label19.Enabled = true;
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
                ilceCbx.Enabled = true;
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

        private void sehirCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            SehirServisi ilceler = new SehirServisi();
            List<Ilceler> ilcelerim = ilceler.ilcegetir(((Sehir)(sehirCbx.SelectedItem)).Sehir_id);
            ilceCbx.Items.Clear();
            ilceCbx.Text = "";
            foreach (Ilceler ilcem in ilcelerim)
            {
                ilceCbx.Items.Add(ilcem);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
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
            else if (checkBox2.Checked == true)
            {
                Ilceler ilcm = (Ilceler)ilceCbx.SelectedItem;
                SehirServisi servis = new SehirServisi();
                servis.ilcesil(ilcm.Ilce_id);
                ilceCbx.Text = "";
                sehirCbx.Text = "";
                ilceCbx.Items.Clear();
                sehirCbx.Items.Clear();
                sehirlerigetir();
            }
            else if (checkBox3.Checked == true)
            {
                Ilceler ilc = (Ilceler)ilceCbx.SelectedItem;
                SehirServisi servisim = new SehirServisi();
                servisim.ilcedegistir(ilc.Ilce_id,ilceTxt.Text);
                ilceCbx.Text = "";
                sehirCbx.Text = "";
                ilceTxt.Text = "";
                ilceCbx.Items.Clear();
                sehirCbx.Items.Clear();
                sehirlerigetir();
                
            }
        }
    }
}
