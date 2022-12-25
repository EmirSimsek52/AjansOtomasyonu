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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AjansAutomation
{
    public partial class KayitGoster : Form
    {
        public KayitGoster()
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

        private void KayitGoster_Load(object sender, EventArgs e)
        {
            KayitListele(); 
        }

        public void KayitListele()
        {
            SqlConnection baglaniti = new SqlConnection(baglantiCumlesi);
            baglaniti.Open();
            string KomutCumlesi = "Select * From TabloKayit";
            SqlCommand komut = new SqlCommand(KomutCumlesi, baglaniti);
            SqlDataAdapter da= new SqlDataAdapter(komut);
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglaniti.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textAdSoyad.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoy.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textKilo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textYas.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textProjeler.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textAnlikProje.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textTc.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textTel.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textMail.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textAdres.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            oyuncuResim.ImageLocation = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutcumlesi = "Delete From TabloKayit where Tc='" + dataGridView1.CurrentRow.Cells["Tc"].Value.ToString() + "'";
            SqlCommand komut = new SqlCommand(komutcumlesi, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            KayitListele();
            MessageBox.Show("Kayit Silindi");

        }

        private void textAdAra_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutcumlesi = "Select * From  TabloKayit where AdSoyad like '" + textAdAra.Text + "%'";
            SqlCommand komut = new SqlCommand(komutcumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void textTcAra_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutcumlesi = "Select * From  TabloKayit where Tc like '" + textTcAra.Text + "%'";
            SqlCommand komut = new SqlCommand(komutcumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutcumlesi = "Update TabloKayit set AdSoyad=@AdSoyad ,Boy=@Boy ,Kilo=@Kilo,Yas=@Yas,EskiProjeler=@EskiProjeler,AnlikProje=@AnlikProje,Tc=@Tc,Tel=@Tel,Mail=@Mail,Adres=@Adres,Resim=@Resim Where Tc=@Tc";
            SqlCommand komut= new SqlCommand(komutcumlesi, baglanti);
            komut.Parameters.AddWithValue("@AdSoyad", textAdSoyad.Text);
            komut.Parameters.AddWithValue("@Boy", textBoy.Text);
            komut.Parameters.AddWithValue("@Kilo", textKilo.Text);
            komut.Parameters.AddWithValue("@Yas", textYas.Text);
            komut.Parameters.AddWithValue("@EskiProjeler", textProjeler.Text);
            komut.Parameters.AddWithValue("@AnlikProje", textAnlikProje.Text);
            komut.Parameters.AddWithValue("@Tc",textTc.Text);
            komut.Parameters.AddWithValue("@Tel", textTel.Text);
            komut.Parameters.AddWithValue("@Mail", textMail.Text);
            komut.Parameters.AddWithValue("@Adres", textAdres.Text);
            komut.Parameters.AddWithValue("@Resim", oyuncuResim.ImageLocation);
            komut.ExecuteNonQuery();
            baglanti.Close();
            KayitListele();
            MessageBox.Show("Kayit Güncellendi");
        }

        private void btnResimGüncelle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            oyuncuResim.ImageLocation = openFileDialog1.FileName;
        }
    }
}
