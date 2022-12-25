using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AjansAutomation
{
    public partial class KayitEkle : Form
    {
        public KayitEkle()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = "Data Source=.\\SQLEXPRESS;Initial Catalog=Ajans;Integrated Security=True";
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            oyuncuResim.ImageLocation = openFileDialog1.FileName;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Insert Into TabloKayit(AdSoyad,Boy,Kilo,Yas,EskiProjeler,AnlikProje,Tc,Tel,Mail,Adres,Resim) Values(@AdSoyad,@Boy,@Kilo,@Yas,@EskiProjeler,@AnlikProje,@Tc,@Tel,@Mail,@Adres,@Resim)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@AdSoyad", textAdSoyad.Text);
            komut.Parameters.AddWithValue("@Boy", textBoy.Text);
            komut.Parameters.AddWithValue("@Kilo", textKilo.Text);
            komut.Parameters.AddWithValue("@Yas", textYas.Text);
            komut.Parameters.AddWithValue("EskiProjeler", textProjeler.Text);
            komut.Parameters.AddWithValue("@AnlikProje", textAnlikProje.Text);
            komut.Parameters.AddWithValue("@Tc", textTc.Text);
            komut.Parameters.AddWithValue("@Tel", textTel.Text);
            komut.Parameters.AddWithValue("@Mail", textMail.Text);
            komut.Parameters.AddWithValue("@Adres", textAdres.Text);
            komut.Parameters.AddWithValue("@Resim", oyuncuResim.ImageLocation);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayit Eklendi");
        }
    }
}