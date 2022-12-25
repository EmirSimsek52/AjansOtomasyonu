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
using System.Runtime.InteropServices;

namespace AjansAutomation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = "Data Source=.\\SQLEXPRESS;Initial Catalog=Ajans;Integrated Security=True";
        private void txtKullaniciAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {   
           
            if (txtKullaniciAd.Text == "" || txtSifre.Text=="")
            {
                MessageBox.Show("Kullanici adi veya şifre giriniz!");
            }
            else
            {
                SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
                baglanti.Open();
                string komutCumlesi = "Select * from UsersTablo where ADSOYAD=@ADSOYAD AND Sifre=@Sifre";
                SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
                komut.Parameters.AddWithValue("@ADSOYAD", txtKullaniciAd.Text);
                komut.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                SqlDataReader rd= komut.ExecuteReader();
                if (rd.Read())
                {
                    AnaSayfa anaSayfa = new AnaSayfa();
                    anaSayfa.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Hatali Giriş");
                }

            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                txtSifre.UseSystemPasswordChar = true;
                checkBox1.Text = "Sifreyi Göster";
            }else if(checkBox1.CheckState == CheckState.Unchecked)
            {
                txtSifre.UseSystemPasswordChar= false;
                checkBox1.Text = "Sifreyi Gizle";
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
