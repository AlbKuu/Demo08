/*
* Created: 3.2.2016 
* Authors: Albert Kuusjärvi
Tehtävä 2 - Ostokset home Kotitehtävä

Toteuta sovellus, jolla voit hallita ostoskärryn sisältöä. 
Ostettavalta tuotteelta riittää käsitellä nimi ja hinta. 
Toteuta Product-luokka ja lisää pääohjelmassa esimerkiksi List-tietorakenteeseen muutamia Product-luokan oliota. 
Tulosta lopuksi kokoelman sisältö. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostokset
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product {Name="Hyvää Olutta",Price=1.45 };
            Product p2 = new Product { Name = "Makkaraa", Price = 2.50 };
            Product p3 = new Product { Name = "Sinappia", Price = 1.35 };
            Product p4 = new Product { Name = "Kossua", Price = 9.85 };
            Product p5 = new Product { Name = "Halpaa Olutta", Price = 0.95 };
            double allprice;

            List<Product> products = new List<Product>();

            products.Add(p1);
            products.Add(p2);
            products.Add(p3);
            products.Add(p4);
            products.Add(p5);
        
            Console.WriteLine("Tuotteita mökkiostoskärryssä: ");
            foreach (Product cart in products)
            {
                Console.WriteLine(cart.ToString());
            }
            allprice = p1.Price + p2.Price + p3.Price + p4.Price + p5.Price;
            Console.WriteLine("Kärryn hinta: "+allprice);
        }
    }
}
