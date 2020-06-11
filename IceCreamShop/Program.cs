using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            //SORTING FLAVORS

            availableFlavors.Sort(new FlavorComparer());

            //SORTING CONES

            availableCones.Sort(new ConeComparer());

            // PRINTING SORTED FLAVORS

            foreach (Flavor f in availableFlavors)
            {
                Console.WriteLine(f.Name);
            }

            Console.WriteLine("\n");

            //PRINTING SORTED CONES

            foreach (Cone c in availableCones)
            {
                Console.WriteLine($"{c.Name}: {c.Cost}");
            }
        }
    }
}
