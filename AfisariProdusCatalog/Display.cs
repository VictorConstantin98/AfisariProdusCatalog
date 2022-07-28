using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfisariProdusCatalog
{
    internal class Display
    {

        /*
         * Metoda pentru a afisa detaliile: numele, locul nasterii si data nasterii.
         */
        public static void DisplayAlexDetails()
        {
            Console.WriteLine("           Hello,");
            string name = "Alex Crijman";
            Console.WriteLine("Name: " + name);

            string birthLocation = "Constanta";
            Console.WriteLine("M-am nascut in " + birthLocation);

            DateTime dateOfBirth = new DateTime(2021, 11, 17);
            Console.WriteLine("Data Nasterii:");
            Console.WriteLine("   " + dateOfBirth.ToShortDateString());
        }

        /*
         * Metoda ce imi afiseaza pe outupt niste randuri, ultimul rand avand numarul ca si input. - De refacut structura repetitiva
         */
        public static void DisplayLines(int numarRand)
        {
            for(int i=1; i<=numarRand; i++)
            {
                Console.WriteLine("Rand " + i + ":");
            }
        }

        /*
         * Metoda ce imi afiseaza la ecran o secventa de tip piramida.
         */

        public static void DisplayPyramid(int nrDeRanduri)
        {
            string X = "";
            string Y = "X";
            for(int i = 1; i < nrDeRanduri; i++)
            {
                X = X + Y;
                Console.WriteLine(X);
            }
        }

        /*
         * Metoda ce imi afieaza la ecran o forma geometrica
         */

        public static void DisplayShape()
        {
            Console.WriteLine(" ____");
            Console.WriteLine(" |  |");
            Console.WriteLine(" |  |");
            Console.WriteLine(" |  |");
            Console.WriteLine(" ____");
        }

        /*
         * Metoda ce imi afiseaza la ecran SUP (varianta1).
         */

        public static void DisplaySup1()
        {
            Console.WriteLine("  ___");
            Console.WriteLine(" |");
            Console.WriteLine(" |__");
            Console.WriteLine("    |");
            Console.WriteLine(" ___|");
            Console.WriteLine("\n");
            Console.WriteLine(" |   |");
            Console.WriteLine(" |   |");
            Console.WriteLine(" |   |");
            Console.WriteLine(" |___|");
            Console.WriteLine("\n");
            Console.WriteLine("  ___");
            Console.WriteLine(" |   | ");
            Console.WriteLine(" |___| ");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
        }

        /*
         * Metoda ce imi afiseaza la ecran SUP (varianta2).
         */
        public static void DisplaySup2()
        {
            Console.WriteLine("  ___          ___ ");
            Console.WriteLine(" |     |   |  |   |");
            Console.WriteLine(" |__   |   |  |___|");
            Console.WriteLine("    |  |   |  |    ");
            Console.WriteLine(" ___|  |___|  |    ");
        }

        /*
         * Metoda ce imi afiseaza la ecran o secventa de numere -  De refacut structura repetitiva
         */

        public static void DisplayNumberSequence(int cifra)
        {
            /*Console.WriteLine("   1  ");
            Console.WriteLine("  2 2 ");
            Console.WriteLine(" 3 3 3");
            Console.WriteLine("  2 2 ");
            Console.WriteLine("   1  ");*/
            for (int i=1; i<=cifra; i++)
            {
                Console.WriteLine("  " + i + "  ");
                Console.WriteLine(" " + i + " " + i + " ");
                Console.WriteLine(" " + i + " " + i + " " + i + " ");
                Console.WriteLine(" " + i + " " + i + " ");
                Console.WriteLine("  " + i + "  ");
            }

        }
    }
}
