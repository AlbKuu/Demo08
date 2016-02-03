/*
* Created: 3.2.2016 
* Authors: Albert Kuusjärvi
Tehtävä 1 - Noppa home Kotitehtävä

Toteuta Noppa-luokka siten, että noppaa voidaan heittää. Nopan tulee palauttaa satunnainen luku jokaisella heittokerralla.
Toteuta pääohjelmassa nopan heittäminen. Kokeile ensin heittää noppaa kerran ja tulosta nopan luku. 
Toteuta tämän jälkeen ohjelma siten, että kysyt käyttäjältä heittojen määrän.
Heitä noppaa ja tulosta heittojen lukujen keskiarvo.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noppa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä on nopanheittokone");
            // Luodaan olio Die-luokasta
            Die die = new Die();
            int number;
            int allrolls=0;
            double count;
            string line;

            Console.WriteLine("Anna heittojen määrä");
            line = Console.ReadLine();

            bool result = double.TryParse(line, out count);
            if (result)
            {
                for (int i=0; i < count; i++)
                {
                    number = die.DieRoll();
                    Console.WriteLine("Nopan {0} heitto heitti: {1}", i + 1, number);
                    //Lisätään heitto kokonaistulokseen
                    allrolls = allrolls + number;
                }
                // lasketaan keskiarvo 
                double average = allrolls / count;
                Console.WriteLine("Nopan heittojen keskiarvo oli: " + average);
            }
            else
            {
                Console.WriteLine("Ei tuo ole numero!");
            }
        }
    }
}
