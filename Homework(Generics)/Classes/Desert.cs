using Homework_Generics_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Generics_.Classes
{
    public class Desert:IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        
    }
}
