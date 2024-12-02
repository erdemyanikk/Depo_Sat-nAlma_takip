using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stok
{
    public partial class frmadmin : Form
    {
        private const string DogruKullaniciAdi = "admin";
        private const string DogruSifre = "a";
        public frmadmin()
        {
            InitializeComponent();
        }
       ControlPanel cp=new ControlPanel();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txgrs_TextChanged(object sender, EventArgs e)
        {

        }

        private void btgrs_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = txgrs.Text;
            string Sifre = txsifre.Text;

           
            if (DogruKullaniciAdi == KullaniciAdi && DogruSifre == Sifre)
            {
                //MessageBox.Show("Giriş başarılı!");
                
                this.Hide();
                cp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre. Lütfen tekrar deneyin.");
                
            }

        }

        private void frmadmin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btgrs;
            this.BackColor = Color.FromArgb(119, 136, 153);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btcks_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btgrs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btgrs.Focused)
            {
                btgrs.PerformClick();
            }
        }
    }
}
