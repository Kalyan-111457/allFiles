using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
     interface IDrivable
    {
        int wheels { get; set; }

        double speed { get; set; }

        void Move();
        void stop();
    }
}
