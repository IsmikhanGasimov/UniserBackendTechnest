using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_OOP_
{
    internal class Computer:Electronics
    {
        public override int Price
        {
            get
            {
                return price;

            }
            set
            {
                if (value < 1000 && value > 12000)
                {
                    throw new Exception("Error");
                }
                else
                {
                    price = value;
                }
            }
        }


       
        public override string OperatingSystem
        {
            get
            {
                return operatingSystem;
            }
            set
            {
                if (value != "Windows" && value != "Linux" && value != "Macos")
                {
                    throw new Exception("Error");
                }
                else
                {
                    operatingSystem = value;
                }
            }
        }

        private string processorType;

        public string ProcessorType
        {
            get
            {
                return processorType;
            }
            set
            {
                if(value!="Intel" && value != "Ryzen")
                {
                    throw new Exception("Error");
                }
                else
                {
                    processorType = value;
                }
            }
        }

        public virtual double CalcPriceWithTax()
        {
            double taxPercent = 0.04;
            return Price * (1 + taxPercent);
        }


        private int ram;
        public int Ram
        {
            get
            {
                return ram;

            }
            set
            {
                if (value < 4 && value > 128)
                {
                    throw new Exception("Error");
                }
                else
                {
                    ram = value;
                }

            }
        }


        public override void DisplayInfo()
        {
            Console.WriteLine($"Model: {Model}, Marc: {Marc}, Operating System: {OperatingSystem}, Ram: {Ram}, Prosessor: {ProcessorType}");
        }

        public void GetUsefulOrNot()
        {
            if (Ram >= 4 && Ram <= 8)
            {
                Console.WriteLine("Ofis ishleri ucundur");
            }
            else if (Ram > 8 && Ram <= 16)
            {
                Console.WriteLine("Programlashdirma ucundur");
            }
            else if (Ram > 16 && Ram <= 32)
            {
                Console.WriteLine("Dizayn ucundur");
            }
            else if(Ram>32 && Ram<=128)
            {
                Console.WriteLine("Oyun ucundur");
            }
            else
            {
                Console.WriteLine("Duzgun ram deyeri daxil edin");
            }
        }







    }
}
