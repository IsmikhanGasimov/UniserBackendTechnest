using Homework_Generics_.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Generics_.Managers
{
    public class DrinksManager : GenericsManager<Drinks>
    {
        public DrinksManager() : base(
            new List<Drinks>
            {
                new Drinks{ Id=1,Name="Coca-Cola",Price=5},
                new Drinks{ Id=2,Name="Fanta",Price=4},
                new Drinks{ Id=3,Name="Sprite",Price=3}
            })
        {
        }
    }
}
