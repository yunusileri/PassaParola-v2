using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasaparola
{
    class AsilSorular
    {
        GenelSorular gs;
         int[] SoruSayisi = new int[28]; //rastgele olarak hangi sorunun secileceği

        private string[] sorular;
        private string[] cevaplar;

        public string[] Cevaplar { get => cevaplar; }
        public string[] Sorular { get => sorular;  }

        public AsilSorular()
        {
            gs = new GenelSorular();

        }
        void Random()
        {
            byte a = 0, b = 4;
            Random rast = new Random();
            for (int i = 0; i < 28; i++)
            {
                SoruSayisi[i] = rast.Next(a, b);
                a += 5; b += 5; // her soru çeşidinden 5 tane old için
            }
        }

        public void SoruSec()
        {
            Random();
            sorular = new string[28];
            cevaplar = new string[28];


            for (byte i = 0; i < 28; i++)
            {
                sorular[i] = gs.Sorular[SoruSayisi[i]];
                cevaplar[i] = gs.Cevaplar[SoruSayisi[i]];

            }
        }
    }
}
