using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasGit
{
    public class KomisiKaryawan : object
    {
        public string namaDepan { get; }
        public string namaBelakang { get; }
        public string nomorKtp { get; }
        public decimal penjualanKotor;
        public decimal tarifKomisi;

        public KomisiKaryawan(string namaDepan, string namaBelakang, string nomorKtp, decimal penjualanKotor, decimal tarifKomisi)
        {
            this.namaDepan = namaDepan;
            this.namaBelakang = namaBelakang;
            this.nomorKtp = nomorKtp;
            this.penjualanKotor = penjualanKotor;
            this.tarifKomisi = tarifKomisi;
        }

        public decimal PenjualanKotor
        {
            get
            {
                return this.penjualanKotor;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(PenjualanKotor)} harus >= 0");
                }

                penjualanKotor = value;
            }
        }
        
        public decimal TarifKomisi
        {
            get
            {
                return tarifKomisi;
            }
            set
            {
                if (value <= 0 || value >= 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(TarifKomisi)} harus > 0 dan < 1");

                }

                tarifKomisi = value;
            }
        }

        public decimal Pendapatan() => tarifKomisi * penjualanKotor;

        public override string ToString() =>
            $"Komisi karyawan: {namaDepan} {namaBelakang}\n" +
            $"Nomer KTP: {nomorKtp}\n" +
            $"Penjualan Kotor: { penjualanKotor:C}\n" +
            $"Tarif Komisi: { tarifKomisi:F2}";

    }
}
