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
    public partial class MagazaSave : Form
    {
        public MagazaSave()
        {
            InitializeComponent();
            sehirlerigetir();
            yetkilerigetir();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sehir ilim = (Sehir)milCbx.SelectedItem;
            Ilceler ilcem = (Ilceler)milceCbx.SelectedItem;
            Yetkiler ytkler = (Yetkiler)yetkiCbx.SelectedItem;
            magazasifreTxt.MaxLength = 5;
            MerkezServisi magazakaydet = new MerkezServisi();
            magazakaydet.magazaekle(magazaadTxt.Text, Convert.ToInt32(magazasifreTxt.Text),iltsmTxt.Text, ilim.Sehir_id, ilcem.Ilce_id,ytkler.Yetki_id);
            milCbx.Text = "";
            milceCbx.Text = "";
            magazasifreTxt.Text="";
            magazaadTxt.Text = "";
            iltsmTxt.Text = "";
        }
        private void sehirlerigetir()
        {
            SehirServisi sehirgetir = new SehirServisi();
            List<Sehir> sehirlerim = sehirgetir.sehirlerimigetir();
            foreach (Sehir shr in sehirlerim)
            {
                milCbx.Items.Add(shr);
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

        private void milCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            SehirServisi ilceler = new SehirServisi();
            List<Ilceler> ilcelerim = ilceler.ilcegetir(((Sehir)(milCbx.SelectedItem)).Sehir_id);
            milceCbx.Items.Clear();
            milceCbx.Text = "";
            foreach (Ilceler ilcem in ilcelerim)
            {
                milceCbx.Items.Add(ilcem);
            }
        }
    }
}
