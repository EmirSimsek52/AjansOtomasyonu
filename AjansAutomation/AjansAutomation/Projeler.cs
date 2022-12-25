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
    public partial class Projeler : Form
    {
        public Projeler()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = "Data Source=.\\SQLEXPRESS;Initial Catalog=Ajans;Integrated Security=True";
        private void pictureExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAfisGuncelle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureAfis.ImageLocation = openFileDialog1.FileName;
        }
        public void ProjeGoster()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string KomutCumlesi = "Select * From Projeler";
            SqlCommand komut = new SqlCommand(KomutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void Projeler_Load(object sender, EventArgs e)
        {
            ProjeGoster();
        }

        private void textAdAra_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutcumlesi = "Select * From  Projeler where ProjeAd like '" + textAdAra.Text + "%'";
            SqlCommand komut = new SqlCommand(komutcumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textProjeadi.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboTur.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textButce.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textOyuncular.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textKonu.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            pictureAfis.ImageLocation= dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutcumlesi = "Delete From Projeler where ProjeAd='" + dataGridView1.CurrentRow.Cells["ProjeAd"].Value.ToString() + "'";
            SqlCommand komut = new SqlCommand(komutcumlesi, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            ProjeGoster();
            MessageBox.Show("Kayit Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutcumlesi = "Update Projeler set ProjeAd=@ProjeAd ,ProjeTur=@ProjeTur ,Butce=@Butce,OyuncuKadro=@OyuncuKadro,Konu=@Konu,Resim=@Resim Where ProjeAd=@ProjeAd";
            SqlCommand komut = new SqlCommand(komutcumlesi, baglanti);
            komut.Parameters.AddWithValue("@ProjeAd", textProjeadi.Text);
            komut.Parameters.AddWithValue("@ProjeTur", comboTur.Text);
            komut.Parameters.AddWithValue("@Butce", textButce.Text);
            komut.Parameters.AddWithValue("@OyuncuKadro", textOyuncular.Text);
            komut.Parameters.AddWithValue("@Konu", textKonu.Text);
            komut.Parameters.AddWithValue("@Resim", pictureAfis.ImageLocation);
            komut.ExecuteNonQuery();
            baglanti.Close();
            ProjeGoster();
            MessageBox.Show("Kayit Güncellendi");
        }
    }
}

