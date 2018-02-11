using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kontrolltöö
{
    class PeaUks : KontoriSisseastumine
    {
        public PeaUks()
        {
            Name3 = "Peauks";
            bool PeaUks = true;
        }

        public void KontoriSisseastumine()
        {
            if (true)
            {
                Console.WriteLine(" Sa oled kontoris ");
            }

            string str = Console.ReadLine();
        }
    }
}
