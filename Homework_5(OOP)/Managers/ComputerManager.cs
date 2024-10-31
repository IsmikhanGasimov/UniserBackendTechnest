using Homework_5_OOP_.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_OOP_.Managers
{
    internal class ComputerManager : IComputer
    {
        public Computer _computer;
        public ComputerManager(Computer computer)
        {
            _computer = computer;

        }



        public double CalcPriceWithTax()
        {
            double taxPercent = 0.04;
            return _computer.Price * (1 + taxPercent);
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Model: {_computer.Model}, Marc: {_computer.Marc}, Operating System: {_computer.OperatingSystem}, Ram: {_computer.Ram}, Prosessor: {_computer.ProcessorType}");
        }



        public void GetUsefulOrNot()
        {
            if (_computer.Ram >= 4 && _computer.Ram <= 8)
            {
                Console.WriteLine("Ofis ishleri ucundur");
            }
            else if (_computer.Ram > 8 && _computer.Ram <= 16)
            {
                Console.WriteLine("Programlashdirma ucundur");
            }
            else if (_computer.Ram > 16 && _computer.Ram <= 32)
            {
                Console.WriteLine("Dizayn ucundur");
            }
            else if (_computer.Ram > 32 && _computer.Ram <= 128)
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
