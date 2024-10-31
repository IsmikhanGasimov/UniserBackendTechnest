using Homework_Generics_.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Generics_.Managers
{
    public class FastFoodManager: GenericsManager<FastFood>
    {
        public FastFoodManager() : base(
            new List<FastFood>
            {
                new FastFood{ Id=1,Name="Burger",Price=7,Ingredients="Beef"},
                new FastFood{ Id=2,Name="Plov",Price=6,Ingredients="Chicken"},
                new FastFood{ Id=3,Name="Chicken",Price=8,Ingredients="Margarita"}
            })
        {
        }
    }
}
