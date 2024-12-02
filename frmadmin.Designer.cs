namespace stok
{
    partial class frmadmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txgrs = new System.Windows.Forms.TextBox();
            this.txsifre = new System.Windows.Forms.TextBox();
            this.btgrs = new System.Windows.Forms.Button();
            this.btcks = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(64, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(64, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txgrs
            // 
            this.txgrs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txgrs.Location = new System.Drawing.Point(67, 61);
            this.txgrs.Name = "txgrs";
            this.txgrs.Size = new System.Drawing.Size(162, 13);
            this.txgrs.TabIndex = 2;
            this.txgrs.TextChanged += new System.EventHandler(this.txgrs_TextChanged);
            // 
            // txsifre
            // 
            this.txsifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txsifre.Location = new System.Drawing.Point(67, 124);
            this.txsifre.Name = "txsifre";
            this.txsifre.Size = new System.Drawing.Size(162, 13);
            this.txsifre.TabIndex = 3;
            this.txsifre.UseSystemPasswordChar = true;
            // 
            // btgrs
            // 
            this.btgrs.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btgrs.Location = new System.Drawing.Point(153, 184);
            this.btgrs.Name = "btgrs";
            this.btgrs.Size = new System.Drawing.Size(76, 32);
            this.btgrs.TabIndex = 4;
            this.btgrs.Text = "Giriş";
            this.btgrs.UseVisualStyleBackColor = true;
            this.btgrs.Click += new System.EventHandler(this.btgrs_Click);
            this.btgrs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btgrs_KeyDown);
            // 
            // btcks
            // 
            this.btcks.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btcks.Location = new System.Drawing.Point(67, 184);
            this.btcks.Name = "btcks";
            this.btcks.Size = new System.Drawing.Size(76, 32);
            this.btcks.TabIndex = 7;
            this.btcks.Text = "Çıkış";
            this.btcks.UseVisualStyleBackColor = true;
            this.btcks.Click += new System.EventHandler(this.btcks_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::stok.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(16, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::stok.Properties.Resources.friends;
            this.pictureBox1.Location = new System.Drawing.Point(16, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(245, 249);
            this.Controls.Add(this.btcks);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btgrs);
            this.Controls.Add(this.txsifre);
            this.Controls.Add(this.txgrs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.frmadmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txgrs;
        private System.Windows.Forms.TextBox txsifre;
        private System.Windows.Forms.Button btgrs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btcks;
    }
}