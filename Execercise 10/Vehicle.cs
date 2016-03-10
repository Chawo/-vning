using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execercise_10
{
    abstract class Vehicle
    {
        public string type;
         

        public Vehicle(string _type)
        {
                type = _type;
        }

        public virtual void DescribeVehicle()
        {
            Console.WriteLine("This vehicle is a {0}", type);
        }


    }
}
