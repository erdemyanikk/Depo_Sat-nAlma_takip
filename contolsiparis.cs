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
    public partial class contolsiparis : Form
    {
        public contolsiparis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6AO1SBA;Initial Catalog=arge_stok;Integrated Security=True");
        public void controlveri(string veriler)
        {
            try
            {
                baglanti.Open();
                Console.WriteLine(veriler);
                SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Verileri getirirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        

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
            private void contolsiparis_Load(object sender, EventArgs e)
        {
            DatagridvievSetting(dataGridView1);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            controlveri("SELECT * FROM siparis_istekleri");
        }
    }
}
