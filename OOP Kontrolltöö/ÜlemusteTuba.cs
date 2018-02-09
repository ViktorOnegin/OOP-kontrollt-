using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kontrolltöö
{
    class ÜlemusteTuba : Toad
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

                if (ToaValik == "ÜlemusteTuba")
                {
                    if (ÜlemusteTuba == true)
                    {
                        Console.WriteLine("Sinuga tahab ülemus rääkida");
                    }
                    else { Console.WriteLine("Ülemusele pole sulle midagi öelda"); }
                }
            }
        }
    }
}
