﻿namespace Perpustakaan
{
    partial class Kategori
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataKategori = new System.Windows.Forms.DataGridView();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.kategoriBox = new System.Windows.Forms.TextBox();
            this.kodeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnPengembalian = new System.Windows.Forms.Button();
            this.btnPinjam = new System.Windows.Forms.Button();
            this.btnBuku = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKategori)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(-3, -2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(987, 60);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(276, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "KATEGORI BUKU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 112);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(987, 94);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.dataKategori);
            this.groupBox4.Controls.Add(this.btnHapus);
            this.groupBox4.Controls.Add(this.btnEdit);
            this.groupBox4.Controls.Add(this.btnTambah);
            this.groupBox4.Controls.Add(this.kategoriBox);
            this.groupBox4.Controls.Add(this.kodeBox);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(-1, 155);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(987, 401);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(807, 10);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 31);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(496, 47);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 22);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "CARI :";
            // 
            // dataKategori
            // 
            this.dataKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKategori.Location = new System.Drawing.Point(0, 75);
            this.dataKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataKategori.Name = "dataKategori";
            this.dataKategori.RowTemplate.Height = 24;
            this.dataKategori.Size = new System.Drawing.Size(981, 326);
            this.dataKategori.TabIndex = 7;
            this.dataKategori.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKategori_CellContentClick);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(685, 10);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(115, 31);
            this.btnHapus.TabIndex = 6;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(565, 10);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 31);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(444, 10);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(115, 31);
            this.btnTambah.TabIndex = 4;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // kategoriBox
            // 
            this.kategoriBox.Location = new System.Drawing.Point(157, 47);
            this.kategoriBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kategoriBox.Name = "kategoriBox";
            this.kategoriBox.Size = new System.Drawing.Size(263, 22);
            this.kategoriBox.TabIndex = 3;
            this.kategoriBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // kodeBox
            // 
            this.kodeBox.Location = new System.Drawing.Point(157, 10);
            this.kodeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kodeBox.Name = "kodeBox";
            this.kodeBox.Size = new System.Drawing.Size(263, 22);
            this.kodeBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "NAMA KATEGORI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "KODE KATEGORI";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.btnLogout);
            this.groupBox3.Controls.Add(this.btnHome);
            this.groupBox3.Controls.Add(this.btnLaporan);
            this.groupBox3.Controls.Add(this.btnPengembalian);
            this.groupBox3.Controls.Add(this.btnPinjam);
            this.groupBox3.Controls.Add(this.btnBuku);
            this.groupBox3.Controls.Add(this.btnMember);
            this.groupBox3.Controls.Add(this.btnKategori);
            this.groupBox3.Location = new System.Drawing.Point(-1, 57);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(987, 100);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(845, 57);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(115, 34);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(28, 14);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(115, 34);
            this.btnHome.TabIndex = 14;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // btnLaporan
            // 
            this.btnLaporan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLaporan.ForeColor = System.Drawing.Color.White;
            this.btnLaporan.Location = new System.Drawing.Point(845, 14);
            this.btnLaporan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(115, 34);
            this.btnLaporan.TabIndex = 13;
            this.btnLaporan.Text = "LAPORAN";
            this.btnLaporan.UseVisualStyleBackColor = false;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // btnPengembalian
            // 
            this.btnPengembalian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPengembalian.ForeColor = System.Drawing.Color.White;
            this.btnPengembalian.Location = new System.Drawing.Point(685, 14);
            this.btnPengembalian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPengembalian.Name = "btnPengembalian";
            this.btnPengembalian.Size = new System.Drawing.Size(139, 34);
            this.btnPengembalian.TabIndex = 12;
            this.btnPengembalian.Text = "PENGEMBALIAN";
            this.btnPengembalian.UseVisualStyleBackColor = false;
            this.btnPengembalian.Click += new System.EventHandler(this.btnPengembalian_Click);
            // 
            // btnPinjam
            // 
            this.btnPinjam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPinjam.ForeColor = System.Drawing.Color.White;
            this.btnPinjam.Location = new System.Drawing.Point(565, 14);
            this.btnPinjam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPinjam.Name = "btnPinjam";
            this.btnPinjam.Size = new System.Drawing.Size(115, 34);
            this.btnPinjam.TabIndex = 11;
            this.btnPinjam.Text = "PEMINJAMAN";
            this.btnPinjam.UseVisualStyleBackColor = false;
            this.btnPinjam.Click += new System.EventHandler(this.btnPinjam_Click);
            // 
            // btnBuku
            // 
            this.btnBuku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuku.ForeColor = System.Drawing.Color.White;
            this.btnBuku.Location = new System.Drawing.Point(293, 14);
            this.btnBuku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuku.Name = "btnBuku";
            this.btnBuku.Size = new System.Drawing.Size(115, 34);
            this.btnBuku.TabIndex = 10;
            this.btnBuku.Text = "BUKU";
            this.btnBuku.UseVisualStyleBackColor = false;
            this.btnBuku.Click += new System.EventHandler(this.btnBuku_Click_1);
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMember.ForeColor = System.Drawing.Color.White;
            this.btnMember.Location = new System.Drawing.Point(157, 14);
            this.btnMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(115, 34);
            this.btnMember.TabIndex = 9;
            this.btnMember.Text = "MEMBER";
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click_1);
            // 
            // btnKategori
            // 
            this.btnKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKategori.ForeColor = System.Drawing.Color.White;
            this.btnKategori.Location = new System.Drawing.Point(428, 14);
            this.btnKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(115, 34);
            this.btnKategori.TabIndex = 3;
            this.btnKategori.Text = "KATEGORI";
            this.btnKategori.UseVisualStyleBackColor = false;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // Kategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Kategori";
            this.Text = "Kategori";
            this.Load += new System.EventHandler(this.Kategori_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKategori)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnPengembalian;
        private System.Windows.Forms.Button btnPinjam;
        private System.Windows.Forms.Button btnBuku;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox kategoriBox;
        private System.Windows.Forms.TextBox kodeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dataKategori;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}