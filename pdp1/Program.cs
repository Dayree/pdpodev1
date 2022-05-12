using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Blokzincir twobCoin = new Blokzincir();
            twobCoin.EkleBlok(new Blok(DateTime.Now, null, "{sender:Hüseyin,receiver:Tuba,amount:10}"));
            twobCoin.EkleBlok(new Blok(DateTime.Now, null, "{sender:Tuba,receiver:Hüseyin,amount:5}"));
            twobCoin.EkleBlok(new Blok(DateTime.Now, null, "{sender:Tuba,receiver:Hüseyin,amount:5}"));

            Console.WriteLine(JsonConvert.SerializeObject(twobCoin, Formatting.Indented));

            Console.WriteLine(JsonConvert.SerializeObject(twobCoin.Zincir[1], Formatting.Indented));

            Console.Read();
        }
    }
}
