namespace Perpustakaan
{
    partial class Member
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
            this.btnHapus = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.alamatBox = new System.Windows.Forms.TextBox();
            this.telpBox = new System.Windows.Forms.TextBox();
            this.namaBox = new System.Windows.Forms.TextBox();
            this.idMemberBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataMember = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnPengembalian = new System.Windows.Forms.Button();
            this.btnPinjam = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnBuku = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.cariBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).BeginInit();
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
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(163, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "MEMBER PERPUSTAKAAN";
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
            this.groupBox4.Controls.Add(this.cariBox);
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.btnHapus);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.btnEdit);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.alamatBox);
            this.groupBox4.Controls.Add(this.telpBox);
            this.groupBox4.Controls.Add(this.namaBox);
            this.groupBox4.Controls.Add(this.idMemberBox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.dataMember);
            this.groupBox4.Location = new System.Drawing.Point(-1, 155);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(987, 401);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(587, 10);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 31);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(465, 82);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(115, 31);
            this.btnHapus.TabIndex = 11;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(792, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "CARI :";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(465, 46);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 31);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "TAMBAH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // alamatBox
            // 
            this.alamatBox.Location = new System.Drawing.Point(171, 94);
            this.alamatBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alamatBox.Name = "alamatBox";
            this.alamatBox.Size = new System.Drawing.Size(255, 22);
            this.alamatBox.TabIndex = 8;
            // 
            // telpBox
            // 
            this.telpBox.Location = new System.Drawing.Point(171, 66);
            this.telpBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telpBox.Name = "telpBox";
            this.telpBox.Size = new System.Drawing.Size(255, 22);
            this.telpBox.TabIndex = 7;
            // 
            // namaBox
            // 
            this.namaBox.Location = new System.Drawing.Point(171, 38);
            this.namaBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namaBox.Name = "namaBox";
            this.namaBox.Size = new System.Drawing.Size(255, 22);
            this.namaBox.TabIndex = 6;
            this.namaBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // idMemberBox
            // 
            this.idMemberBox.Location = new System.Drawing.Point(171, 10);
            this.idMemberBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idMemberBox.Name = "idMemberBox";
            this.idMemberBox.Size = new System.Drawing.Size(255, 22);
            this.idMemberBox.TabIndex = 5;
            this.idMemberBox.TextChanged += new System.EventHandler(this.idMemberBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "ALAMAT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "NO. TELEPON";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAMA LENGKAP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID_MEMBER ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataMember
            // 
            this.dataMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMember.Location = new System.Drawing.Point(-1, 122);
            this.dataMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataMember.Name = "dataMember";
            this.dataMember.RowTemplate.Height = 24;
            this.dataMember.Size = new System.Drawing.Size(987, 279);
            this.dataMember.TabIndex = 0;
            this.dataMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMember_CellContentClick);
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
            this.groupBox3.Controls.Add(this.btnBuku);
            this.groupBox3.Controls.Add(this.btnMember);
            this.groupBox3.Location = new System.Drawing.Point(-1, 57);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(987, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(843, 58);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(115, 34);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(27, 14);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(115, 34);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLaporan.ForeColor = System.Drawing.Color.White;
            this.btnLaporan.Location = new System.Drawing.Point(843, 15);
            this.btnLaporan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(115, 34);
            this.btnLaporan.TabIndex = 6;
            this.btnLaporan.Text = "LAPORAN";
            this.btnLaporan.UseVisualStyleBackColor = false;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // btnPengembalian
            // 
            this.btnPengembalian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPengembalian.ForeColor = System.Drawing.Color.White;
            this.btnPengembalian.Location = new System.Drawing.Point(683, 15);
            this.btnPengembalian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPengembalian.Name = "btnPengembalian";
            this.btnPengembalian.Size = new System.Drawing.Size(144, 34);
            this.btnPengembalian.TabIndex = 5;
            this.btnPengembalian.Text = "PENGEMBALIAN";
            this.btnPengembalian.UseVisualStyleBackColor = false;
            this.btnPengembalian.Click += new System.EventHandler(this.btnPengembalian_Click);
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
            // btnBuku
            // 
            this.btnBuku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuku.ForeColor = System.Drawing.Color.White;
            this.btnBuku.Location = new System.Drawing.Point(292, 15);
            this.btnBuku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuku.Name = "btnBuku";
            this.btnBuku.Size = new System.Drawing.Size(115, 34);
            this.btnBuku.TabIndex = 2;
            this.btnBuku.Text = "BUKU";
            this.btnBuku.UseVisualStyleBackColor = false;
            this.btnBuku.Click += new System.EventHandler(this.btnBuku_Click);
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMember.ForeColor = System.Drawing.Color.White;
            this.btnMember.Location = new System.Drawing.Point(156, 15);
            this.btnMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(115, 34);
            this.btnMember.TabIndex = 1;
            this.btnMember.Text = "MEMBER";
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // cariBox
            // 
            this.cariBox.Location = new System.Drawing.Point(843, 95);
            this.cariBox.Name = "cariBox";
            this.cariBox.Size = new System.Drawing.Size(127, 22);
            this.cariBox.TabIndex = 21;
            this.cariBox.TextChanged += new System.EventHandler(this.cariBox_TextChanged);
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Member";
            this.Text = "Member";
            this.Load += new System.EventHandler(this.Member_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnPengembalian;
        private System.Windows.Forms.Button btnPinjam;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnBuku;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataMember;
        private System.Windows.Forms.TextBox alamatBox;
        private System.Windows.Forms.TextBox telpBox;
        private System.Windows.Forms.TextBox namaBox;
        private System.Windows.Forms.TextBox idMemberBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cariBox;
    }
}