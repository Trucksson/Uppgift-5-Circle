using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_5_Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Ange radien på cirkeln :D ");
                double radie = Convert.ToDouble(Console.ReadLine());

                Circle cirkel = new Circle(radie);  // Skapar en Cirkel

                double area = cirkel.GetArea();  // Beräknar arean
                Console.WriteLine($"Arean av cirkeln med radie {radie} är: {area}"); // Skriver ut cirkelns Radie och Area
            }
            Console.ReadLine(); // Håller konsolen öppen
        }
    }
    }

