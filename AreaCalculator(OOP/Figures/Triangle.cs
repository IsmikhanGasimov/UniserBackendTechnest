using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator_OOP.Triangle
{
    public class Triangle
    {
        private int side1;
        public int Side1
        {
            get { return side1; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Name cannot be empty");
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
            get { return side2; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                else
                {
                    side2 = value;
                }
            }
        }




        private int side3;
        public int Side3
        {
            get { return side3; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                else
                {
                    side3 = value;
                }
            }
        }

        public bool IsExist()
        {
            if((Math.Abs(Side1-Side2)<Side3 && Side3<Side1+Side2)&& (Math.Abs(Side2 - Side3) < Side1 && Side1 < Side2 + Side3)&& (Math.Abs(Side1 - Side3) < Side2 && Side2 < Side1+ Side3){
                return true;
            }
            else
            {
                return false;
            }
        }

        public double CalcPerimeter()
        {
            return Side1 + Side2 + Side3;
        }


        public double CalcAreaOfTriangle()
        {
            if (IsExist())
            {
                double halfOfPerimeter = CalcPerimeter() / 2;
                return Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - Side1) * (halfOfPerimeter - Side2) * (halfOfPerimeter - Side3));
            }
            else
            {
                throw new ArgumentException("not exist");
            }
        }

    }
}
