using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace blokzinciri
{
    public class Blokzincir
    {
        public IList<Blok> Zincir { set; get; }

        public Blokzincir()
        {
            BaslangicZinciri();
            EkleBlok();
        }


        public void BaslangicZinciri()
        {
            Zincir = new List<Blok>();
        }

        public Blok BloguOlustur()
        {
            return new Blok(DateTime.Now, null, "{}");
        }

        public void EkleBlok()
        {
            Zincir.Add(BloguOlustur());
        }

        public Blok SonZinciriGetir()
        {
            return Zincir[Zincir.Count - 1];
        }

        public void EkleBlok(Blok block)
        {
            Blok sonZincir = SonZinciriGetir();
            block.Indeks = sonZincir.Indeks + 1;
            block.OncekiSifreleme = sonZincir.Sifreleme;
            block.Sifreleme = block.HesaplaSifreleme();
            Zincir.Add(block);
        }

        public bool GecerliMi()
        {
            for (int i = 1; i < Zincir.Count; i++)
            {
                Blok simdikiBlok = Zincir[i];
                Blok öncekiBlok = Zincir[i - 1];

                if (simdikiBlok.Sifreleme != simdikiBlok.HesaplaSifreleme())
                {
                    return false;
                }

                if (simdikiBlok.OncekiSifreleme != öncekiBlok.Sifreleme)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

