​using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduk

{

class Program

{

// deklarasi objek collection untuk menampung objek

produk

static Produk produk = new Produk();

static List<Produk> daftarProduk = new List<Produk>();

static void Main(string[] args)

{

	Console.Title = "Responsi UAS Matakuliah
	Pemrograman";	
	
	while (true)
	{
	TampilMenu();
	Console.Write("\nNomor Menu [1..4]: ");

	int nomorMenu = Convert.ToInt32(Console.ReadLine());
	
	switch (nomorMenu)
	{
	case 1:
	TambahProduk();
	break;
	
	case 2:
	HapusProduk();
	break;
	
	case 3:
	TampilProduk();
	break;
	
	case 4: // keluar dari program
	return;
	
	default:
	break;
	}
	}
	}



	static void TampilMenu()

	{

	Console.Clear();
	
	Console.WriteLine("Pilih Menu Aplikasi...");
	Console.WriteLine();
	Console.WriteLine("1. Tambah Produk");
	Console.WriteLine("2. Hapus Produk");
	Console.WriteLine("3. Tampilkan Produk");
	Console.WriteLine("4. Keluar");
	// TODO: tuliskan logika Anda di sini ...
	}



	static void TambahProduk()

	}
	Console.Clear();
	produk = new Produk();
	Console.WriteLine("Tambah Data Produk");
	Console.WriteLine();
	Console.Write("Kode Produk\t: ");
	produk.kode_Produk = Console.ReadLine();
	Console.Write("Nama Produk\t: ");
	produk.nama_Produk = Console.ReadLine();
	Console.Write("Harga Beli\t: ");
	produk.harga_Beli =
	Convert.ToInt32(Console.ReadLine());

	Console.Write("Harga Jual\t: ");

	produk.harga_Jual = Convert.ToInt32(Console.ReadLine());

	// TODO: tuliskan logika Anda di sini ...

	daftarProduk.Add(produk);

	Console.WriteLine("\nTekan ENTER untuk kembali ke menu");

	Console.ReadKey();


	static void HapusProduk()

	{

	Console.Clear();
	Console.WriteLine("Hapus Data Produk");

	Console.Write("Kode Produk : ");

	string kode = Console.ReadLine();

	var itemRemove = daftarProduk.SingleOrDefault(r => r.kode_Produk == kode);

	
	if (itemRemove == null)
	{
	Console.WriteLine();
	Console.WriteLine("Kode Produk Tidak
	DItemukan...");
	}
	else
	{
	daftarProduk.Remove(itemRemove);
	Console.WriteLine();
	Console.WriteLine("Data Produk Berhasil
	Dihapus...");
	}	
	// TODO: tuliskan logika Anda di sini ...
	
	Console.WriteLine("\nTekan ENTER untuk kembali ke
	menu");	
	Console.ReadKey();
	}
	
	static void TampilProduk()

	{

	Console.Clear();
	Console.WriteLine("Data Produk");
	int i = 1;
	foreach (Produk prod in daftarProduk)
	{
	
	Console.WriteLine("{0}.\t{1}, {2}, {3}, {4}",i, prod.kode_Produk, prod.nama_Produk, prod.harga_Beli, prod.harga_Jual);

	i++;	
	}
	// TODO: tuliskan logika Anda di sini ...
	
	Console.WriteLine("\nTekan enter untuk kembali ke
	menu");	
			Console.ReadKey();
		}

	}

}
// TODO: lengkapi property cla