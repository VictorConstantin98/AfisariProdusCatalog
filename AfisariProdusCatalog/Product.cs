using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfisariProdusCatalog
{
    internal class Product
    {
        private string name;
        private string category;
        private double price;

        //Constructor explicit
        public Product(string name, string category, double price)
        {
            this.name = name;
            this.category = category;
            this.price = price;
        }
        //Getteri si setteri
        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public string getCategory()
        {
            return this.category;
        }

        public void setCategory(string category)
        {
            this.category = category;
        }

        public double getPrice()
        {
            return this.price;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        /*
         * ToString
         */
        public override string ToString()
        {
            string productString = "";
            productString = productString + "\n" + "Name: " + name + "\n" + "Category: " + category + "\n" + "Price: " + price;
            return productString;
        }

        /*
         * Metoda care inverseaza preturile a doua produse
         */

        public void interschimbarePreturi(Product product)
        {
            double priceAux;
            priceAux = price;
            price = product.price;
            product.price = priceAux;
        }

        /*
         * Metoda care majoreaza pretului unui produs cu ajutorul unui multiplicator
         */

        public double majorarePret(double multiplicator)
        {
            price = price * multiplicator;
            return price;
        }
    }
}
