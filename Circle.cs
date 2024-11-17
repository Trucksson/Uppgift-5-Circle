using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_5_Circle
{
    internal class Circle
    {
        public double Radius { get; set; } 
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double GetArea()
        {
            return Radius * Radius * Math.PI; //Genom Pi så kan vi räkna ut cirkelns area r * r * PI
        }
    }
}

