namespace Perpustakaan
{
    partial class Buku
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kategoriBox = new System.Windows.Forms.ComboBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.stokBox = new System.Windows.Forms.TextBox();
            this.judulBox = new System.Windows.Forms.TextBox();
            this.bukuBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataBuku = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnPengembalian = new System.Windows.Forms.Button();
            this.btnPinjam = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnBuku = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBuku)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(-2, -2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(740, 48);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(152, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "BUKU PERPUSTAKAAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 91);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(740, 76);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.txtCari);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.kategoriBox);
            this.groupBox4.Controls.Add(this.btnHapus);
            this.groupBox4.Controls.Add(this.btnEdit);
            this.groupBox4.Controls.Add(this.btnTambah);
            this.groupBox4.Controls.Add(this.stokBox);
            this.groupBox4.Controls.Add(this.judulBox);
            this.groupBox4.Controls.Add(this.bukuBox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.dataBuku);
            this.groupBox4.Location = new System.Drawing.Point(-1, 127);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(740, 325);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(440, 7);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 25);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(634, 75);
            this.txtCari.Margin = new System.Windows.Forms.Padding(2);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(96, 20);
            this.txtCari.TabIndex = 14;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "CARI :";
            // 
            // kategoriBox
            // 
            this.kategoriBox.FormattingEnabled = true;
            this.kategoriBox.Location = new System.Drawing.Point(118, 52);
            this.kategoriBox.Margin = new System.Windows.Forms.Padding(2);
            this.kategoriBox.Name = "kategoriBox";
            this.kategoriBox.Size = new System.Drawing.Size(194, 21);
            this.kategoriBox.TabIndex = 12;
            this.kategoriBox.SelectedIndexChanged += new System.EventHandler(this.kategoriBox_SelectedIndexChanged);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(349, 67);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(86, 25);
            this.btnHapus.TabIndex = 11;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(349, 37);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 25);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(349, 6);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(2);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(86, 25);
            this.btnTambah.TabIndex = 9;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // stokBox
            // 
            this.stokBox.Location = new System.Drawing.Point(118, 75);
            this.stokBox.Margin = new System.Windows.Forms.Padding(2);
            this.stokBox.Name = "stokBox";
            this.stokBox.Size = new System.Drawing.Size(194, 20);
            this.stokBox.TabIndex = 8;
            // 
            // judulBox
            // 
            this.judulBox.Location = new System.Drawing.Point(118, 28);
            this.judulBox.Margin = new System.Windows.Forms.Padding(2);
            this.judulBox.Name = "judulBox";
            this.judulBox.Size = new System.Drawing.Size(194, 20);
            this.judulBox.TabIndex = 6;
            // 
            // bukuBox
            // 
            this.bukuBox.Location = new System.Drawing.Point(118, 5);
            this.bukuBox.Margin = new System.Windows.Forms.Padding(2);
            this.bukuBox.Name = "bukuBox";
            this.bukuBox.Size = new System.Drawing.Size(194, 20);
            this.bukuBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "STOK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "KATEGORI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "JUDUL BUKU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "KODE BUKU";
            // 
            // dataBuku
            // 
            this.dataBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBuku.Location = new System.Drawing.Point(4, 98);
            this.dataBuku.Margin = new System.Windows.Forms.Padding(2);
            this.dataBuku.Name = "dataBuku";
            this.dataBuku.RowTemplate.Height = 24;
            this.dataBuku.Size = new System.Drawing.Size(730, 223);
            this.dataBuku.TabIndex = 0;
            this.dataBuku.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBuku_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.btnLogout);
            this.groupBox3.Controls.Add(this.btnHome);
            this.groupBox3.Controls.Add(this.btnLaporan);
            this.groupBox3.Controls.Add(this.btnPengembalian);
            this.groupBox3.Controls.Add(this.btnPinjam);
            this.groupBox3.Controls.Add(this.btnKategori);
            this.groupBox3.Controls.Add(this.btnMember);
            this.groupBox3.Controls.Add(this.btnBuku);
            this.groupBox3.Location = new System.Drawing.Point(-1, 46);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(740, 81);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(634, 48);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(86, 28);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(21, 12);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(86, 28);
            this.btnHome.TabIndex = 14;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // btnLaporan
            // 
            this.btnLaporan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLaporan.ForeColor = System.Drawing.Color.White;
            this.btnLaporan.Location = new System.Drawing.Point(634, 13);
            this.btnLaporan.Margin = new System.Windows.Forms.Padding(2);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(86, 28);
            this.btnLaporan.TabIndex = 13;
            this.btnLaporan.Text = "LAPORAN";
            this.btnLaporan.UseVisualStyleBackColor = false;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // btnPengembalian
            // 
            this.btnPengembalian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPengembalian.ForeColor = System.Drawing.Color.White;
            this.btnPengembalian.Location = new System.Drawing.Point(514, 13);
            this.btnPengembalian.Margin = new System.Windows.Forms.Padding(2);
            this.btnPengembalian.Name = "btnPengembalian";
            this.btnPengembalian.Size = new System.Drawing.Size(104, 28);
            this.btnPengembalian.TabIndex = 12;
            this.btnPengembalian.Text = "PENGEMBALIAN";
            this.btnPengembalian.UseVisualStyleBackColor = false;
            this.btnPengembalian.Click += new System.EventHandler(this.btnPengembalian_Click);
            // 
            // btnPinjam
            // 
            this.btnPinjam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPinjam.ForeColor = System.Drawing.Color.White;
            this.btnPinjam.Location = new System.Drawing.Point(424, 13);
            this.btnPinjam.Margin = new System.Windows.Forms.Padding(2);
            this.btnPinjam.Name = "btnPinjam";
            this.btnPinjam.Size = new System.Drawing.Size(86, 28);
            this.btnPinjam.TabIndex = 11;
            this.btnPinjam.Text = "PEMINJAMAN";
            this.btnPinjam.UseVisualStyleBackColor = false;
            this.btnPinjam.Click += new System.EventHandler(this.btnPinjam_Click);
            // 
            // btnKategori
            // 
            this.btnKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKategori.ForeColor = System.Drawing.Color.White;
            this.btnKategori.Location = new System.Drawing.Point(322, 12);
            this.btnKategori.Margin = new System.Windows.Forms.Padding(2);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(86, 28);
            this.btnKategori.TabIndex = 10;
            this.btnKategori.Text = "KATEGORI";
            this.btnKategori.UseVisualStyleBackColor = false;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click_1);
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMember.ForeColor = System.Drawing.Color.White;
            this.btnMember.Location = new System.Drawing.Point(118, 13);
            this.btnMember.Margin = new System.Windows.Forms.Padding(2);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(86, 28);
            this.btnMember.TabIndex = 9;
            this.btnMember.Text = "MEMBER";
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click_1);
            // 
            // btnBuku
            // 
            this.btnBuku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuku.ForeColor = System.Drawing.Color.White;
            this.btnBuku.Location = new System.Drawing.Point(219, 12);
            this.btnBuku.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuku.Name = "btnBuku";
            this.btnBuku.Size = new System.Drawing.Size(86, 28);
            this.btnBuku.TabIndex = 2;
            this.btnBuku.Text = "BUKU";
            this.btnBuku.UseVisualStyleBackColor = false;
            this.btnBuku.Click += new System.EventHandler(this.btnBuku_Click);
            // 
            // Buku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Buku";
            this.Text = "Buku";
            this.Load += new System.EventHandler(this.Buku_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBuku)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuku;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnPengembalian;
        private System.Windows.Forms.Button btnPinjam;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataBuku;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stokBox;
        private System.Windows.Forms.TextBox judulBox;
        private System.Windows.Forms.TextBox bukuBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox kategoriBox;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReset;
    }
}