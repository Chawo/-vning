using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execercise_11
{
    class Car : Vehicle
    {
        bool engineIsRunning = false;

        public Car() : base("Car")
        {
            Console.WriteLine(engineIsRunning);

        }

        public void StartEngine()
        {
            Console.WriteLine(engineIsRunning = true);

        }

        public void StopEngine()
        {
            Console.WriteLine(engineIsRunning);
        }
        
        
        public override void DescribeVehicle()
        {
            Console.WriteLine("This is a {0}, where the engine is running {1}", type, engineIsRunning=true);
        }




    } 
}
