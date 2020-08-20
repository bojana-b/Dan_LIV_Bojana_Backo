using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_LIV_Bojana_Backo
{
    /// <summary>
    /// class Truck that represents a Truck atributes
    /// </summary>
    class Truck : MotorVehicle
    {
        public double TransportCapacity { get; set; }
        public double Hight { get; set; }
        public int SeatNumber { get; set; }

        public Truck(double transportCapacity, double hight, int seatNumber,
            double engineDisplacement, int weight, string category, string engineType, string color, int engineNumber) 
            : base(engineDisplacement, weight, category, engineType, color, engineNumber)
        {
            TransportCapacity = transportCapacity;
            Hight = hight;
            SeatNumber = seatNumber;
        }

        public void Load()
        {
            Console.WriteLine("Loading into a Truck");
        }

        public void Unload()
        {
            Console.WriteLine("Unloading from a Truck");
        }
    }
}
