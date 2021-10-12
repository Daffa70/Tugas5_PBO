using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphisme
{
    public abstract class Karyawan
    {
        public string NamaDepan { get; }
        public string NamaBelakang { get; }
        public string NomorKtp { get; }

        public Karyawan(string NamaDepan, string NamaBelaakang, string NomorKtp)
        {
            this.NamaDepan = NamaDepan;
            this.NamaBelakang = NamaBelakang;
            this.NomorKtp = NomorKtp;
        }

        public override string ToString() => $"{NamaDepan} {NamaBelakang}\n" + $"Nomor KTP : {NomorKtp}";
        public abstract decimal Pendapatan();
    }
}
