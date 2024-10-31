using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_OOP_
{
    internal class Electronics
    {
        public string ID { get; private set; } = Guid.NewGuid().ToString();
        public string Model { get; set; }
        public string Marc { get; set; }

        public string operatingSystem;
        public virtual string OperatingSystem
        {
            get
            {
                return operatingSystem;
            }
            set
            {

            }
        }


        public int price;
        public virtual int Price
        {
            get
            {
                return price;
            }
            set
            {
            }
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("");
        }
    }
}
