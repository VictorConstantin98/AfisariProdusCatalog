using System;
namespace AfisariProdusCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Afisam detaliile lui Alex");
            Console.WriteLine("-------------------------");
            Display.DisplayAlexDetails();

            Console.WriteLine("\n");

            Console.WriteLine("Afisam randurile");
            Console.WriteLine("----------------");
            Display.DisplayLines(10);

            Console.WriteLine("\n");

            Console.WriteLine("Afisam structura de tip piramida");
            Console.WriteLine("--------------------------------");
            Display.DisplayPyramid(7);   
            
            Console.WriteLine("\n");

            Console.WriteLine("Afisam forma geometrica");
            Console.WriteLine("-----------------------");
            Display.DisplayShape();

            Console.WriteLine("\n");

            Console.WriteLine("Afisam SUP (varianta1)");
            Console.WriteLine("----------------------");
            Display.DisplaySup1();

            Console.WriteLine("\n");

            Console.WriteLine("Afisam SUP (varianta2)");
            Console.WriteLine("----------------------");
            Display.DisplaySup2();

            Console.WriteLine("\n");

            Console.WriteLine("Afisam o secventa de numere");
            Console.WriteLine("---------------------------");
            Display.DisplayNumberSequence(3);

            Console.WriteLine("\n");

            Product product1 = new Product("Cafea arabica", "Cafea", 50.35);
            Product product2 = new Product("Cafea robusta", "Cafea", 45.25);

            Console.WriteLine("Afisam cele doua produse inainte de interschimbare");
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine(product1.ToString());

            Console.WriteLine("\n");

            Console.WriteLine(product2.ToString());

            Console.WriteLine("\n");

            Console.WriteLine("Afisam cele doua produse dupa interschimbare");
            Console.WriteLine("--------------------------------------------");

            product1.interschimbarePreturi(product2); //Realizam interschimbarea

            Console.WriteLine(product1.ToString());

            Console.WriteLine("\n");

            Console.WriteLine(product2.ToString());

            Console.WriteLine("\n");

            Console.WriteLine("Afisam produsul inainte de multiplicare");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine(product1.ToString());

            Console.WriteLine("\n");

            Console.WriteLine("Afisam produsul dupa multiplicare");
            Console.WriteLine("---------------------------------");

            product1.majorarePret(2); //Multiplicam pretul cu 2

            Console.WriteLine(product1.ToString());

            Console.WriteLine("\n");

            Console.WriteLine("Declaram Catalog cafea si adaugam trei produse");
            Console.WriteLine("----------------------------------------------");

            Catalog catalogCafea = new Catalog("Catalog Lilly", "Lilly");
            catalogCafea.adaugareProdus(product1);
            catalogCafea.adaugareProdus(product2);
            catalogCafea.adaugareProdus(product1);
            Console.WriteLine(catalogCafea.ToString());

            Console.WriteLine("\n");

            Console.WriteLine("Declaram Catalog ceai si adaugam cinci produse");
            Console.WriteLine("----------------------------------------------");

            Catalog catalogCeai = new Catalog("Catalog ceai", "Fares");
            catalogCeai.adaugareProdus(product1);
            catalogCeai.adaugareProdus(product1);
            catalogCeai.adaugareProdus(product2);
            catalogCeai.adaugareProdus(product2);
            catalogCeai.adaugareProdus(product2);
            Console.WriteLine(catalogCeai.ToString());

            Console.WriteLine("\n");

            Console.WriteLine("Declaram in main Catalog produse");
            Console.WriteLine("--------------------------------");

            Catalog catalogProduse = new Catalog("Produse catalog", "Cola");
            

            


        }
    }
}