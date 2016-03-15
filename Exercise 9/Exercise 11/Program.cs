using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execercise_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new VehicleData();
            //data.PrintVehicle();
            var car = new Car();
            car.DescribeVehicle();
            var boat = new Boat();
            boat.DescribeVehicle();

        }
    }
}
