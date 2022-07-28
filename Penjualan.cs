using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    /// <summary>
    /// Class yang merepresentasikan objek penjualan
    /// </summary>
    public class Penjualan
    {
        /// <summary>
        /// Properties untuk menyimpan nomer nota penjualan
        /// </summary>
        public int Nota { get; set; }
        /// <summary>
        /// Properties untuk menyimpan tanggal penjualan
        /// </summary>
        public DateTime Tanggal { get; set; }
        /// <summary>
        /// Properties untuk menyimpan nama customer
        /// </summary>
        public string Customer { get; set; }
        /// <summary>
        /// properties untuk menyimpan jenis transaksi penjualan
        /// </summary>
        public string Jenis { get; set; }
        /// <summary>
        /// Properties untuk menyimpan total dari penjualan
        /// </summary>
        public int TotalNota { get; set; }
    }
}
