using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pdp1
{
    public class Blok
    {
        public int Indeks { get; set; }
        public DateTime IslemZamani { get; set; }
        public string OncekiSifreleme { get; set; }
        public string Sifreleme { get; set; }
        public string Veri { get; set; }

        public Blok(DateTime islemZamani, string oncekiSifreleme, string data)
        {
            Indeks = 0;
            IslemZamani = islemZamani;
            OncekiSifreleme = oncekiSifreleme;
            Veri = data;
            Sifreleme = HesaplaSifreleme();
        }

        public string HesaplaSifreleme()
        {
            SHA256 sha256 = SHA256.Create();

            byte[] inputBytes = Encoding.ASCII.GetBytes($"{IslemZamani}-{OncekiSifreleme ?? ""}-{Veri}");
            byte[] outputBytes = sha256.ComputeHash(inputBytes);

            return Convert.ToBase64String(outputBytes);
        }
    }
}
