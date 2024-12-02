namespace stok
{
    partial class ControlPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.datacontrol = new System.Windows.Forms.DataGridView();
            this.cnknm = new System.Windows.Forms.TextBox();
            this.cndgr = new System.Windows.Forms.TextBox();
            this.cnürnk = new System.Windows.Forms.TextBox();
            this.lkonum = new System.Windows.Forms.Label();
            this.ldeger = new System.Windows.Forms.Label();
            this.lürnkd = new System.Windows.Forms.Label();
            this.cnpkt = new System.Windows.Forms.TextBox();
            this.lpket = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnara = new System.Windows.Forms.Button();
            this.lmiktar = new System.Windows.Forms.Label();
            this.cnmiktar = new System.Windows.Forms.TextBox();
            this.cnsil = new System.Windows.Forms.TextBox();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.siparisbutton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datacontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datacontrol
            // 
            this.datacontrol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datacontrol.Location = new System.Drawing.Point(18, 194);
            this.datacontrol.Name = "datacontrol";
            this.datacontrol.Size = new System.Drawing.Size(894, 429);
            this.datacontrol.TabIndex = 0;
            this.datacontrol.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datacontrol_CellClick);
            this.datacontrol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datacontrol_CellContentClick);
            // 
            // cnknm
            // 
            this.cnknm.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cnknm.Location = new System.Drawing.Point(87, 24);
            this.cnknm.Name = "cnknm";
            this.cnknm.Size = new System.Drawing.Size(100, 20);
            this.cnknm.TabIndex = 1;
            // 
            // cndgr
            // 
            this.cndgr.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cndgr.Location = new System.Drawing.Point(87, 59);
            this.cndgr.Name = "cndgr";
            this.cndgr.Size = new System.Drawing.Size(100, 20);
            this.cndgr.TabIndex = 2;
            // 
            // cnürnk
            // 
            this.cnürnk.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cnürnk.Location = new System.Drawing.Point(87, 88);
            this.cnürnk.Name = "cnürnk";
            this.cnürnk.Size = new System.Drawing.Size(100, 20);
            this.cnürnk.TabIndex = 3;
            // 
            // lkonum
            // 
            this.lkonum.AutoSize = true;
            this.lkonum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lkonum.Location = new System.Drawing.Point(14, 25);
            this.lkonum.Name = "lkonum";
            this.lkonum.Size = new System.Drawing.Size(57, 19);
            this.lkonum.TabIndex = 5;
            this.lkonum.Text = "Konum";
            this.lkonum.Click += new System.EventHandler(this.label1_Click);
            // 
            // ldeger
            // 
            this.ldeger.AutoSize = true;
            this.ldeger.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ldeger.Location = new System.Drawing.Point(14, 60);
            this.ldeger.Name = "ldeger";
            this.ldeger.Size = new System.Drawing.Size(51, 19);
            this.ldeger.TabIndex = 6;
            this.ldeger.Text = "Değer";
            // 
            // lürnkd
            // 
            this.lürnkd.AutoSize = true;
            this.lürnkd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lürnkd.Location = new System.Drawing.Point(-1, 89);
            this.lürnkd.Name = "lürnkd";
            this.lürnkd.Size = new System.Drawing.Size(82, 19);
            this.lürnkd.TabIndex = 7;
            this.lürnkd.Text = "Ürün Kodu";
            // 
            // cnpkt
            // 
            this.cnpkt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cnpkt.Location = new System.Drawing.Point(87, 123);
            this.cnpkt.Name = "cnpkt";
            this.cnpkt.Size = new System.Drawing.Size(100, 20);
            this.cnpkt.TabIndex = 4;
            // 
            // lpket
            // 
            this.lpket.AutoSize = true;
            this.lpket.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lpket.Location = new System.Drawing.Point(14, 124);
            this.lpket.Name = "lpket";
            this.lpket.Size = new System.Drawing.Size(48, 19);
            this.lpket.TabIndex = 8;
            this.lpket.Text = "Paket";
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnekle.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(208, 24);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(94, 45);
            this.btnekle.TabIndex = 9;
            this.btnekle.Text = "Ekle";
            this.btnekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsil.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(812, 152);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(100, 29);
            this.btnsil.TabIndex = 10;
            this.btnsil.Text = "Sil";
            this.btnsil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnara.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnara.Location = new System.Drawing.Point(208, 126);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(94, 45);
            this.btnara.TabIndex = 11;
            this.btnara.Text = "Ara";
            this.btnara.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.button3_Click);
            // 
            // lmiktar
            // 
            this.lmiktar.AutoSize = true;
            this.lmiktar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lmiktar.Location = new System.Drawing.Point(14, 152);
            this.lmiktar.Name = "lmiktar";
            this.lmiktar.Size = new System.Drawing.Size(57, 19);
            this.lmiktar.TabIndex = 13;
            this.lmiktar.Text = "Miktar";
            this.lmiktar.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cnmiktar
            // 
            this.cnmiktar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cnmiktar.Location = new System.Drawing.Point(87, 151);
            this.cnmiktar.Name = "cnmiktar";
            this.cnmiktar.Size = new System.Drawing.Size(100, 20);
            this.cnmiktar.TabIndex = 14;
            // 
            // cnsil
            // 
            this.cnsil.ForeColor = System.Drawing.Color.Black;
            this.cnsil.Location = new System.Drawing.Point(812, 126);
            this.cnsil.Name = "cnsil";
            this.cnsil.Size = new System.Drawing.Size(100, 20);
            this.cnsil.TabIndex = 15;
            this.cnsil.Text = "Silenecek Konum";
            this.cnsil.TextChanged += new System.EventHandler(this.cnsil_TextChanged);
            this.cnsil.Enter += new System.EventHandler(this.cnsil_Enter);
            this.cnsil.Leave += new System.EventHandler(this.cnsil_Leave);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDuzenle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.Location = new System.Drawing.Point(208, 75);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(94, 45);
            this.btnDuzenle.TabIndex = 16;
            this.btnDuzenle.Text = "Güncelle";
            this.btnDuzenle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // siparisbutton
            // 
            this.siparisbutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.siparisbutton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparisbutton.Location = new System.Drawing.Point(812, 11);
            this.siparisbutton.Name = "siparisbutton";
            this.siparisbutton.Size = new System.Drawing.Size(94, 45);
            this.siparisbutton.TabIndex = 20;
            this.siparisbutton.Text = "Siparişler";
            this.siparisbutton.UseVisualStyleBackColor = false;
            this.siparisbutton.Click += new System.EventHandler(this.siparisbutton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox3.Image = global::stok.Properties.Resources.bin;
            this.pictureBox3.Location = new System.Drawing.Point(882, 153);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Image = global::stok.Properties.Resources.recycling;
            this.pictureBox2.Location = new System.Drawing.Point(270, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Image = global::stok.Properties.Resources.plus;
            this.pictureBox1.Location = new System.Drawing.Point(269, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(924, 635);
            this.Controls.Add(this.siparisbutton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.cnsil);
            this.Controls.Add(this.cnmiktar);
            this.Controls.Add(this.lmiktar);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.lpket);
            this.Controls.Add(this.lürnkd);
            this.Controls.Add(this.ldeger);
            this.Controls.Add(this.lkonum);
            this.Controls.Add(this.cnpkt);
            this.Controls.Add(this.cnürnk);
            this.Controls.Add(this.cndgr);
            this.Controls.Add(this.cnknm);
            this.Controls.Add(this.datacontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlPanel";
            this.Load += new System.EventHandler(this.ControlPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datacontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datacontrol;
        private System.Windows.Forms.TextBox cnknm;
        private System.Windows.Forms.TextBox cndgr;
        private System.Windows.Forms.TextBox cnürnk;
        private System.Windows.Forms.Label lkonum;
        private System.Windows.Forms.Label ldeger;
        private System.Windows.Forms.Label lürnkd;
        private System.Windows.Forms.TextBox cnpkt;
        private System.Windows.Forms.Label lpket;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Label lmiktar;
        private System.Windows.Forms.TextBox cnmiktar;
        private System.Windows.Forms.TextBox cnsil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button siparisbutton;
    }
}