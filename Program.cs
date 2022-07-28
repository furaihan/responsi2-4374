using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        public static List<Penjualan> list = new List<Penjualan>();
        /// <summary>
        /// Fungsi main program
        /// </summary>
        static void Main(string[] args)
        {
            //Untuk mengubah judul dari aplikasi cli kita
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            //perulangan logika program
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
            if (int.TryParse(Console.ReadLine(), out var note))
            {
                pjl.Nota = note;
            }
            else
            {
                Console.WriteLine("Input tidak valid");
                Console.WriteLine("Tekan ENTER untuk kembali ke menu");
                Console.ReadKey();
                return;
            }
            Console.Write("Tanggal [DD/MM/YYYY]: ");
            //pengecekan apakah input tanggal valid
            if (DateTime.TryParse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("id-ID"), DateTimeStyles.None, out var tgl))
            {
                pjl.Tanggal = tgl;
            }
            else
            {
                Console.WriteLine("Tanggal tidak valid");
                Console.WriteLine("Tekan ENTER untuk kembali ke menu");
                Console.ReadKey();
                return;
            }
            Console.Write("Customer: ");
            pjl.Customer = Console.ReadLine();
            Console.Write("Jenis [T/K]: ");
            var tmp = Console.ReadLine().ToLower();
            //pengecekan apakah input jenis valid
            if (tmp == "k" || tmp == "kredit")
            {
                pjl.Jenis = "Kredit";
            }
            else if (tmp == "t" || tmp == "tunai")
            {
                pjl.Jenis = "Tunai";
            }
            else
            {
                Console.WriteLine("Input tidak valid");
                Console.WriteLine("Tekan ENTER untuk kembali ke menu");
                Console.ReadKey();
                return;
            }
            Console.Write("Total Nota: ");
            //pengecekan apakah input TotalNota yang berupa integer valid
            if (int.TryParse(Console.ReadLine(), out var total))
            {
                pjl.TotalNota = total;
            }
            else
            {
                Console.WriteLine("Input tidak valid");
                Console.WriteLine("Tekan ENTER untuk kembali ke menu");
                Console.ReadKey();
                return;
            }
            //menambahkan objek kedalam list collection
            list.Add(pjl);
            Console.WriteLine("Penjualan berhasil ditambah");
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();
            int counter = 0;

            //perulangan foreach untuk menampilkan seluruh objek di list penjualan
            foreach (Penjualan pj in list)
            {
                Console.WriteLine($"{++counter}. {pj.Nota:000}, {pj.Tanggal.ToString("d", CultureInfo.CreateSpecificCulture("id-ID"))}, {pj.Customer}, {pj.Jenis}, {pj.TotalNota}");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
