namespace stok
{
    partial class frmstok
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txkonum = new System.Windows.Forms.TextBox();
            this.txddeger = new System.Windows.Forms.TextBox();
            this.txürünkodu = new System.Windows.Forms.TextBox();
            this.txpaket = new System.Windows.Forms.TextBox();
            this.btürünlisteleme = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.elipseControl1 = new stok.ElipseControl();
            this.elipseControl2 = new stok.ElipseControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Konum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(279, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Değer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(514, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ürün Kodu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(802, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Paket";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txkonum
            // 
            this.txkonum.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txkonum.Location = new System.Drawing.Point(82, 122);
            this.txkonum.Margin = new System.Windows.Forms.Padding(4);
            this.txkonum.Name = "txkonum";
            this.txkonum.Size = new System.Drawing.Size(148, 24);
            this.txkonum.TabIndex = 6;
            // 
            // txddeger
            // 
            this.txddeger.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txddeger.Location = new System.Drawing.Point(336, 122);
            this.txddeger.Margin = new System.Windows.Forms.Padding(4);
            this.txddeger.Name = "txddeger";
            this.txddeger.Size = new System.Drawing.Size(148, 24);
            this.txddeger.TabIndex = 7;
            // 
            // txürünkodu
            // 
            this.txürünkodu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txürünkodu.Location = new System.Drawing.Point(593, 122);
            this.txürünkodu.Margin = new System.Windows.Forms.Padding(4);
            this.txürünkodu.Name = "txürünkodu";
            this.txürünkodu.Size = new System.Drawing.Size(148, 24);
            this.txürünkodu.TabIndex = 8;
            // 
            // txpaket
            // 
            this.txpaket.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txpaket.Location = new System.Drawing.Point(856, 122);
            this.txpaket.Margin = new System.Windows.Forms.Padding(4);
            this.txpaket.Name = "txpaket";
            this.txpaket.Size = new System.Drawing.Size(148, 24);
            this.txpaket.TabIndex = 9;
            // 
            // btürünlisteleme
            // 
            this.btürünlisteleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btürünlisteleme.ForeColor = System.Drawing.Color.Black;
            this.btürünlisteleme.Location = new System.Drawing.Point(951, 162);
            this.btürünlisteleme.Margin = new System.Windows.Forms.Padding(4);
            this.btürünlisteleme.Name = "btürünlisteleme";
            this.btürünlisteleme.Size = new System.Drawing.Size(111, 44);
            this.btürünlisteleme.TabIndex = 10;
            this.btürünlisteleme.Text = "Ara";
            this.btürünlisteleme.UseVisualStyleBackColor = true;
            this.btürünlisteleme.Click += new System.EventHandler(this.btürünlisteleme_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(28, 215);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 528);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 30);
            this.panel1.TabIndex = 15;
            this.panel1.Tag = "";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Image = global::stok.Properties.Resources.close__1_1;
            this.pictureBox4.Location = new System.Drawing.Point(1052, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 15;
            this.elipseControl1.TargetControl = this.btürünlisteleme;
            // 
            // elipseControl2
            // 
            this.elipseControl2.CornerRadius = 30;
            this.elipseControl2.TargetControl = this.pictureBox4;
            // 
            // frmstok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btürünlisteleme);
            this.Controls.Add(this.txpaket);
            this.Controls.Add(this.txürünkodu);
            this.Controls.Add(this.txddeger);
            this.Controls.Add(this.txkonum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmstok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listeleme";
            this.Load += new System.EventHandler(this.frmstok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txkonum;
        private System.Windows.Forms.TextBox txddeger;
        private System.Windows.Forms.TextBox txürünkodu;
        private System.Windows.Forms.TextBox txpaket;
        private System.Windows.Forms.Button btürünlisteleme;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ElipseControl elipseControl1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private ElipseControl elipseControl2;
        private System.Windows.Forms.Panel panel1;
    }
}