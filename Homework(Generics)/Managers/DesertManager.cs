using Homework_Generics_.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Generics_.Managers
{
    public class DesertManager:GenericsManager<Desert>
    {
        public DesertManager() : base(
            new List<Desert>
            {
                new Desert{Id=1,Name="Napoleon",Price=9},
                new Desert{Id=2,Name="Tiramisu",Price=10}
            })
        {
        }
    }
}
