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
using System.Drawing.Printing;

namespace Perpustakaan
{
    public partial class Laporan : Form
    {
        string koneksi = ("server=localhost; database=perpusvisual; uid=root;password=;");
        public Laporan()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            string sql = "select tb_pinjam.kd_pinjam,tb_kembali.kd_kembali,tb_pinjam.id_member,tb_pinjam.kd_buku,tb_pinjam.tgl_pinjam,tb_pinjam.tgl_kembali,tb_kembali.tgl_pengembalian,tb_kembali.denda from tb_pinjam,tb_kembali where tb_pinjam.kd_pinjam=tb_kembali.kd_pinjam order by tb_pinjam.kd_pinjam";
            MySqlConnection conn = new MySqlConnection(koneksi);
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "tb_pinjam,tb_kembali");
            conn.Close();
            dataLaporan.DataSource = ds.Tables["tb_pinjam,tb_kembali"].DefaultView;

            //rata tengah header
            dataLaporan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //nama header
            dataLaporan.Columns[0].HeaderText = "Kode Pinjam";
            dataLaporan.Columns[1].HeaderText = "Kode Kembali";
            dataLaporan.Columns[2].HeaderText = "ID Member";
            dataLaporan.Columns[3].HeaderText = "Kode Buku";
            dataLaporan.Columns[4].HeaderText = "Tgl Pinjam";
            dataLaporan.Columns[5].HeaderText = "Tgl Kembali";
            dataLaporan.Columns[6].HeaderText = "Tgl Pengembalian";
            dataLaporan.Columns[7].HeaderText = "Denda (Rp)";
            //lebar colom
            dataLaporan.Columns[0].Width = 83;
            dataLaporan.Columns[1].Width = 83;
            dataLaporan.Columns[2].Width = 100;
            dataLaporan.Columns[3].Width = 80;
            dataLaporan.Columns[4].Width = 85;
            dataLaporan.Columns[5].Width = 85;
            dataLaporan.Columns[6].Width = 90;
            dataLaporan.Columns[7].Width = 80;
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

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            Laporan ToLaporan = new Laporan();
            ToLaporan.Show();
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

        private void Laporan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataLaporan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            PageSetupDialog pageSetup = new PageSetupDialog();
            pageSetup.Document = printDocument1;
            pageSetup.PageSettings = printDocument1.DefaultPageSettings; if (pageSetup.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DefaultPageSettings = pageSetup.PageSettings;
                printDocument1.Print();
            }          
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap dataGridViewImage = new Bitmap(this.dataLaporan.Width, this.dataLaporan.Height);
            dataLaporan.DrawToBitmap(dataGridViewImage, new Rectangle(0, 0, this.dataLaporan.Width, this.dataLaporan.Height));
            e.Graphics.DrawImage(dataGridViewImage, 0, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT tb_pinjam.kd_pinjam,tb_kembali.kd_kembali,tb_pinjam.id_member,tb_pinjam.kd_buku,tb_pinjam.tgl_pinjam,tb_pinjam.tgl_kembali,tb_kembali.tgl_pengembalian,tb_kembali.denda FROM tb_pinjam,tb_kembali WHERE tb_pinjam.kd_pinjam=tb_kembali.kd_pinjam and tb_pinjam.id_member LIKE '%" + textBox1.Text + "%' ORDER BY tb_pinjam.kd_pinjam");
            MySqlConnection conn = new MySqlConnection(koneksi);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            MySqlConnection con = new MySqlConnection(koneksi);
            conn.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "tb_pinjam,tb_kembali");
            con.Close();
            dataLaporan.DataSource = ds.Tables["tb_pinjam,tb_kembali"].DefaultView;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
