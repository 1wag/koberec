// Program.cs 

using System; 

using System.Collections.Generic; 

using System.Linq; 

using System.Text; 

using System.Threading.Tasks; 

 

namespace Koberec 

{ 

    class Program 

    { 

        static void Main(string[] args) 

        { 

            Console.WriteLine("Program pro vypocet koberce"); 

            // Program vypracoval Hlozek IT2A 

 

            ConsoleManager hodnota = new ConsoleManager(); 

            Vypocty kalkulacka = new Vypocty(); 

 

            Console.WriteLine("1. Koberec tvar ctverec"); 

            Console.WriteLine("2. Koberec tvar obdelnik"); 

            Console.Write("Vyber platnou moznost: "); 

            double moznost = hodnota.Nacteni(); 

 

            if(moznost == 1) 

            { 

 

                Console.Write("Zadej stranu tveho ctvercoveho koberce: "); 

                double a = hodnota.Nacteni(); 

                Console.Write("Zadej cenu za metr ctverecni: "); 

                double cena1 = hodnota.Nacteni(); 

                Console.WriteLine("Tvuj ctvercovy koberec se stranou {0} metru, ma obsah {1} metru ctverecnich.", a, kalkulacka.ObsahCtverce(a)); 

                Console.WriteLine("Pri aktualni cene {0} Kc/m2 bude mit tvuj koberec hodnotu {1} Kc.", cena1, kalkulacka.CenaCtverce(a, cena1)); 

                Console.WriteLine("K materialu pricteme 3 procenta na spoje, to nam dohromady da {0} m2 s hodnotou {1} Kc.", kalkulacka.OdecteniCtverce(a), kalkulacka.OdectenyCtverecCena(a, cena1)); 

 

            }else if(moznost == 2) 

            { 

 

                Console.Write("Zadej prvni stranu tveho obdelnikoveho koberce: "); 

                double b = hodnota.Nacteni(); 

                Console.Write("Zadej druhou stranu tveho obdelnikoveho koberce: "); 

                double c = hodnota.Nacteni(); 

                Console.Write("Zadej cenu za metr ctverecni: "); 

                double cena2 = hodnota.Nacteni(); 

 

                Console.WriteLine("Tvuj obdelnikovy koberec s prvni stranou {0} m, a druhou stranou {1} m, ma obsah {2} m2.", b, c, kalkulacka.ObsahObdelniku(b, c)); 

                Console.WriteLine("Pri aktualni cene {0} Kc/m2 bude mit tvuj koberec hodnotu {1} Kc.", cena2, kalkulacka.CenaObdelniku(b, c, cena2)); 

                Console.WriteLine("K materialu pricteme 3 procenta na spoje, to nam dohromady da {0} m2 s hodnotou {1} Kc.", kalkulacka.OdecteniObdelniku(b, c), kalkulacka.OdectenyObdelnikCena(b, c, cena2)); 

 

            } 

            else 

            { 

                Console.WriteLine("Tato moznost neni platna"); 

            } 

 

            Console.ReadKey(); 

        } 

    } 

} 

 

// ConsoleManager.cs 

using System; 

using System.Collections.Generic; 

using System.Linq; 

using System.Text; 

using System.Threading.Tasks; 

 

namespace Koberec 

{ 

    class ConsoleManager 

    { 

        public double Nacteni() 

        { 

            return double.Parse(Console.ReadLine()); 

        } 

    } 

} 

 

// Vypocty.cs 

using System; 

using System.Collections.Generic; 

using System.Linq; 

using System.Text; 

using System.Threading.Tasks; 

 

namespace Koberec 

{ 

    class Vypocty 

    { 

        public double ObsahCtverce(double a) 

        { 

            return a * a; 

        } 

 

        public double ObsahObdelniku(double b, double c) 

        { 

            return b * c; 

        } 

 

        public double CenaCtverce(double a, double cena1) 

        { 

            return a * a * cena1; 

        } 

 

        public double CenaObdelniku(double b, double c, double cena2) 

        { 

            return b * c * cena2; 

        } 

 

        public double OdecteniCtverce(double a) 

        { 

            return (a * a) + (a * a * 0.03); 

        } 

 

        public double OdecteniObdelniku(double b, double c) 

        { 

            return (b * c) + (b * c * 0.03); 

        } 

 

        public double OdectenyCtverecCena(double a, double cena1) 

        { 

            return (a * a * cena1) + (a * a * cena1 * 0.03);  

        } 

 

        public double OdectenyObdelnikCena(double b, double c, double cena2) 

        { 

            return (b * c * cena2) + (b * c * cena2 * 0.03); 

        } 

    } 

} 

 
