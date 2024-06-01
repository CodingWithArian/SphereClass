using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SphereClass
{
    internal class Sphere
    {
        private double radius;

        public double Radius
            {
            get { return radius; }
            set { radius = value; }
            }
        public Sphere(double value)
        {
            radius = value;
        }
        public Sphere()
        {
            radius = 1;
        }

        public void SetRadius(double value)
        {
            radius = value;
        }
        public override string ToString()
        {
            return "Radius  "  + radius +"\n";
        }
        public double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
        public double Area()
        {
            return 4 * Math.PI * Math.Pow(radius, 2);
        }
        public double Valume()
        {
            return 4 / 3.0 * Math.PI * Math.Pow(radius, 3);
        }

    }
}
