using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Practice_task.cars;

namespace Practice_task
{
    public class cars
    {
        public string CarName { get; set; }

        public string CarColour { get; set; }

        public int Price { get; set; }

    }
    public class Bmw : cars
    {
        public string Model { get; set; }
    }

    public class Mercedes : cars
    {
        public string Model { get; set; }
    }

    public class Toyota : cars
    {
        public string Model { get; set; }
    }
}
