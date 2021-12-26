using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая__8
{
    class Parallelepiped
    {
        public double Volume { get; set; }

        public Parallelepiped(double volume)
        {
            Volume = volume;
        }

        public string GetFigureInformation()
        {
            return $"Объем - {Volume}";
        }
    }
}
