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

namespace stok
{
    public partial class Siparisistekleri : Form
    {
        public Siparisistekleri()
        {
            InitializeComponent();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            
            
                // TextBox'lardan girişleri al
                string urunAdi = UrunAdiTextBox.Text;
                string musteriKodu = MusteriKoduTextBox.Text;
                string projeAdi = ProjeAdiTextBox.Text;
                string url = URLTextBox.Text;
                int adet = Convert.ToInt32(AdetTextBox.Text); // Sayı olarak alındığını varsayıyoruz

                // SQL sorgusunu hazırla
                string sqlSorgu = "INSERT INTO siparis_istekleri (UrunAdi, MusteriKodu, ProjeAdi, URL, Adet) VALUES (@urunAdi, @musteriKodu, @projeAdi, @url, @adet)";

            // Bağlantıyı oluştur
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6AO1SBA;Initial Catalog=arge_stok;Integrated Security=True");


            // Komut ve parametreleri oluştur
            SqlCommand komut = new SqlCommand(sqlSorgu, baglanti);
                komut.Parameters.AddWithValue("@urunAdi", urunAdi);
                komut.Parameters.AddWithValue("@musteriKodu", musteriKodu);
                komut.Parameters.AddWithValue("@projeAdi", projeAdi);
                komut.Parameters.AddWithValue("@url", url);
                komut.Parameters.AddWithValue("@adet", adet);

                try
                {
                    // Bağlantıyı aç
                    baglanti.Open();
                    // Komutu çalıştır
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Bağlantıyı kapat
                    baglanti.Close();
                }
            

        }

        private void Siparisistekleri_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
