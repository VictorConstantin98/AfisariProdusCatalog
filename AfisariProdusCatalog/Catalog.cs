using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfisariProdusCatalog
{
    internal class Catalog
    {
        private readonly string familieProduse;
        private string nume;
        private string producator;
        private List<Product> listaProduse; //Lista de produse nu de int

        //Constructor explicit 1
        public Catalog(string nume, string producator)
        {
            this.nume = nume;
            this.producator = producator;
            this.listaProduse = new List<Product>();
        }

        //Getteri si setteri

        public string getNume()
        {
            return this.nume;
        }
        public void setNume(string nume)
        {
            this.nume = nume;
        }

        public string getProducator()
        {
            return this.producator;
        }

        /*
         * Metoda de adaugare produse
         */

        public void adaugareProdus(Product product)
        {
            listaProduse.Add(product);
        }

        /*
         * Metoda de validare validateProductFamilyFit
         */

        /*public bool validateProductFamilyFit(Product product)
        {

        }*/

        /*
         * ToString
         */

        public override string ToString() //De adaugat afisare listaProduse
        {
            string catalogString = "";
            catalogString = catalogString + "Nume: " + nume + "\n" + "Producator: " + producator + "\n" + "Produse: ";
            foreach(Product element in listaProduse)
            {
                catalogString = catalogString + "\n" + element.ToString(); 
            }
            return catalogString;
        }
    }
}
