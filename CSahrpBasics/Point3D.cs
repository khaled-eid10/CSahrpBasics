using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSahrpBasics
{
    public class Point3D : IComparable<Point3D>, ICloneable
    {

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        
        public Point3D() : this(0, 0, 0) { }

        public Point3D(double x) : this(x, 0, 0) { }

        
        public Point3D(double x, double y) : this(x, y, 0) { }

        
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }
        public override bool Equals(object obj)
        {
            if (obj is Point3D other)
            {
                return this == other;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }

        public int CompareTo(Point3D? other)
        {
            throw new NotImplementedException();
        }
    }
}
