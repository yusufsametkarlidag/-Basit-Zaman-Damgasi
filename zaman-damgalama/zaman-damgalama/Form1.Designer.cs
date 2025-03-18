namespace zaman_damgalama
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnZamanDamgasiEkle = new Button();
            dgvZamanDamgalari = new DataGridView();
            zamanDamgasiColumn = new DataGridViewTextBoxColumn();
            btnZamanDamgasiSil = new Button();
            btnTumunuTemizle = new Button();
            txtAra = new TextBox();
            lblAra = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvZamanDamgalari).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnZamanDamgasiEkle
            // 
            btnZamanDamgasiEkle.BackColor = Color.FromArgb(128, 255, 128);
            btnZamanDamgasiEkle.Location = new Point(10, 254);
            btnZamanDamgasiEkle.Name = "btnZamanDamgasiEkle";
            btnZamanDamgasiEkle.Size = new Size(150, 29);
            btnZamanDamgasiEkle.TabIndex = 0;
            btnZamanDamgasiEkle.Text = "Zaman Damgası Ekle";
            btnZamanDamgasiEkle.UseVisualStyleBackColor = false;
            btnZamanDamgasiEkle.Click += btnZamanDamgasiEkle_Click;
            // 
            // dgvZamanDamgalari
            // 
            dgvZamanDamgalari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvZamanDamgalari.Columns.AddRange(new DataGridViewColumn[] { zamanDamgasiColumn });
            dgvZamanDamgalari.Location = new Point(10, 86);
            dgvZamanDamgalari.Name = "dgvZamanDamgalari";
            dgvZamanDamgalari.RowHeadersWidth = 51;
            dgvZamanDamgalari.Size = new Size(300, 162);
            dgvZamanDamgalari.TabIndex = 1;
            // 
            // zamanDamgasiColumn
            // 
            zamanDamgasiColumn.HeaderText = "Zaman Damgası";
            zamanDamgasiColumn.MinimumWidth = 6;
            zamanDamgasiColumn.Name = "zamanDamgasiColumn";
            zamanDamgasiColumn.Width = 250;
            // 
            // btnZamanDamgasiSil
            // 
            btnZamanDamgasiSil.BackColor = Color.FromArgb(255, 128, 128);
            btnZamanDamgasiSil.Location = new Point(166, 254);
            btnZamanDamgasiSil.Name = "btnZamanDamgasiSil";
            btnZamanDamgasiSil.Size = new Size(150, 29);
            btnZamanDamgasiSil.TabIndex = 2;
            btnZamanDamgasiSil.Text = "Zaman Damgası Sil";
            btnZamanDamgasiSil.UseVisualStyleBackColor = false;
            btnZamanDamgasiSil.Click += btnZamanDamgasiSil_Click;
            // 
            // btnTumunuTemizle
            // 
            btnTumunuTemizle.BackColor = Color.Red;
            btnTumunuTemizle.Location = new Point(77, 305);
            btnTumunuTemizle.Name = "btnTumunuTemizle";
            btnTumunuTemizle.Size = new Size(150, 29);
            btnTumunuTemizle.TabIndex = 3;
            btnTumunuTemizle.Text = "Tümünü Temizle";
            btnTumunuTemizle.UseVisualStyleBackColor = false;
            btnTumunuTemizle.Click += btnTumunuTemizle_Click;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(10, 53);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(300, 27);
            txtAra.TabIndex = 4;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // lblAra
            // 
            lblAra.AutoSize = true;
            lblAra.Font = new Font("Stencil", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAra.Location = new Point(12, 17);
            lblAra.Name = "lblAra";
            lblAra.Size = new Size(82, 33);
            lblAra.TabIndex = 5;
            lblAra.Text = "Ara:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 340);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lblAra);
            Controls.Add(txtAra);
            Controls.Add(btnTumunuTemizle);
            Controls.Add(btnZamanDamgasiSil);
            Controls.Add(dgvZamanDamgalari);
            Controls.Add(btnZamanDamgasiEkle);
            Name = "Form1";
            Text = "Zaman Damgası Uygulaması";
            ((System.ComponentModel.ISupportInitialize)dgvZamanDamgalari).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnZamanDamgasiEkle;
        private System.Windows.Forms.DataGridView dgvZamanDamgalari;
        private System.Windows.Forms.Button btnZamanDamgasiSil;
        private System.Windows.Forms.Button btnTumunuTemizle;
        private System.Windows.Forms.DataGridViewTextBoxColumn zamanDamgasiColumn;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label lblAra;
        private PictureBox pictureBox1;
    }
}