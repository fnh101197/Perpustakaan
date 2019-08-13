namespace Perpustakaan
{
    partial class Peminjaman
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.dtpKembali = new System.Windows.Forms.DateTimePicker();
            this.dtpPinjam = new System.Windows.Forms.DateTimePicker();
            this.dataPinjam = new System.Windows.Forms.DataGridView();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.lamaView = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.judulView = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.teleponView = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.namaView = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.kdpinjamView = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bukuBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idMemberBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kdpinjamBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnPengembalian = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnBuku = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnPinjam = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPinjam)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtCari);
            this.groupBox4.Controls.Add(this.dtpKembali);
            this.groupBox4.Controls.Add(this.dtpPinjam);
            this.groupBox4.Controls.Add(this.dataPinjam);
            this.groupBox4.Controls.Add(this.btnHapus);
            this.groupBox4.Controls.Add(this.btnEdit);
            this.groupBox4.Controls.Add(this.btnTambah);
            this.groupBox4.Controls.Add(this.lamaView);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.judulView);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.teleponView);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.namaView);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.kdpinjamView);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.bukuBox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.idMemberBox);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.kdpinjamBox);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(-1, 158);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(987, 399);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(792, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "CARI :";
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(845, 163);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(126, 22);
            this.txtCari.TabIndex = 30;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // dtpKembali
            // 
            this.dtpKembali.CustomFormat = "yyyy-MM-dd";
            this.dtpKembali.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKembali.Location = new System.Drawing.Point(191, 129);
            this.dtpKembali.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpKembali.Name = "dtpKembali";
            this.dtpKembali.Size = new System.Drawing.Size(112, 22);
            this.dtpKembali.TabIndex = 29;
            this.dtpKembali.ValueChanged += new System.EventHandler(this.dtpKembali_ValueChanged_1);
            // 
            // dtpPinjam
            // 
            this.dtpPinjam.CustomFormat = "yyyy-MM-dd";
            this.dtpPinjam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPinjam.Location = new System.Drawing.Point(191, 100);
            this.dtpPinjam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpPinjam.Name = "dtpPinjam";
            this.dtpPinjam.Size = new System.Drawing.Size(112, 22);
            this.dtpPinjam.TabIndex = 28;
            this.dtpPinjam.ValueChanged += new System.EventHandler(this.dtpPinjam_ValueChanged_1);
            // 
            // dataPinjam
            // 
            this.dataPinjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPinjam.Location = new System.Drawing.Point(5, 190);
            this.dataPinjam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataPinjam.Name = "dataPinjam";
            this.dataPinjam.RowTemplate.Height = 24;
            this.dataPinjam.Size = new System.Drawing.Size(973, 203);
            this.dataPinjam.TabIndex = 27;
            this.dataPinjam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPinjam_CellContentClick);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(856, 89);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(115, 31);
            this.btnHapus.TabIndex = 26;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(856, 52);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 31);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(856, 15);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(115, 31);
            this.btnTambah.TabIndex = 24;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // lamaView
            // 
            this.lamaView.Enabled = false;
            this.lamaView.Location = new System.Drawing.Point(613, 129);
            this.lamaView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lamaView.Name = "lamaView";
            this.lamaView.Size = new System.Drawing.Size(100, 22);
            this.lamaView.TabIndex = 23;
            this.lamaView.TextChanged += new System.EventHandler(this.lamaView_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(451, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "LAMA PINJAM";
            // 
            // judulView
            // 
            this.judulView.Enabled = false;
            this.judulView.Location = new System.Drawing.Point(613, 101);
            this.judulView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.judulView.Name = "judulView";
            this.judulView.Size = new System.Drawing.Size(227, 22);
            this.judulView.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "JUDUL BUKU";
            // 
            // teleponView
            // 
            this.teleponView.Enabled = false;
            this.teleponView.Location = new System.Drawing.Point(613, 73);
            this.teleponView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teleponView.Name = "teleponView";
            this.teleponView.Size = new System.Drawing.Size(227, 22);
            this.teleponView.TabIndex = 19;
            this.teleponView.TextChanged += new System.EventHandler(this.teleponView_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(451, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "TELEPON";
            // 
            // namaView
            // 
            this.namaView.Enabled = false;
            this.namaView.Location = new System.Drawing.Point(613, 46);
            this.namaView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namaView.Name = "namaView";
            this.namaView.Size = new System.Drawing.Size(227, 22);
            this.namaView.TabIndex = 17;
            this.namaView.TextChanged += new System.EventHandler(this.namaView_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(451, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "NAMA PEMINJAM";
            // 
            // kdpinjamView
            // 
            this.kdpinjamView.Enabled = false;
            this.kdpinjamView.Location = new System.Drawing.Point(613, 17);
            this.kdpinjamView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kdpinjamView.Name = "kdpinjamView";
            this.kdpinjamView.Size = new System.Drawing.Size(227, 22);
            this.kdpinjamView.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(451, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "KODE PINJAM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "TAMNGGAL KEMBALI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "TANGGAL PINJAM";
            // 
            // bukuBox
            // 
            this.bukuBox.Location = new System.Drawing.Point(191, 73);
            this.bukuBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bukuBox.Name = "bukuBox";
            this.bukuBox.Size = new System.Drawing.Size(227, 22);
            this.bukuBox.TabIndex = 5;
            this.bukuBox.TextChanged += new System.EventHandler(this.bukuBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "KODE BUKU";
            // 
            // idMemberBox
            // 
            this.idMemberBox.Location = new System.Drawing.Point(191, 46);
            this.idMemberBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idMemberBox.Name = "idMemberBox";
            this.idMemberBox.Size = new System.Drawing.Size(227, 22);
            this.idMemberBox.TabIndex = 3;
            this.idMemberBox.TextChanged += new System.EventHandler(this.idMemberBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID MEMBER";
            // 
            // kdpinjamBox
            // 
            this.kdpinjamBox.Location = new System.Drawing.Point(191, 17);
            this.kdpinjamBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kdpinjamBox.Name = "kdpinjamBox";
            this.kdpinjamBox.Size = new System.Drawing.Size(227, 22);
            this.kdpinjamBox.TabIndex = 1;
            this.kdpinjamBox.TextChanged += new System.EventHandler(this.kdpinjamBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "KODE PINJAM";
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
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(241, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "PEMINJAMAN BUKU";
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.btnLogout);
            this.groupBox3.Controls.Add(this.btnHome);
            this.groupBox3.Controls.Add(this.btnLaporan);
            this.groupBox3.Controls.Add(this.btnPengembalian);
            this.groupBox3.Controls.Add(this.btnKategori);
            this.groupBox3.Controls.Add(this.btnBuku);
            this.groupBox3.Controls.Add(this.btnMember);
            this.groupBox3.Controls.Add(this.btnPinjam);
            this.groupBox3.Location = new System.Drawing.Point(-1, 57);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(987, 100);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(845, 59);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(115, 34);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(28, 15);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(115, 34);
            this.btnHome.TabIndex = 14;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLaporan.ForeColor = System.Drawing.Color.White;
            this.btnLaporan.Location = new System.Drawing.Point(845, 16);
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
            this.btnPengembalian.Location = new System.Drawing.Point(683, 16);
            this.btnPengembalian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPengembalian.Name = "btnPengembalian";
            this.btnPengembalian.Size = new System.Drawing.Size(141, 34);
            this.btnPengembalian.TabIndex = 12;
            this.btnPengembalian.Text = "PENGEMBALIAN";
            this.btnPengembalian.UseVisualStyleBackColor = false;
            this.btnPengembalian.Click += new System.EventHandler(this.btnPengembalian_Click);
            // 
            // btnKategori
            // 
            this.btnKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKategori.ForeColor = System.Drawing.Color.White;
            this.btnKategori.Location = new System.Drawing.Point(429, 15);
            this.btnKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(115, 34);
            this.btnKategori.TabIndex = 11;
            this.btnKategori.Text = "KATEGORI";
            this.btnKategori.UseVisualStyleBackColor = false;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnBuku
            // 
            this.btnBuku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuku.ForeColor = System.Drawing.Color.White;
            this.btnBuku.Location = new System.Drawing.Point(293, 16);
            this.btnBuku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuku.Name = "btnBuku";
            this.btnBuku.Size = new System.Drawing.Size(115, 34);
            this.btnBuku.TabIndex = 10;
            this.btnBuku.Text = "BUKU";
            this.btnBuku.UseVisualStyleBackColor = false;
            this.btnBuku.Click += new System.EventHandler(this.btnBuku_Click);
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMember.ForeColor = System.Drawing.Color.White;
            this.btnMember.Location = new System.Drawing.Point(157, 16);
            this.btnMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(115, 34);
            this.btnMember.TabIndex = 9;
            this.btnMember.Text = "MEMBER";
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnPinjam
            // 
            this.btnPinjam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPinjam.ForeColor = System.Drawing.Color.White;
            this.btnPinjam.Location = new System.Drawing.Point(563, 15);
            this.btnPinjam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPinjam.Name = "btnPinjam";
            this.btnPinjam.Size = new System.Drawing.Size(115, 34);
            this.btnPinjam.TabIndex = 4;
            this.btnPinjam.Text = "PEMINJAMAN";
            this.btnPinjam.UseVisualStyleBackColor = false;
            this.btnPinjam.Click += new System.EventHandler(this.btnPinjam_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(856, 124);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 31);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Peminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 553);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Peminjaman";
            this.Text = "Peminjaman";
            this.Load += new System.EventHandler(this.Peminjaman_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPinjam)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnPengembalian;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnBuku;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnPinjam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bukuBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idMemberBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kdpinjamBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lamaView;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox judulView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox teleponView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox namaView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox kdpinjamView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataPinjam;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.DateTimePicker dtpKembali;
        private System.Windows.Forms.DateTimePicker dtpPinjam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnReset;
    }
}