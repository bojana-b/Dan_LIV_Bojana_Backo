using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dan_LIV_Bojana_Backo
{
    /// <summary>
    /// Abstract class that represents a Motor Vehicle atributes
    /// </summary>
    abstract class MotorVehicle
    {
        public double EngineDisplacement { get; set; }
        public int Weight { get; set; }
        public string Category { get; set; }
        public string EngineType { get; set; }
        public string Color { get; set; }
        public int EngineNumber { get; set; }

        protected MotorVehicle(double engineDisplacement, int weight, string category, string engineType, string color, int engineNumber)
        {
            EngineDisplacement = engineDisplacement;
            Weight = weight;
            Category = category;
            EngineType = engineType;
            Color = color;
            EngineNumber = engineNumber;
        }

        public virtual void Move()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " Go");
        }
        public virtual void Stop()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " Stop");
        }
    }
}
