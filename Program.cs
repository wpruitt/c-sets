using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>();
            Showroom.Add("CTS-V");
            Showroom.Add("Eclipse");
            Showroom.Add("Evo");
            Showroom.Add("Testarossa");
             foreach (string car in Showroom)
            {
                Console.WriteLine(car);
            }
            Showroom.Add("Eclipse");
             foreach (string car in Showroom)
            {
                Console.WriteLine(car);
            }
            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("NSX");
            UsedLot.Add("Dart");
            Showroom.UnionWith(UsedLot);
             foreach (string car in Showroom)
            {
                Console.WriteLine(car);
            }
            Showroom.Remove("Eclipse");
             foreach (string car in Showroom)
            {
                Console.WriteLine(car);
            }
            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("Astro");
            Junkyard.Add("CTS-V");
            Junkyard.Add("El Camino");
            Junkyard.Add("Bug");
            Showroom.IntersectWith(Junkyard);
            foreach (string car in Showroom)
            {
                Console.WriteLine(car);
            }
            Showroom.UnionWith(Junkyard);
            foreach (string car in Showroom)
            {
                Console.WriteLine(car);
            }
            Showroom.Remove("Bug");
            foreach (string car in Showroom)
            {
                Console.WriteLine(car);
            }
        }
    }
}
