using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator_OOP.Figures
{
    public class Rectangle
    {
        private int side1;
        public int Side1
        {
            get { return side1; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("radius cannot be negative");
                }
                else
                {
                    side1 = value;
                }
            }
        }

        private int side2;
        public int Side2
        {
            get { return side1; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("radius cannot be negative");
                }
                else
                {
                    side1 = value;
                }
            }
        }
    }
}
