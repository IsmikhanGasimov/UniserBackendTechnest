using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_task
{
    internal class Person
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        private int balance { get; set; }

        public int Balance
        {
            get
            {
                return balance;
            }

            set
            {
                if (value > 90000 || value < 1000)
                {
                    throw new Exception("Error");

                }
                else
                {
                    balance = value;
                }
            }
        }
    }
}
