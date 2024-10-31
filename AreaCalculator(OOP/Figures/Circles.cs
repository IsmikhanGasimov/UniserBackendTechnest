using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator_OOP.Figures
{
    public class Circle
    {
        private int radius;

        public int Radius
        {
            get { return radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("radius cannot be negative");
                }
                else
                {
                    radius = value;
                }
            }
        }

        public double CalcAreaOfCircle()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }


    }
}
