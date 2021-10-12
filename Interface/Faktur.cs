using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Faktur : IPembayaran
    {
        public string NomorInvoice { get; }
        public string DeskripsiPart { get; }
        private int jumlah;
        private decimal hargaPerItem;

        public Faktur(string nomorInvoice, string deskripsiPart, int jumlah, decimal hargaPerItem)
        {
            this.NomorInvoice = nomorInvoice;
            this.DeskripsiPart = deskripsiPart;
            this.jumlah = jumlah;
            this.hargaPerItem = hargaPerItem;
        }

        public int Jumlah
        {
            get
            {
                return jumlah;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Jumlah)} harus >= 0");
                }

                jumlah = value;
            }
        }

        public decimal HargaPerItem
        {
            get
            {
                return hargaPerItem;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(HargaPerItem)} harus >= 0");
                }

                hargaPerItem = value;
            }
        }

        public override string ToString() =>
            $"invoice:\npart number: {NomorInvoice} ({DeskripsiPart})\n" +
            $"quantity: {Jumlah}\nprice per item: {HargaPerItem:C}";

        public decimal GetJumlahPembayaran() => Jumlah * HargaPerItem;
    }
}
