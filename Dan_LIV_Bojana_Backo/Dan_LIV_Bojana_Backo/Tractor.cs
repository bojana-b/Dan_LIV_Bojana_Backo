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

        public Tractor(double tireSize, int wheelbase, string drive,
            double engineDisplacement, int weight, string category, string engineType, string color, int engineNumber) 
            : base(engineDisplacement, weight, category, engineType, color, engineNumber)
        {
            TireSize = tireSize;
            Wheelbase = wheelbase;
            Drive = drive;
        }
    }
}
