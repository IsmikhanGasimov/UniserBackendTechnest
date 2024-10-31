using Homework_5_OOP_.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_OOP_.Managers
{
    internal class PhoneManager : IPhone
    {
        public Phone _phone;
        public PhoneManager(Phone phone)
        {
            _phone = phone;

        }


        public double CalcPriceWithTax()
        {
            double taxPercent = 0.04;
            return _phone.Price * (1 + taxPercent);
        }


        public void CheckCamera()
        {
            if (_phone.CameraMegaPixels >= 4 && _phone.CameraMegaPixels <= 32)
            {
                Console.WriteLine("Normal");
            }
            else if (_phone.CameraMegaPixels > 32 && _phone.CameraMegaPixels <= 64)
            {
                Console.WriteLine("Yaxshi");
            }
            else if (_phone.CameraMegaPixels > 64)
            {
                Console.WriteLine("Ela");
            }
            else
            {
                Console.WriteLine("Duzgun qiymet daxil edin");
            }
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Model: {_phone.Model}, Marc: {_phone.Marc}, Operating System: {_phone.OperatingSystem}, Camera mp: {_phone.CameraMegaPixels}");
        }
    }
}

