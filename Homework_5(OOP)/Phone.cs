using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_OOP_
{
    internal class Phone:Electronics
    {
        public override int Price
        {
            get
            {
                return price;

            }
            set
            {
                if (value < 100 && value > 6000)
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
                if (value != "Android" && value != "IOS")
                {
                    throw new Exception("Error");
                }
                else
                {
                    operatingSystem = value;
                }
            }
        }

        private int cameraMegaPixels { get; set; }
        public int CameraMegaPixels
        {
            get
            {
                return cameraMegaPixels;

            }
            set
            {
                if (value < 4 && value > 128)
                {
                    throw new Exception("Error");
                }
                else
                {
                    cameraMegaPixels = value;
                }
            }
        }


        public override void DisplayInfo()
        {
            Console.WriteLine($"Model: {Model}, Marc: {Marc}, Operating System: {OperatingSystem}, Camera mp: {CameraMegaPixels}");
        }

        public virtual double CalcPriceWithTax()
        {
            double taxPercent = 0.04;
            return Price * (1 + taxPercent);
        }



        public void CheckCamera()
        {
            if (CameraMegaPixels >= 4 && CameraMegaPixels <= 32)
            {
                Console.WriteLine("Normal");
            }
            else if (CameraMegaPixels > 32 && CameraMegaPixels <= 64)
            {
                Console.WriteLine("Yaxshi");
            }
            else if (CameraMegaPixels > 64)
            {
                Console.WriteLine("Ela");
            }
            else
            {
                Console.WriteLine("Duzgun qiymet daxil edin");
            }
        }
        

    }
}
