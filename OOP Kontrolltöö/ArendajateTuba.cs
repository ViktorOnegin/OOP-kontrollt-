using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kontrolltöö
{
    class ArendajateTuba : Toad
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

                if (ToaValik == "ArendajateTuba")
                {
                    if (ArendajateTuba == true)
                    {
                        Console.WriteLine("Arendajad ootavad sind");
                    }
                    else { Console.WriteLine("Sul ei ole õigust neid segada"); }
                }
            }
        }
    }
}
