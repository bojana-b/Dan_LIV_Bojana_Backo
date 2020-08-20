using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_LIV_Bojana_Backo
{
    /// <summary>
    /// class Car that represents a Car atributes
    /// </summary>
    class Car : MotorVehicle
    {
        public string RegistrationNumber { get; set; }
        public int DoorNumber { get; set; }
        public int TankVolume { get; set; }
        public string TransportType { get; set; }
        public string Producer { get; set; }
        public int TrafficNumber { get; set; }

        public Car() : base()
        {
        }

        public void Overpaint(string color, int trafficNumber)
        {
            this.Color = color;
            this.TrafficNumber = trafficNumber;
        }
    }
}
