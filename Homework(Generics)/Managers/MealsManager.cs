using Homework_Generics_.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Generics_.Managers
{
    public class MealsManager:GenericsManager<Meals>
    {
        public MealsManager() : base(
            new List<Meals>
            { 
                new Meals{Id=1,Name="Dolma",Price=15,Ingredients="Lamb"},
                new Meals{Id=2,Name="Plov",Price=20,Ingredients="Rice"},
                new Meals{Id=3,Name="Chicken",Price=15,Ingredients="Chicken"}
            })
        {
        }
    }
}
