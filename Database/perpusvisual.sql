-- phpMyAdmin SQL Dump
-- version 4.1.12
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 04 Jul 2018 pada 07.46
-- Versi Server: 5.6.16
-- PHP Version: 5.5.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `perpusvisual`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_buku`
--

CREATE TABLE IF NOT EXISTS `tb_buku` (
  `kd_buku` varchar(10) NOT NULL,
  `judul_buku` varchar(30) NOT NULL,
  `nama_kategori` varchar(30) NOT NULL,
  `stok` int(5) NOT NULL,
  PRIMARY KEY (`kd_buku`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_buku`
--

INSERT INTO `tb_buku` (`kd_buku`, `judul_buku`, `nama_kategori`, `stok`) VALUES
('BK0001', 'Pemrograman Visual', 'Komputer', 564);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_kategori`
--

CREATE TABLE IF NOT EXISTS `tb_kategori` (
  `kd_kategori` varchar(10) NOT NULL,
  `nama_kategori` varchar(20) NOT NULL,
  PRIMARY KEY (`kd_kategori`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_kategori`
--

INSERT INTO `tb_kategori` (`kd_kategori`, `nama_kategori`) VALUES
('KTG0001', 'Komputer'),
('KTG0002', 'Sains');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_kembali`
--

CREATE TABLE IF NOT EXISTS `tb_kembali` (
  `kd_kembali` varchar(10) NOT NULL,
  `kd_pinjam` varchar(10) NOT NULL,
  `tgl_pengembalian` date NOT NULL,
  `denda` int(20) NOT NULL,
  PRIMARY KEY (`kd_kembali`),
  KEY `kd_pinjam` (`kd_pinjam`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_kembali`
--

INSERT INTO `tb_kembali` (`kd_kembali`, `kd_pinjam`, `tgl_pengembalian`, `denda`) VALUES
('KMB0001', 'PJM0002', '2018-07-11', 0),
('KMB0002', 'PJM0001', '2018-07-12', 5000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_member`
--

CREATE TABLE IF NOT EXISTS `tb_member` (
  `id_member` varchar(8) NOT NULL,
  `nama` varchar(20) NOT NULL,
  `no_telp` varchar(13) DEFAULT NULL,
  `alamat` varchar(100) NOT NULL,
  PRIMARY KEY (`id_member`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_member`
--

INSERT INTO `tb_member` (`id_member`, `nama`, `no_telp`, `alamat`) VALUES
('MBR0001', 'Fajar Nur Hidayat', '085645696566', 'Bogor'),
('MBR0002', 'Fahmi Prasanda', '081253545566', 'Depok');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_pinjam`
--

CREATE TABLE IF NOT EXISTS `tb_pinjam` (
  `kd_pinjam` varchar(10) NOT NULL,
  `id_member` varchar(10) NOT NULL,
  `kd_buku` varchar(10) NOT NULL,
  `tgl_pinjam` date NOT NULL,
  `tgl_kembali` date NOT NULL,
  PRIMARY KEY (`kd_pinjam`),
  KEY `id_member` (`id_member`),
  KEY `kd_buku` (`kd_buku`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_pinjam`
--

INSERT INTO `tb_pinjam` (`kd_pinjam`, `id_member`, `kd_buku`, `tgl_pinjam`, `tgl_kembali`) VALUES
('PJM0001', 'MBR0002', 'BK0001', '2018-07-04', '2018-07-11'),
('PJM0002', 'MBR0001', 'BK0001', '2018-07-04', '2018-07-11');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_user`
--

CREATE TABLE IF NOT EXISTS `tb_user` (
  `id` int(3) NOT NULL AUTO_INCREMENT,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data untuk tabel `tb_user`
--

INSERT INTO `tb_user` (`id`, `username`, `password`) VALUES
(1, 'admin', 'admin');

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tb_kembali`
--
ALTER TABLE `tb_kembali`
  ADD CONSTRAINT `tb_kembali_ibfk_1` FOREIGN KEY (`kd_pinjam`) REFERENCES `tb_pinjam` (`kd_pinjam`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Ketidakleluasaan untuk tabel `tb_pinjam`
--
ALTER TABLE `tb_pinjam`
  ADD CONSTRAINT `tb_pinjam_ibfk_1` FOREIGN KEY (`id_member`) REFERENCES `tb_member` (`id_member`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `tb_pinjam_ibfk_2` FOREIGN KEY (`kd_buku`) REFERENCES `tb_buku` (`kd_buku`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
