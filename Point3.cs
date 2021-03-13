using System;
using System.Collections.Generic;

namespace ADO_task1
{
    public class Point3
    { 
        //координаты
        public double X { get; }
        public double Y { get; }
        public double Z { get; }
        public Point3() { }
        public Point3(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Point3 p = (Point3)obj;
            return (p.X == X && p.Y == Y && p.Z == Z) ;
        }

        public override int GetHashCode()
        {
            int hashCode;
            hashCode = 234 * X.GetHashCode();
            hashCode += 56 * Y.GetHashCode();
            hashCode += 12 * Z.GetHashCode();
            return hashCode;

        }

        public static bool operator ==(Point3 p1, Point3 p2)
        => (p1.Equals(p2));
        public static bool operator !=(Point3 p1, Point3 p2)
        => !(p1.Equals(p2));
        
    }
}
