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
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6AO1SBA;Initial Catalog=arge_stok;Integrated Security=True");

        public void controlveri(string veriler)
        {
            baglanti.Open();
            Console.WriteLine(veriler);
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            datacontrol.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            controlveri("Select * from stok");
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM stok  ", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "stok");
            datacontrol.DataSource = ds.Tables["stok"];
            baglanti.Close();
        }

        private void btngnc_Click(object sender, EventArgs e)
        {
            //baglanti.Open();
            //try
            //{
            //    SqlCommand cmd = new SqlCommand("UPDATE stok SET Konum = @konum, Deger = @deger, Paket = @paket, Miktar = @miktar WHERE UrunKodu = @urunkodu", baglanti);
            //    cmd.Parameters.AddWithValue("@konum", cnknm);
            //    cmd.Parameters.AddWithValue("@deger", cndgr);
            //    cmd.Parameters.AddWithValue("@urunkodu", cnürnk);
            //    cmd.Parameters.AddWithValue("@paket", cnpkt);
            //    cmd.Parameters.AddWithValue("@miktar", cnmiktar);

            //    cmd.ExecuteNonQuery();

            //    
            //    controlveri("SELECT * FROM stok");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Hata oluştu: " + ex.Message);
            //}
            //finally
            //{
            //    baglanti.Close();
            //}
          
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(cnsil.Text))
            {
                MessageBox.Show("Lütfen silinecek ürünün konumunu girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                baglanti.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM stok WHERE Konum = @konum", baglanti);
                cmd.Parameters.AddWithValue("@konum", cnsil.Text.Trim()); // Trim() kullanarak baştaki ve sondaki boşlukları kaldırır

               
                int affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen silinecek ürünün konumunu girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
                controlveri("SELECT * FROM stok");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            cnsil.Clear();

            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM stok  ", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "stok");
            datacontrol.DataSource = ds.Tables["stok"];
            baglanti.Close();

            //***************************************
            //baglanti.Open();
            //try
            //{
            //    SqlCommand cmd = new SqlCommand("DELETE FROM stok WHERE Konum = @konum" , baglanti);
            //    cmd.Parameters.AddWithValue("@konum", cnsil.Text.ToString());
            //    cmd.ExecuteNonQuery();
            //    controlveri("SELECT * FROM stok");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Hata oluştu: " + ex.Message);
            //}
            //finally
            //{
            //    baglanti.Close();
            //}

            //cnsil.Clear();

            //baglanti.Open();
            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM stok  ", baglanti);
            //DataSet ds = new DataSet();
            //da.Fill(ds, "stok");
            //datacontrol.DataSource = ds.Tables["stok"];
            //baglanti.Close();
            //****************************************************


            //cnsil.Clear();
            ///
            //string konum = cnknm.Text; // Silinecek kaydın konum bilgisini al
            //string deger = cndgr.Text; // Silinecek kaydın değer bilgisini al
            //string urunKodu = cnürnk.Text; // Silinecek kaydın ürün kodu bilgisini al
            //string paket = cnpkt.Text; // Silinecek kaydın paket bilgisini al
            //string miktar = cnmiktar.Text; // Silinecek kaydın miktar bilgisini al

            //baglanti.Open();
            //try
            //{
            //    SqlCommand cmd = new SqlCommand("DELETE FROM stok WHERE Konum = @konum OR Deger = @deger OR UrunKodu = @urunkodu OR Paket = @paket OR Miktar = @miktar", baglanti);
            //    cmd.Parameters.AddWithValue("@konum", konum);
            //    cmd.Parameters.AddWithValue("@deger", deger);
            //    cmd.Parameters.AddWithValue("@urunkodu", urunKodu);
            //    cmd.Parameters.AddWithValue("@paket", paket);
            //    cmd.Parameters.AddWithValue("@miktar", miktar);
            //    cmd.ExecuteNonQuery();
            //    controlveri("SELECT * FROM stok");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Hata oluştu: " + ex.Message);
            //}
            //finally
            //{
            //    baglanti.Close();
            //}




        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(cnknm.Text) ||
            string.IsNullOrWhiteSpace(cndgr.Text) ||
            string.IsNullOrWhiteSpace(cnürnk.Text) ||
            string.IsNullOrWhiteSpace(cnmiktar.Text) ||
            string.IsNullOrWhiteSpace(cnpkt.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6AO1SBA;Initial Catalog=arge_stok;Integrated Security=True");

                try
                {
                    baglanti.Open();

                 
                    SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM stok WHERE Konum = @konum OR UrunKodu = @urunkodu", baglanti);
                    checkCommand.Parameters.AddWithValue("@konum", cnknm.Text);
                    checkCommand.Parameters.AddWithValue("@urunkodu", cnürnk.Text);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Bu konum veya ürün kodu zaten kullanılmış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO stok (Konum, Deger, UrunKodu, Paket, Miktar) VALUES (@konum, @deger, @urunkodu, @paket, @miktar)", baglanti);

                     
                        cmd.Parameters.AddWithValue("@konum", cnknm.Text);
                        cmd.Parameters.AddWithValue("@deger", cndgr.Text);
                        cmd.Parameters.AddWithValue("@urunkodu", cnürnk.Text);
                        cmd.Parameters.AddWithValue("@paket", cnpkt.Text);
                        cmd.Parameters.AddWithValue("@miktar", cnmiktar.Text);

                        cmd.ExecuteNonQuery();

                        controlveri("SELECT * FROM stok");

                        
                        MessageBox.Show("Kayıt başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata oluştu: " + ex.Message);
                    MessageBox.Show("Kayıt eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    baglanti.Close();

                    
                    cnknm.Clear();
                    cndgr.Clear();
                    cnürnk.Clear();
                    cnmiktar.Clear();
                    cnpkt.Clear();
                }
            }





        }

        private void datacontrol_CellClick(object sender, DataGridViewCellEventArgs e)

        {
            //int control = datacontrol.SelectedCells[0].RowIndex;
            //string Konum = datacontrol.Rows[control].Cells["KonumSutunuAdi"].Value.ToString();
            //string Deger = datacontrol.Rows[control].Cells["DegerSutunuAdi"].Value.ToString();
            //string UrunKodu = datacontrol.Rows[control].Cells["UrunKoduSutunuAdi"].Value.ToString();
            //string Paket = datacontrol.Rows[control].Cells["PaketSutunuAdi"].Value.ToString();
            //int Miktar = Convert.ToInt32(datacontrol.Rows[control].Cells["MiktarSutunuAdi"].Value);
            //char harf = Konum[0];
            //int sayi = int.Parse(Konum.Substring(1));
            //cnknm.Text = harf.ToString();
            //cndgr.Text = sayi.ToString();
            ////cnknm.Text = Konum;
            //cndgr.Text = Deger;
            //cnürnk.Text = UrunKodu;
            //cnpkt.Text = Paket;
            //cnmiktar.Text = Miktar.ToString();
            //baglanti.Close();
            



        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(119, 136, 153);
            DatagridvievSetting(datacontrol);
            datacontrol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datacontrol.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void cnsil_TextChanged(object sender, EventArgs e)
        {

        }

        private void cnsil_Enter(object sender, EventArgs e)
        {

            if (cnsil.Text == "Silenecek Konum")
            {
                cnsil.Text = "";

                cnsil.ForeColor = Color.Black;
            }
        }

        private void cnsil_Leave(object sender, EventArgs e)
        {

            if (cnsil.Text == "")
            {
                cnsil.Text = "Silenecek Konum";

                cnsil.ForeColor = Color.Black;
            }

        }

        private void cnsil_Leave_1(object sender, EventArgs e)
        {

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            // Seçilen bir kaydın olup olmadığını kontrol et
            if (datacontrol.SelectedRows.Count > 0)
            {
                // Seçilen satırın indeksini al
                int selectedRowIndex = datacontrol.SelectedRows[0].Index;

                // Seçilen satırın verilerini al
                string konum = datacontrol.Rows[selectedRowIndex].Cells["Konum"].Value.ToString();
                string deger = datacontrol.Rows[selectedRowIndex].Cells["Deger"].Value.ToString();
                string urunkodu = datacontrol.Rows[selectedRowIndex].Cells["UrunKodu"].Value.ToString();
                string paket = datacontrol.Rows[selectedRowIndex].Cells["Paket"].Value.ToString();
                string miktar = datacontrol.Rows[selectedRowIndex].Cells["Miktar"].Value.ToString();

                // Verileri ilgili textbox'lara yazdır
                cnknm.Text = konum;
                cndgr.Text = deger;
                cnürnk.Text = urunkodu;
                cnpkt.Text = paket;
                cnmiktar.Text = miktar;

                // TextBox'ları düzenleme yapmak için etkinleştir
                cnknm.Enabled = true;
                cndgr.Enabled = true;
                cnürnk.Enabled = true;
                cnpkt.Enabled = true;
                cnmiktar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek için bir kayıt seçin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Düzenleme yapıldıysa
            if (cnknm.Enabled)
            {
                // Veritabanında güncelleme yap
                baglanti.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE stok SET Konum = @konum, Deger = @deger, UrunKodu = @urunkodu, Paket = @paket, Miktar = @miktar WHERE Konum = @konum", baglanti);

                    cmd.Parameters.AddWithValue("@konum", cnknm.Text);
                    cmd.Parameters.AddWithValue("@deger", cndgr.Text);
                    cmd.Parameters.AddWithValue("@urunkodu", cnürnk.Text);
                    cmd.Parameters.AddWithValue("@paket", cnpkt.Text);
                    cmd.Parameters.AddWithValue("@miktar", cnmiktar.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Kayıt başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata oluştu: " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }

                // TextBox'ları temizle
                cnknm.Clear();
                cndgr.Clear();
                cnürnk.Clear();
                cnmiktar.Clear();
                cnpkt.Clear();

                // Veritabanındaki verileri yeniden yükle
                controlveri("SELECT * FROM stok");
            }
            else
            {
                MessageBox.Show("Düzenleme yapmak için önce bir kayıt seçmelisiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void DatagridvievSetting(DataGridView datagridview)
        {
          
            datagridview.RowHeadersVisible = false;
            datagridview.BorderStyle = BorderStyle.None;
            datagridview.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray; // Sıralı satırların arka plan rengi
            datagridview.DefaultCellStyle.SelectionForeColor = Color.FromArgb(35, 35, 35); // Seçili hücrelerin metin rengi
            datagridview.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue; // Seçili hücrelerin arka plan rengi (açık mavi)
            datagridview.EnableHeadersVisualStyles = false;
            datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            datagridview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40); // Kolon başlıklarının arka plan rengi (koyu gri)
            datagridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Kolon başlıklarının metin rengi (beyaz)
            datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
            private void datacontrol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void siparisbutton_Click(object sender, EventArgs e)
        {

            contolsiparis consip = new contolsiparis();
            consip.ShowDialog();
        }
    }
}
