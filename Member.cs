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
    public partial class Member : Form
    {
        string koneksi = ("server=localhost; database=perpusvisual; uid=root;password=;");
        public Member()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            //ambil data dari database
            string sql = "select * from tb_member";
            MySqlConnection conn = new MySqlConnection(koneksi);
            conn.Open();
            //masukan data ke datagrid
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

            //masukan data ke datagrid
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "tb_member");
            conn.Close();
            dataMember.DataSource = dataset.Tables["tb_member"].DefaultView;

            dataMember.DefaultCellStyle.ForeColor = Color.Black;
            dataMember.DefaultCellStyle.BackColor = Color.White;
            //warna header
            dataMember.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
            dataMember.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dataMember.EnableHeadersVisualStyles = false;
            
            //rata tengah header
            dataMember.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            //nama header
            dataMember.Columns[0].HeaderText = "ID Member";
            dataMember.Columns[1].HeaderText = "Nama Lengkap";
            dataMember.Columns[2].HeaderText = "No. Telepon";
            dataMember.Columns[3].HeaderText = "Alamat";
            
            //lebar header
            dataMember.Columns[0].Width = 100;
            dataMember.Columns[1].Width = 160;
            dataMember.Columns[2].Width = 110;
            dataMember.Columns[3].Width = 360;

            //kosongkan form
            idMemberBox.Text = "";
            namaBox.Text = "";
            telpBox.Text = "";
            alamatBox.Text = "";
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home ToHome = new Home();
            ToHome.Show();
            this.Hide();
        }

        private void btnBuku_Click(object sender, EventArgs e)
        {
            Buku ToBuku = new Buku();
            ToBuku.Show();
            this.Hide();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            Member ToMember = new Member();
            ToMember.Show();
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

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            Laporan ToLaporan = new Laporan();
            ToLaporan.Show();
            this.Hide();
        }

        private void Member_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("insert into tb_member(id_member,nama,no_telp,alamat)VALUES('{0}','{1}','{2}','{3}')", idMemberBox.Text, namaBox.Text, telpBox.Text, alamatBox.Text);
                MySqlConnection conn = new MySqlConnection(koneksi);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Member telah ditambah!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Data Sudah Ada!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //menampilkan database ke form (edit & hapus)
            //set properties dgvMember ke cellclick
            idMemberBox.Text = dataMember.CurrentRow.Cells["id_member"].Value.ToString();
            namaBox.Text = dataMember.CurrentRow.Cells["nama"].Value.ToString();
            telpBox.Text = dataMember.CurrentRow.Cells["no_telp"].Value.ToString();
            alamatBox.Text = dataMember.CurrentRow.Cells["alamat"].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin edit? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string sql = string.Format("update tb_member set id_member='" + idMemberBox.Text + "',nama='" + namaBox.Text + "',no_telp='" + telpBox.Text + "',alamat='" + alamatBox.Text + "'where id_member='" + idMemberBox.Text + "'");
                    MySqlConnection conn = new MySqlConnection(koneksi);
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Data Member telah diedit!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    string sql = string.Format("delete from tb_member where id_member ='" + idMemberBox.Text + "'");
                    MySqlConnection conn = new MySqlConnection(koneksi);
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    
                    //eksekusi query
                    cmd.ExecuteNonQuery();
                    
                    //close koneksi
                    conn.Close();

                    //show message box berhasil
                    MessageBox.Show("Data Member telah dihapus!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    //load database
                    LoadData();
                }

                catch (MySqlException)
                {
                    MessageBox.Show("Tolong isi data dengan benar!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void idMemberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            idMemberBox.Text = "";
            namaBox.Text = "";
            telpBox.Text = "";
            alamatBox.Text = "";
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void cariBox_TextChanged(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT * FROM tb_member WHERE CONCAT (id_member,nama,no_telp,alamat) LIKE '%" + cariBox.Text + "%'");
            MySqlConnection conn = new MySqlConnection(koneksi);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            MySqlConnection con = new MySqlConnection(koneksi);
            conn.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "tb_member");
            con.Close();
            dataMember.DataSource = ds.Tables["tb_member"].DefaultView;
        }
    }
}
