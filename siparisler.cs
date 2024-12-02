using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stok
{
    public partial class siparisler : Form
    {
        public siparisler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6AO1SBA;Initial Catalog=arge_stok;Integrated Security=True");

        public void verilerigoster()
        {
            string query = "SELECT * FROM Siparisler"; 
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void siparisler_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde verileri göster
            verilerigoster();

            DatagridvievSetting(dataGridView1);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        public void DatagridvievSetting(DataGridView datagridview)
        {
            dataGridView1.ReadOnly = true;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //string aliciMail = "e.yanik@gentekelektronik.com";
            //string mailtoLink = "mailto:" + aliciMail;
            //Process.Start(mailtoLink);

            Siparisistekleri spistek = new Siparisistekleri();
            spistek.ShowDialog();
        }
    }
}
