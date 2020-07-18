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
    public partial class UrunSil : Form
    {
        public UrunSil()
        {
            InitializeComponent();
            kategorilerimigetir();
            
        }
        private void kategorilerimigetir()
        {
            UrunServis kategoriservis = new UrunServis();
            List<Kategori> kategorilerim = kategoriservis.kategorigetir();

            foreach (Kategori ktgr in kategorilerim)
            {
                ktgrCbx.Items.Add(ktgr);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrunServis kateler = new UrunServis();
            List<Urun> urunum = kateler.urungetir(((Kategori)(ktgrCbx.SelectedItem)).Kategori_id);            
            urunCbx.Items.Clear();
            foreach (Urun urunm in urunum)
            {
                urunCbx.Items.Add(urunm);
            }

        }

        private void urunCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunServis urunsilme = new UrunServis();
            Urun urn = (Urun)urunCbx.SelectedItem;
            urunsilme.silurun(urn.Urun_id);
            ktgrCbx.Text = "";
            urunCbx.Text = "";
            ktgrCbx.Items.Clear();
            urunCbx.Items.Clear();
            kategorilerimigetir();

        }
       
    }
}
