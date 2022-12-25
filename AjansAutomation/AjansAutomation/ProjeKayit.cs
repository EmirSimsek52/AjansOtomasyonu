using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AjansAutomation
{
    public partial class ProjeKayit : Form
    {
        public ProjeKayit()
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

        private void ProjeKayit_Load(object sender, EventArgs e)
        {


        }

        private void btnAfisEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureAfis.ImageLocation = openFileDialog1.FileName;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Insert Into Projeler(ProjeAd,ProjeTur,Butce,OyuncuKadro,Konu,Resim) Values(@ProjeAd,@ProjeTur,@Butce,@OyuncuKadro,@Konu,@Resim)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@ProjeAd", textProjeadi.Text);
            komut.Parameters.AddWithValue("@ProjeTur", comboTur.Text);
            komut.Parameters.AddWithValue("@Butce",textButce.Text);
            komut.Parameters.AddWithValue("@OyuncuKadro",textOyuncular.Text);
            komut.Parameters.AddWithValue("@Konu", textKonu.Text);
            komut.Parameters.AddWithValue("@Resim", pictureAfis.ImageLocation);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayit Eklendi");
        }

        private void textOyuncular_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
