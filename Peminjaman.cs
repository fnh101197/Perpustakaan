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
    public partial class Peminjaman : Form
    {
        string koneksi = ("server=localhost; database=perpusvisual; uid=root;password=;");
        public Peminjaman()
        {
            InitializeComponent();
        }

         public void LoadData()
        {
            string sql = "select * from tb_pinjam";
            MySqlConnection conn = new MySqlConnection(koneksi);
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "tb_pinjam");
            conn.Close();
            dataPinjam.DataSource = ds.Tables["tb_pinjam"].DefaultView;
            //mengosongkan form
            kdpinjamBox.Text = "";
            idMemberBox.Text = "";
            bukuBox.Text = "";
            dtpPinjam.Value = DateTime.Today;
            dtpKembali.Value = DateTime.Today;

            //warna cell
            dataPinjam.DefaultCellStyle.ForeColor = Color.Black;
            dataPinjam.DefaultCellStyle.BackColor = Color.White;
            //warna header
            dataPinjam.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
            dataPinjam.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dataPinjam.EnableHeadersVisualStyles = false;
            //rata tengah header
            dataPinjam.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //nama header
            dataPinjam.Columns[0].HeaderText = "Kode Pinjam";
            dataPinjam.Columns[1].HeaderText = "ID Member";
            dataPinjam.Columns[2].HeaderText = "Kode Buku";
            dataPinjam.Columns[3].HeaderText = "Tgl Pinjam";
            dataPinjam.Columns[4].HeaderText = "Tgl Kembali";
            //lebar header
            dataPinjam.Columns[0].Width = 175;
            dataPinjam.Columns[1].Width = 172;
            dataPinjam.Columns[2].Width = 100;
            dataPinjam.Columns[3].Width = 120;
            dataPinjam.Columns[4].Width = 120;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home ToHome = new Home();
            ToHome.Show();
            this.Hide();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            Member ToMember = new Member();
            ToMember.Show();
            this.Hide();
        }

        private void btnBuku_Click(object sender, EventArgs e)
        {
            Buku ToBuku = new Buku();
            ToBuku.Show();
            this.Hide();
        }

        private void btnKategori_Click(object sender, EventArgs e)
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

        private void btnLogout_Click(object sender, EventArgs e)
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
                string sql = string.Format("insert into tb_pinjam(kd_pinjam,id_member,kd_buku,tgl_pinjam,tgl_kembali)VALUES('{0}','{1}','{2}','{3}','{4}')", kdpinjamBox.Text, idMemberBox.Text, bukuBox.Text, dtpPinjam.Text, dtpKembali.Text);
                MySqlConnection conn = new MySqlConnection(koneksi);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Peminjaman telah ditambah!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Tolong isi data dengan benar!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bukuBox_TextChanged(object sender, EventArgs e)
        {
            string sql = string.Format("select judul_buku,stok from tb_buku where kd_buku='" + bukuBox.Text + "'");
            MySqlConnection conn = new MySqlConnection(koneksi);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            //mengambil data dari database ke textbox
            MySqlDataReader get = cmd.ExecuteReader();
            if (get.HasRows)
            {
                while (get.Read())
                {
                    judulView.Text = get["judul_buku"].ToString();
                }
            }
            else
            {
                judulView.Text = "";
            }
            conn.Close();
        }

        private void idMemberBox_TextChanged(object sender, EventArgs e)
        {
            string sql = string.Format("select nama,no_telp from tb_member where id_member='" + idMemberBox.Text + "'");
            MySqlConnection conn = new MySqlConnection(koneksi);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            //mengambil data dari database ke textbox
            MySqlDataReader get = cmd.ExecuteReader();
            if (get.HasRows)
            {
                while (get.Read())
                {
                    namaView.Text = get["nama"].ToString();
                    teleponView.Text = get["no_telp"].ToString();
                }
            }
            else
            {
                namaView.Text = "";
                teleponView.Text = "";
            }
            conn.Close();
        }

        private void kdpinjamBox_TextChanged(object sender, EventArgs e)
        {
            kdpinjamView.Text = kdpinjamBox.Text;
        }

        private void lamaView_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataPinjam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kdpinjamBox.Text = dataPinjam.CurrentRow.Cells["kd_pinjam"].Value.ToString();
            idMemberBox.Text = dataPinjam.CurrentRow.Cells["id_member"].Value.ToString();
            bukuBox.Text = dataPinjam.CurrentRow.Cells["kd_buku"].Value.ToString();
            dtpPinjam.Text = dataPinjam.CurrentRow.Cells["tgl_pinjam"].Value.ToString();
            dtpKembali.Text = dataPinjam.CurrentRow.Cells["tgl_kembali"].Value.ToString();
        }

        private void Peminjaman_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void namaView_TextChanged(object sender, EventArgs e)
        {

        }

        private void teleponView_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpKembali_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime tglPinjam = dtpPinjam.Value;
            DateTime tglKembali = dtpKembali.Value;
            TimeSpan selisihTgl = tglKembali.Subtract(tglPinjam);

            lamaView.Text = selisihTgl.Days.ToString();
        }

        private void dtpPinjam_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime tglPinjam = dtpPinjam.Value;
            DateTime tglKembali = dtpKembali.Value;
            TimeSpan selisihTgl = tglKembali.Subtract(tglPinjam);

            lamaView.Text = selisihTgl.Days.ToString();
        }

        private void stokBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin edit? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string sql = string.Format("update tb_pinjam set id_member='" + idMemberBox.Text + "',kd_buku='" + bukuBox.Text + "',tgl_pinjam='" + dtpPinjam.Text + "', tgl_kembali='" + dtpKembali.Text + "'where kd_pinjam='" + kdpinjamBox.Text + "'");
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

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin hapus? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string sql = string.Format("delete from tb_pinjam where kd_pinjam='" + kdpinjamBox.Text + "'");
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

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            string sql = string.Format("select * FROM tb_pinjam WHERE CONCAT (kd_pinjam,id_member,kd_buku,tgl_pinjam,tgl_kembali) LIKE '%" + txtCari.Text + "%'");
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
            dataPinjam.DataSource = ds.Tables["tb_buku"].DefaultView;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            kdpinjamBox.Text = "";
            idMemberBox.Text = "";
            bukuBox.Text = "";
            dtpPinjam.Value = DateTime.Today;
            dtpKembali.Value = DateTime.Today;
        }
    }
}
