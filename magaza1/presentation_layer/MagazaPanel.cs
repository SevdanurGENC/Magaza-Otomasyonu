using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using magaza1.domain_layer;
using magaza1.service_layer;

namespace magaza1.presentation_layer
{
    public partial class MagazaPanel : Form
    {
        int magazaidal;

        public MagazaPanel(int mgzid)
        {
            InitializeComponent(); 
            this.magazaidal = mgzid;
            textBox1.Text = mgzid.ToString();
            kategorilerimigetir();
        }

        public MagazaPanel()
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
                kategoCbx.Items.Add(ktgr);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SiparisServis servisim = new SiparisServis();
            Kategori ktg=(Kategori)kategoCbx.SelectedItem;
            Urun urn=(Urun)urunCbx.SelectedItem;
            DateTime dt = DateTime.Now;
            servisim.siparisekle(ktg.Kategori_id, magazaidal, urn.Urun_id, Convert.ToInt32(adetTxt.Text), dt);
            kategoCbx.Text = "";
            urunCbx.Text = "";
            adetTxt.Text = "";
            kategoCbx.Items.Clear();
            kategorilerimigetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kategoCbx.Text=="") { MessageBox.Show("Kategori Seçilmemiş"); }
            else
            {
                UrunServis servis = new UrunServis(); //düzgün çalışmıyor...
                List<Urun> magazaUrunleri = servis.siparisgonder(((Kategori)kategoCbx.SelectedItem).Kategori_id);
                dataGridView1.DataSource = magazaUrunleri;
            }
        }

        private void MagazaPanel_Click(object sender, EventArgs e)
        {

        }

        private void MagazaPanel_DoubleClick(object sender, EventArgs e)
        {
           
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kategoCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrunServis kateler = new UrunServis();
            List<Urun> urunum = kateler.urungetir(((Kategori)(kategoCbx.SelectedItem)).Kategori_id);
            urunCbx.Items.Clear();
            foreach (Urun urunm in urunum)
            {
                urunCbx.Items.Add(urunm);
            }
        }

        private void MagazaPanel_Load(object sender, EventArgs e)
        {
            
        }
    }
}
