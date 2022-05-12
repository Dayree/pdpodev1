using System;
using System.Windows.Forms;
using blokzinciri;
using Newtonsoft.Json;

namespace blokzinciriekrani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Blokzincir twobCoin = new Blokzincir();
            twobCoin.EkleBlok(new Blok(DateTime.Now, null, "{sender:Hüseyin,receiver:Tuba,amount:10}"));
            twobCoin.EkleBlok(new Blok(DateTime.Now, null, "{sender:Tuba,receiver:Hüseyin,amount:5}"));
            twobCoin.EkleBlok(new Blok(DateTime.Now, null, "{sender:Tuba,receiver:Hüseyin,amount:5}"));

            Console.WriteLine(JsonConvert.SerializeObject(twobCoin, Formatting.Indented));

            Console.WriteLine(JsonConvert.SerializeObject(twobCoin.Zincir[1], Formatting.Indented));
            label1.Text = JsonConvert.SerializeObject(twobCoin, Formatting.Indented);
        }

    }
}
