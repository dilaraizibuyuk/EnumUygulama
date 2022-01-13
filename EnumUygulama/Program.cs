using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumUygulama
{
    class Program
    {

        enum bolumler
        {
            Bilgisayar_muhendisligi,
            Elektrik_muhendisligi,
            Makine_muhendisligi,
            İnşaat_muhendisligi,

        }
        static void Main(string[] args)
        {
            bolumler b;
            for(b=bolumler.Bilgisayar_muhendisligi; b <= bolumler.İnşaat_muhendisligi; b++)
            {
                Console.WriteLine("{0}'nın sayısı:{1}",b,(int)b);

            }
            Console.ReadKey();
        }
    }
}
