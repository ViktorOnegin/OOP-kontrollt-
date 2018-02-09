using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kontrolltöö
{
    class Köök : Toad
    {
        public void ToaValikud(string[] toad)
        {
            while (true)
            {
                string ToaValik;

                for (int i = 0; i < toad.Length; i++)
                {
                    Console.WriteLine("{0},", toad[i]);
                }
                ToaValik = Console.ReadLine();

                if (ToaValik == "Köök")
                {
                    if (Köök == true)
                    {
                        Console.WriteLine("Oled sisse astunud");
                    }
                    else { Console.WriteLine("Sul ei ole õigust sisse astuda minna"); }
                }
            }
        }
    }
}
