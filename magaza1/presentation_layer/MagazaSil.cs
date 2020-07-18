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
    public partial class MagazaSil : Form
    {
        public MagazaSil()
        {
            InitializeComponent();
            sehirlerigetir();
            ilceCbx.Enabled = false;
            mgzadCbx.Enabled = false;
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SehirServisi ilceler = new SehirServisi();
            List<Ilceler> ilcelerim = ilceler.ilcegetir(((Sehir)(sehirCbx.SelectedItem)).Sehir_id);
            ilceCbx.Enabled = true;
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
            mgzadCbx.Enabled = true;
            mgzadCbx.Items.Clear();
            foreach (Magaza mgz in magazam)
            {
                mgzadCbx.Items.Add(mgz);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MerkezServisi mgzsil = new MerkezServisi();
            Magaza magzam = (Magaza)mgzadCbx.SelectedItem;
            mgzsil.magazasilme(magzam.Magaza_id);
            sehirCbx.Items.Clear();
            ilceCbx.Items.Clear();
            mgzadCbx.Items.Clear();
            sehirCbx.Text = "";
            ilceCbx.Text = "";
            mgzadCbx.Text = "";
            ilceCbx.Enabled = false;
            mgzadCbx.Enabled = false;
            sehirlerigetir();
        }
    }
}
