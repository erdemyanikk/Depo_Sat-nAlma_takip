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
    public partial class frmstok : Form
    {
        public frmstok()
        {
            InitializeComponent();
        }
        //SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-6AO1SBA;Initial Catalog=arge_stok;Integrated Security=True;Trust Server Certificate=True");
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6AO1SBA;Initial Catalog=arge_stok;Integrated Security=True");

        public void verilerigoster(string veriler)
        {
            baglanti.Open();
            Console.WriteLine(veriler);
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglanti.Close();
        }
        private void frmstok_Load(object sender, EventArgs e)
        {
            Height = Screen.PrimaryScreen.WorkingArea.Height - 30;
            //  this.BackColor = Color.FromArgb(119, 136, 153);
            DatagridvievSetting(dataGridView1);
            // DataGridView'i tam olarak doldur
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btürünlisteleme_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            try
            {

                // SQL sorgusunu hazırlama
                string query = "SELECT * FROM stok WHERE Deger LIKE @deger";

                //if (!string.IsNullOrEmpty(txürünkodu.Text))
                //    query += " AND UrunKodu = @urunKodu";


                //if (!string.IsNullOrEmpty(txpaket.Text))
                //    query += " AND PaketID = @paketID";
              //  **********************************

                if (!string.IsNullOrEmpty(txürünkodu.Text) && string.IsNullOrEmpty(txpaket.Text) && string.IsNullOrEmpty(txddeger.Text))
                    query += " AND UrunKodu = @urunKodu";


                if (!string.IsNullOrEmpty(txpaket.Text) && string.IsNullOrEmpty(txürünkodu.Text) && string.IsNullOrEmpty(txddeger.Text))
                    query += " AND Paket = @paket";


                if (!string.IsNullOrEmpty(txddeger.Text) && string.IsNullOrEmpty(txürünkodu.Text) && string.IsNullOrEmpty(txpaket.Text))
                    query += " AND Deger LIKE @deger";



                SqlDataAdapter da = new SqlDataAdapter(query, baglanti);
                da.SelectCommand.Parameters.AddWithValue("@deger", "%" + txddeger.Text + "%");


                if (!string.IsNullOrEmpty(txürünkodu.Text))
                    da.SelectCommand.Parameters.AddWithValue("@urunKodu", txürünkodu.Text);


                if (!string.IsNullOrEmpty(txpaket.Text))
                    da.SelectCommand.Parameters.AddWithValue("@paket", txpaket.Text);


                DataSet ds = new DataSet();
                da.Fill(ds, "stok");


                dataGridView1.DataSource = ds.Tables["stok"];
            }

            //baglanti.Close();
            catch (SqlException ex)
            {
                MessageBox.Show("Doğru de " + ex.Message);
            }
            finally
            {

                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }

        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //{
            //    frmadmin btadmin = new frmadmin();
            //    btadmin.ShowDialog();

            //}
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void DatagridvievSetting(DataGridView datagridview)
        {
            //dataGridView1.RowHeadersVisible = false;
            //datagridview.BorderStyle = BorderStyle.None;
            //datagridview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            //datagridview.DefaultCellStyle.SelectionForeColor = Color.FromArgb(45, 45, 45);
            //datagridview.DefaultCellStyle.SelectionForeColor = Color.White;
            //datagridview.EnableHeadersVisualStyles = false;
            //datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //datagridview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            //datagridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //***************
            //datagridview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            //datagridview.DefaultCellStyle.SelectionForeColor = Color.FromArgb(45, 45, 45);
            //datagridview.DefaultCellStyle.SelectionBackColor = Color.White;
            //datagridview.EnableHeadersVisualStyles = false;
            //datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //datagridview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            //datagridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //***********************
            //datagridview.RowHeadersVisible = false;
            //datagridview.BorderStyle = BorderStyle.None;
            //datagridview.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray; // Sıralı satırların arka plan rengi
            //datagridview.DefaultCellStyle.SelectionForeColor = Color.Black; // Seçili hücrelerin metin rengi
            //datagridview.DefaultCellStyle.SelectionBackColor = Color.FromArgb(35, 35, 35); // Seçili hücrelerin arka plan rengi (açık mavi)
            //datagridview.EnableHeadersVisualStyles = false;
            //datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //datagridview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40); // Kolon başlıklarının arka plan rengi (koyu gri)
            //datagridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Kolon başlıklarının metin rengi (beyaz)
            //datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //********************
            datagridview.RowHeadersVisible = false;
            datagridview.BorderStyle = BorderStyle.None;
            datagridview.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray; // Sıralı satırların arka plan rengi
            datagridview.DefaultCellStyle.SelectionForeColor = Color.FromArgb(35, 35, 35); // Seçili hücrelerin metin rengi
            datagridview.DefaultCellStyle.SelectionBackColor = Color.DarkGray; // Seçili hücrelerin arka plan rengi (açık mavi)
            datagridview.EnableHeadersVisualStyles = false;
            datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            datagridview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40); // Kolon başlıklarının arka plan rengi (koyu gri)
            datagridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Kolon başlıklarının metin rengi (beyaz)
            datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
