using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AjansAutomation
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            KayitEkle kayitEkle = new KayitEkle();
            kayitEkle.Show();
        }

        private void pictureKayit_Click(object sender, EventArgs e)
        {
            KayitEkle kayitEkle = new KayitEkle();
            kayitEkle.Show();
        }

        private void picturekayitgör_Click(object sender, EventArgs e)
        {
            KayitGoster kayitGoster = new KayitGoster();
            kayitGoster.Show();
        }

        private void btnkayitgör_Click(object sender, EventArgs e)
        {
            KayitGoster kayitGoster = new KayitGoster();
            kayitGoster.Show();
        }

        private void btnProjeEkle_Click(object sender, EventArgs e)
        {
            ProjeKayit projeKayit = new ProjeKayit();
            projeKayit.Show();
        }

        private void pictureProjeEkle_Click(object sender, EventArgs e)
        {
            ProjeKayit projeKayit = new ProjeKayit();
            projeKayit.Show();
        }

        private void btnProjeler_Click(object sender, EventArgs e)
        {
            Projeler projeler = new Projeler();
            projeler.Show();
        }

        private void pictureProjeler_Click(object sender, EventArgs e)
        {
            Projeler projeler = new Projeler();
            projeler.Show();
        }
    }
}
