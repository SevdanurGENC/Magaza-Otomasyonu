using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using magaza1.presentation_layer;
namespace magaza1
{
    public partial class MerkezPanel : Form
    {
        public MerkezPanel()
        {
            InitializeComponent();
        }

        private void mağazaKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MagazaSave mgz = new MagazaSave();
            mgz.Show();
        }

        private void kategoriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriUpdate ktgr = new KategoriUpdate();
            ktgr.ShowDialog();
        }

        private void şehirGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SehirUpdate shr = new SehirUpdate();
            shr.ShowDialog();
        }

        private void ilçeGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IlceUpdate ilc = new IlceUpdate();
            ilc.ShowDialog();
        }

        private void bedenGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BedenUpdate().ShowDialog();
            
        }

        private void cinsiyetBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CinsiyetBilgileri().ShowDialog();
        }

        private void renkGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RenkUpdate().ShowDialog();
        }

        private void ürünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UrunKayit().ShowDialog();
        }

        private void mağazaSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MagazaSil().ShowDialog();
        }

        private void mağazaGüncellermeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           new MagazaGuncelleme().ShowDialog();
           
        }

        private void ürünSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UrunSil().ShowDialog();
        }

        private void ürünDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UrunGuncelle().ShowDialog();
        }

        private void tümMağazalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new YetkiPanel().ShowDialog();
        }
    }
}
