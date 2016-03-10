using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleData data = new VehicleData();
            Car car = new Car();
            Boat boat = new Boat();
            car.DescribeVehicle();
            car.StartEngine();
            boat.DescribeVehicle();
            boat.StartEngine();

        }
    }
}
