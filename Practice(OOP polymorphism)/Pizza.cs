using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_OOP_polymorphism_
{
    public class Pizza
    {
        public string PizzaType { get; set; }
        public string PizzaSize { get; set; }
        public int PizzaPrice { get; set; }

        public virtual double CalcPizzaPrice()
        {
            if (PizzaSize == "S")
            {
                return PizzaPrice = 15;
            }
            else if (PizzaSize == "M")
            {
                return PizzaPrice = 18;
            }
            else
            {
                return PizzaPrice = 23;
            }
        }

    }

    public class Margaritta:Pizza
    {
        public override double CalcPizzaPrice()
        {
            if (PizzaSize == "S")
            {
                return PizzaPrice = 17;
            }
            else if (PizzaSize == "M")
            {
                return PizzaPrice = 20;
            }
            else
            {
                return PizzaPrice = 25;
            }
        }

    }

    public class Peperonni:Pizza
    {
        public override double CalcPizzaPrice()
        {
            if (PizzaSize == "S")
            {
                return PizzaPrice = 18;
            }
            else if (PizzaSize == "M")
            {
                return PizzaPrice = 22;
            }
            else
            {
                return PizzaPrice = 27;
            }
        }


    }
    public class Mix : Pizza
    {

    }


}
