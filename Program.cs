using System;
using System.Collections.Generic;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        public static List<Penjualan> list = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilihan menu:");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Tampilkan Penjualan");
            Console.WriteLine("3. Keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Console.WriteLine("Tambah Data Penjualan\n");
            Console.Write("Nota: ");
            Penjualan pjl = new Penjualan();
            pjl.Nota = Console.ReadLine();
            Console.Write("Tanggal: ");
            pjl.Tanggal = Console.ReadLine();
            Console.Write("Customer: ");
            pjl.Customer = Console.ReadLine();
            Console.Write("Jenis [T/K]: ");
            pjl.Jenis = Console.ReadLine() == "T" ? "Tunai" : "Kredit";
            Console.Write("Total Nota: ");
            pjl.TotalNota = Console.ReadLine();
            list.Add(pjl);
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();
            int counter = 0;

            foreach (Penjualan pj in list)
            {
                Console.WriteLine($"{++counter}. {pj.Nota}, {pj.Tanggal}, {pj.Customer}, {pj.Jenis}, {pj.TotalNota}");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
