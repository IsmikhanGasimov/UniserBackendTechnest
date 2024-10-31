using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_4_OOP_
{
    public class Phones
    {
        public string PhoneName { get; set; }
        public string PhoneModel { get; set; }

        public int Price { get; set; }

    }
    public class Iphone : Phones
    {
        public string CompanyName { get; set; }
    }
    public class Samsung : Phones
    {
        public string CompanyName { get; set; }
    }

    public class Xiaomi : Phones
    {
        public string CompanyName { get; set; }
    }

}
