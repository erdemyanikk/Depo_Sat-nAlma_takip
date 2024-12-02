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
    public partial class animasyon : Form
    {
        public animasyon()
        {
            InitializeComponent();
        }

        bool islem = false;
        private void animasyon_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!islem)
            {
                this.Opacity += 0.009;
            }
            if (this.Opacity == 1.0)
            {
                islem = true;
            }
            if (islem)
            {
                this.Opacity -= 0.009;
                if (this.Opacity == 0)
                {
                    Girisfrm grs = new Girisfrm();
                    grs.Show();
                    timer1.Enabled = false;
                }
            }

        
        }
    }
}
