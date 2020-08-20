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

        public Truck() : base()
        {
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
