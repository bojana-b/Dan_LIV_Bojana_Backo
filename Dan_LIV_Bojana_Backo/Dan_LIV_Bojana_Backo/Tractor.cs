using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_LIV_Bojana_Backo
{
    /// <summary>
    /// class Tractor that represents a Tractor atributes
    /// </summary>
    class Tractor : MotorVehicle
    {
        public double TireSize { get; set; }
        public int Wheelbase { get; set; }
        public string Drive { get; set; }

        private readonly string[] allDrive = { "A", "B", "C" };

        public Tractor() : base()
        {
        }
    }
}
