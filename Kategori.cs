using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace Perpustakaan
{
    public partial class Kategori : Form
    {
        string koneksi = ("server=localhost; database=perpusvisual; uid=root;password=;");
        public Kategori()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            //ambil data dari database
            string sql = "select * from tb_kategori";
            MySqlConnection conn = new MySqlConnection(koneksi);
            conn.Open();
            //masukan data ke datagrid
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

            //masukan data ke datagrid
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "tb_kategori");
            conn.Close();
            dataKategori.DataSource = dataset.Tables["tb_kategori"].DefaultView;

            dataKategori.DefaultCellStyle.ForeColor = Color.Black;
            dataKategori.DefaultCellStyle.BackColor = Color.White;
            //warna header
            dataKategori.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
            dataKategori.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dataKategori.EnableHeadersVisualStyles = false;

            //rata tengah header
            dataKategori.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //nama header
            dataKategori.Columns[0].HeaderText = "Kode Kategori";
            dataKategori.Columns[1].HeaderText = "Nama Kategori";
            
            //lebar header918
            dataKategori.Columns[0].Width = 346;
            dataKategori.Columns[1].Width = 346;
            
            //kosongkan form
            kodeBox.Text = "";
            kategoriBox.Text = "";
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            Kategori ToKategori = new Kategori();
            ToKategori.Show();
            this.Hide();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            Home ToHome = new Home();
            ToHome.Show();
            this.Hide();
        }

        private void btnMember_Click_1(object sender, EventArgs e)
        {
            Member ToMember = new Member();
            ToMember.Show();
            this.Hide();
        }

        private void btnBuku_Click_1(object sender, EventArgs e)
        {
            Buku ToBuku = new Buku();
            ToBuku.Show();
            this.Hide();
        }

        private void btnPinjam_Click(object sender, EventArgs e)
        {
            Peminjaman ToPeminjaman = new Peminjaman();
            ToPeminjaman.Show();
            this.Hide();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apa anda yakin? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 ToForm1 = new Form1();
                ToForm1.Show();
                this.Hide();
            }
        }

        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            Pengembalian ToPengembalain = new Pengembalian();
            ToPengembalain.Show();
            this.Hide();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            Laporan ToLaporan = new Laporan();
            ToLaporan.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kodeBox.Text = dataKategori.CurrentRow.Cells["kd_kategori"].Value.ToString();
            kategoriBox.Text = dataKategori.CurrentRow.Cells["nama_kategori"].Value.ToString();
        }

        private void Kategori_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("insert into tb_kategori(kd_kategori,nama_kategori)VALUES('{0}','{1}')", kodeBox.Text, kategoriBox.Text);

                MySqlConnection conn = new MySqlConnection(koneksi);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Kategori Buku telah ditambah!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Data Sudah Ada! Pastikan kode berbeda", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin edit? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string sql = string.Format("update tb_kategori set nama_kategori='" + kategoriBox.Text + "' where kd_kategori='" + kodeBox.Text + "'");
                    MySqlConnection conn = new MySqlConnection(koneksi);
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Data Buku telah diedit!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Tolong isi data dengan benar!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            kodeBox.Text = "";
            kategoriBox.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT * FROM tb_kategori WHERE CONCAT (kd_kategori,nama_kategori) LIKE '%" + textBox1.Text + "%'");
            MySqlConnection conn = new MySqlConnection(koneksi);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            MySqlConnection con = new MySqlConnection(koneksi);
            conn.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "tb_kategori");
            con.Close();
            dataKategori.DataSource = ds.Tables["tb_kategori"].DefaultView;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin hapus? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string sql = string.Format("delete from tb_kategori where kd_kategori='" + kodeBox.Text + "'");
                    MySqlConnection conn = new MySqlConnection(koneksi);
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    //eksekusi query
                    cmd.ExecuteNonQuery();

                    //close koneksi
                    conn.Close();

                    //show message box berhasil
                    MessageBox.Show("Data Kategori telah dihapus!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //load database
                    LoadData();
                }

                catch (MySqlException)
                {
                    MessageBox.Show("Ada yang salah Coba lagi!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
