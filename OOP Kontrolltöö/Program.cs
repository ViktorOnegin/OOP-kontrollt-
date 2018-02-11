using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kontrolltöö
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Tere, te olete praegu kontori ukse kõrval ");
            Console.WriteLine(" Kas te soovite sisse astuda ? ");
            Console.WriteLine(" 1 - JAH ");
            Console.WriteLine(" 2 - EI ");

            String input1 = Console.ReadLine();
            int Valikud1;
            if (int.TryParse(input1, out Valikud1))
            {
                switch (Valikud1)
                {
                    case 1:
                        var JAH = new PeaUks();
                        break;


                    case 2:
                        var Ei = new PeaUks();
                        break;

                }
            }

            Console.WriteLine("Olete Kontoris");
            Console.WriteLine("Valige töötaja, kellega tahate ringi liikuda");
            Console.WriteLine("1 - Nooremarendaja");
            Console.WriteLine("2- Vanemarendaja");
            Console.WriteLine("3 - Tavakoristaja");
            Console.WriteLine("4 - Spetsiaalkoristaja");
            Console.WriteLine("5 - Ülemus");
            Console.WriteLine("6 - Andmetöötleja");

            String input2 = Console.ReadLine();
            int Valikud2;
            if (int.TryParse(input2, out Valikud2))
            {
                switch (Valikud2)
                {
                    case 1:
                        var Nooremarendaja = new NooremArendaja();
                        break;


                    case 2:
                        var Vanemarendaja = new VanemArendaja();
                        break;


                    case 3:
                        var Tavakoristaja = new TavaKoristaja();
                        break;


                    case 4:
                        var Spetsiaalkoristaja = new SpetsiaalKoristaja();
                        break;


                    case 5:
                        var Ülemus = new Ülemus();
                        break;


                    case 6:
                        var Andmetöötleja = new Andmetöötleja();
                        break;
                }
            }

            Console.WriteLine("Nüüd on aeg tööd teha");
            Console.WriteLine("Valige ruum kus te hakkate tööd tegema");
            Console.WriteLine("1 - Arendajaruum");
            Console.WriteLine("2 - Ülemuseruum");
            Console.WriteLine("3 - Köök");
            Console.WriteLine("4 - Andmetöötlejaruum");

            String input3 = Console.ReadLine();
            int Valikud3;
            if (int.TryParse(input3, out Valikud3))
            {
                switch (Valikud3)
                {
                    case 1:
                        var Arendajaruum = new ArendajaRuum();
                        break;


                    case 2:
                        var Ülemusteruum = new ÜlemuseRuum();
                        break;


                    case 3:
                        var Köök = new Köök();
                        break;


                    case 4:
                        var Andmetöötlejaruum = new AndmetöötlejaRuum();
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
