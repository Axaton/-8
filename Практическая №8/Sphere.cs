using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая__8
{
    class Sphere : Parallelepiped, IComparable, ICloneable, IFigure
    {
        public Sphere(double volume) : base(volume)
        {
            Volume = volume;
        }

        public int CompareTo(object obj)
        {
            Parallelepiped temp = (Parallelepiped)obj;
            if (this.Volume > temp.Volume) return 1;
            if (this.Volume < temp.Volume) return -1;
            return 0;
        }

        public Sphere ShallowClone()
        {
            return (Sphere)this.MemberwiseClone();
        }

        public object Clone()
        {
            return new Sphere(Volume);
        }
    }
}
