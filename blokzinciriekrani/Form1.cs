using System;
using System.Windows.Forms;
using blokzinciri;
using Newtonsoft.Json;

namespace blokzinciriekrani
{
    public partial class Form1 : Form
    {
        Blokzincir twobCoin = new Blokzincir();
        public Form1()
        {
            InitializeComponent();
        }

        private void ParayiAktar_Click(object sender, EventArgs e)
        {
            string gönderen = "";
            string alıcı = "";
            int miktar = 0;

            var zincir = new Blok(DateTime.Now, null, "{sender:" + gönderen + ",receiver:" + alıcı + ",amount:" + miktar + "10}");
            twobCoin.EkleBlok(zincir);
            aktarim.Text = JsonConvert.SerializeObject(zincir, Formatting.Indented);

            butunaktarimlar.Text= JsonConvert.SerializeObject(twobCoin, Formatting.Indented);
        }
    }
}
