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
    public partial class Pengembalian : Form
    {
        string koneksi = ("server=localhost; database=perpusvisual; uid=root;password=;");
        public Pengembalian()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            string sql = "select * from tb_kembali";
            MySqlConnection conn = new MySqlConnection(koneksi);
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "tb_kembali");
            conn.Close();
            dataKembali.DataSource = ds.Tables["tb_kembali"].DefaultView;
            //mengosongkan form
            kdkembaliBox.Text = "";
            kdpinjamBox.Text = "";
            dtpPengembalian.Value = DateTime.Today;

            //warna cell
            dataKembali.DefaultCellStyle.ForeColor = Color.Black;
            dataKembali.DefaultCellStyle.BackColor = Color.White;
            //warna header
            dataKembali.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
            dataKembali.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dataKembali.EnableHeadersVisualStyles = false;
            //rata tengah header
            dataKembali.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //nama header
            dataKembali.Columns[0].HeaderText = "Kode Kembali";
            dataKembali.Columns[1].HeaderText = "Kode Pinjam";
            dataKembali.Columns[2].HeaderText = "Tgl Pengembalian";
            dataKembali.Columns[3].HeaderText = "Denda";

            //lebar header
            dataKembali.Columns[0].Width = 160;
            dataKembali.Columns[1].Width = 160;
            dataKembali.Columns[2].Width = 180;
            dataKembali.Columns[3].Width = 180;
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

        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            Pengembalian ToPengembalain = new Pengembalian();
            ToPengembalain.Show();
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

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            Laporan ToLaporan = new Laporan();
            ToLaporan.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Pengembalian_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("insert into tb_kembali(kd_kembali,kd_pinjam,tgl_pengembalian,denda)VALUES('{0}','{1}','{2}','{3}')", kdkembaliBox.Text, kdpinjamBox.Text, dtpPengembalian.Text, dendaBox.Text);
                MySqlConnection conn = new MySqlConnection(koneksi);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Pengembalian telah ditambah!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (OleDbException)
            {
                MessageBox.Show("Tolong isi data dengan benar!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dendaView_TextChanged(object sender, EventArgs e)
        {

        }

        private void telatBox_TextChanged(object sender, EventArgs e)
        {
            int telatbox = Convert.ToInt32(telatBox.Text);
            if (telatbox <= 0)
            {
                dendaBox.Text = "0";
                telatBox.Text = "0";
            }
            else if (telatbox <= 20)
            {
                int telat = int.Parse(telatBox.Text);
                int denda = telat * 5000;
                dendaBox.Text = denda.ToString();
            }
            else
            {
                dendaBox.Text = "100000";
            }
        }

        private void kdkembaliBox_TextChanged(object sender, EventArgs e)
        {
            kdpengembalianView.Text = kdkembaliBox.Text;
        }

        private void kdpinjamBox_TextChanged(object sender, EventArgs e)
        {
            string sql = string.Format("select kd_pinjam,id_member,kd_buku,tgl_pinjam,tgl_kembali from tb_pinjam where kd_pinjam='" + kdpinjamBox.Text + "'");
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
                    kdpinjamView.Text = get["kd_pinjam"].ToString();
                    idMemberView.Text = get["id_member"].ToString();
                    kdbukuView.Text = get["kd_buku"].ToString();
                    dtpPinjam.Text = get["tgl_pinjam"].ToString();
                    dtpKembali.Text = get["tgl_kembali"].ToString();
                }
            }
            else
            {
                kdpinjamView.Text = "";
                idMemberView.Text = "";
                kdbukuView.Text = "";
                dtpPinjam.Text = "";
                dtpKembali.Text = "";
            }
            conn.Close();
        }

        private void dtpPengembalian_ValueChanged(object sender, EventArgs e)
        {
            DateTime tglKembali = dtpKembali.Value;
            DateTime tglPengembalian = dtpPengembalian.Value;
            TimeSpan selisihTgl = tglPengembalian.Subtract(tglKembali);

            telatBox.Text = selisihTgl.Days.ToString();
        }

        private void idMemberView_TextChanged(object sender, EventArgs e)
        {
            string sql = string.Format("select nama from tb_member where id_member='" + idMemberView.Text + "'");
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
                    peminjamView.Text = get["nama"].ToString();
                }
            }
            else
            {
                peminjamView.Text = "";
            }
            conn.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin edit? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string sql = string.Format("update tb_kembali set kd_pinjam='" + kdpinjamBox.Text + "',tgl_pengembalian='" + dtpPengembalian.Text + "',denda='" + dendaBox.Text + "'where kd_kembali='" + kdkembaliBox.Text + "'");
                    MySqlConnection conn = new MySqlConnection(koneksi);
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Data Pengembalian telah diedit!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Tolong isi data dengan benar!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataKembali_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kdkembaliBox.Text = dataKembali.CurrentRow.Cells["kd_kembali"].Value.ToString();
            kdpinjamBox.Text = dataKembali.CurrentRow.Cells["kd_pinjam"].Value.ToString();
            dtpPengembalian.Text = dataKembali.CurrentRow.Cells["tgl_pengembalian"].Value.ToString();
            dendaBox.Text = dataKembali.CurrentRow.Cells["denda"].Value.ToString();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin hapus? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string sql = string.Format("delete from tb_kembali where kd_kembali='" + kdkembaliBox.Text + "'");
                    MySqlConnection conn = new MySqlConnection(koneksi);
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Data Pengembalian telah dihapus!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Ada yang salah, coba lagi!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            kdkembaliBox.Text = "";
            kdpinjamBox.Text = "";
            dtpPengembalian.Value = DateTime.Today;
            dendaBox.Text = "";
            txtCari.Text = "";
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT * FROM tb_kembali WHERE CONCAT (kd_kembali,kd_pinjam,tgl_pengembalian,denda) like '%" + txtCari.Text + "%'");
            MySqlConnection conn = new MySqlConnection(koneksi);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            MySqlConnection con = new MySqlConnection(koneksi);
            conn.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "tb_kembali");
            con.Close();
            dataKembali.DataSource = ds.Tables["tb_kembali"].DefaultView;
        }

        private void dendaBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpPinjam_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpKembali_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
