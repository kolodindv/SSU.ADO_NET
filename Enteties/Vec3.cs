using System;

namespace ADO_task1
{
    public class Vec3
    {
        // Координаты вектора
        public double X { get; }
        public double Y { get; }
        public double Z { get; }
        // Длина
        public double LenVec3 { get; }
        // Конструкторы
        public Vec3() { }
        public Vec3(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
            LenVec3 = Math.Sqrt(X * X + Y * Y + Z * Z);
        }
        public Vec3(Point3 start, Point3 end) : this(end.X - start.X, end.Y - start.Y, end.Z - start.Z) { }
        public Vec3(Vec3 copyVec3) : this (copyVec3.X, copyVec3.Y, copyVec3.Z) { }
    }
}
