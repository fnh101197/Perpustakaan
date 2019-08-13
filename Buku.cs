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
    public partial class Buku : Form
    {
        string koneksi = ("server=localhost; database=perpusvisual; uid=root;password=;");
        public Buku()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            string sql = "select * from tb_buku";
            MySqlConnection conn = new MySqlConnection(koneksi);
            conn.Open();
            //masukan data ke datagrid
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

            //masukan data ke datagrid
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "tb_buku");
            conn.Close();
            dataBuku.DataSource = dataset.Tables["tb_buku"].DefaultView;

            dataBuku.DefaultCellStyle.ForeColor = Color.Black;
            dataBuku.DefaultCellStyle.BackColor = Color.White;
            //warna header
            dataBuku.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
            dataBuku.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dataBuku.EnableHeadersVisualStyles = false;

            //rata tengah header
            dataBuku.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //nama header
            dataBuku.Columns[0].HeaderText = "Kode Buku";
            dataBuku.Columns[1].HeaderText = "Judul Buku";
            dataBuku.Columns[2].HeaderText = "Kategori";
            dataBuku.Columns[3].HeaderText = "Stok";

            //lebar header
            dataBuku.Columns[0].Width = 107;
            dataBuku.Columns[1].Width = 310;
            dataBuku.Columns[2].Width = 210;
            dataBuku.Columns[3].Width = 60;

            //kosongkan form
            bukuBox.Text = "";
            judulBox.Text = "";
            kategoriBox.Text = "";
            stokBox.Text = "";
        }

        private void btnBuku_Click(object sender, EventArgs e)
        {
            Buku ToBuku = new Buku();
            ToBuku.Show();
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

        private void btnKategori_Click_1(object sender, EventArgs e)
        {
            Kategori ToKategori = new Kategori();
            ToKategori.Show();
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

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("insert into tb_buku(kd_buku,judul_buku,nama_kategori,stok)VALUES('{0}','{1}','{2}','{3}')", bukuBox.Text, judulBox.Text, kategoriBox.Text, stokBox.Text);

                MySqlConnection conn = new MySqlConnection(koneksi);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Buku telah ditambah!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Data Sudah Ada!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataBuku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bukuBox.Text = dataBuku.CurrentRow.Cells["kd_buku"].Value.ToString();
            judulBox.Text = dataBuku.CurrentRow.Cells["judul_buku"].Value.ToString();
            kategoriBox.Text = dataBuku.CurrentRow.Cells["nama_kategori"].Value.ToString();
            stokBox.Text = dataBuku.CurrentRow.Cells["stok"].Value.ToString();
        }

        private void Buku_Load(object sender, EventArgs e)
        {
            LoadData();
            try
            {
                MySqlConnection conn = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=");
                string query = "SELECT * From perpusvisual.tb_kategori";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    kategoriBox.Items.Add(reader.GetString("nama_kategori"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void kategoriBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin hapus? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string sql = string.Format("delete from tb_buku where kd_buku='" + bukuBox.Text + "'");
                    MySqlConnection conn = new MySqlConnection(koneksi);
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    //eksekusi query
                    cmd.ExecuteNonQuery();

                    //close koneksi
                    conn.Close();

                    //show message box berhasil
                    MessageBox.Show("Data Buku telah dihapus!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //load database
                    LoadData();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Tolong isi data dengan benar!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin edit? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string sql = string.Format("update tb_buku set judul_buku='" + judulBox.Text + "',nama_kategori='" + kategoriBox.Text + "',stok='" + stokBox.Text + "'where kd_buku='" + bukuBox.Text + "'");
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
            bukuBox.Text = "";
            judulBox.Text = "";
            kategoriBox.Text = "";
            stokBox.Text = "";
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            string sql = string.Format("select * FROM tb_buku WHERE CONCAT (kd_buku,judul_buku,nama_kategori,stok) LIKE '%" + txtCari.Text + "%'");
            MySqlConnection conn = new MySqlConnection(koneksi);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            MySqlConnection con = new MySqlConnection(koneksi);
            conn.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "tb_buku");
            con.Close();
            dataBuku.DataSource = ds.Tables["tb_buku"].DefaultView;
        }
    }
}
