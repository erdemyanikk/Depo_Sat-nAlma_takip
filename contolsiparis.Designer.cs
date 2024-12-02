namespace stok
{
    partial class contolsiparis
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guncellebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(127, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(624, 388);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // guncellebtn
            // 
            this.guncellebtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.guncellebtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncellebtn.Location = new System.Drawing.Point(12, 377);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.Size = new System.Drawing.Size(94, 45);
            this.guncellebtn.TabIndex = 17;
            this.guncellebtn.Text = "Güncelle";
            this.guncellebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guncellebtn.UseVisualStyleBackColor = false;
            this.guncellebtn.Click += new System.EventHandler(this.guncellebtn_Click);
            // 
            // contolsiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.guncellebtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "contolsiparis";
            this.Text = "contolsiparis";
            this.Load += new System.EventHandler(this.contolsiparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button guncellebtn;
    }
}