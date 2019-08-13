using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perpustakaan
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
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

        private void btnKategori_Click_1(object sender, EventArgs e)
        {
            Kategori ToKategori = new Kategori();
            ToKategori.Show();
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

        private void btnPinjam_Click(object sender, EventArgs e)
        {
            Peminjaman ToPeminjaman = new Peminjaman();
            ToPeminjaman.Show();
            this.Hide();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            Laporan ToLaporan = new Laporan();
            ToLaporan.Show();
            this.Hide();
        }

        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            Pengembalian ToPengembalain = new Pengembalian();
            ToPengembalain.Show();
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
