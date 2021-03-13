using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_task1.MathObjectLogic
{
    class Mat3x3Logic
    {
        public double GetDeterminant(Vec3 row1, Vec3 row2, Vec3 row3)
        {
            //triangle method
            double mainDiag = row1.X * row2.Y * row3.Z;
            double dopDiag1 = row3.X * row1.Y * row2.Z;
            double dopDiag2 = row2.X * row3.Y * row1.Z;
            double notXMain = row3.X * row2.Y * row1.Z;
            double negDiag1 = row1.X * row2.Z * row3.Y;
            double negDiag2 = row1.Y * row2.X * row3.Z;
            double res = mainDiag + dopDiag1 + dopDiag2 - notXMain - negDiag1 - negDiag2;
            return res;
        }
        public double GetDeterminant(Mat3x3 mat)
        {
            return GetDeterminant(mat.Row1, mat.Row2, mat.Row3); ;
        }
        public bool IsVectorsCoplanar(Vec3 vec1, Vec3 vec2, Vec3 vec3)
        {
            //определитель == 0 => компланарны
            return GetDeterminant(vec1, vec2, vec3) == 0.0;

        }
        public bool IsVectorsCoplanar(Point3 pOsn0, Point3 pOsn1, Point3 pOsn2, Point3 pOsn3)
        {
            return IsVectorsCoplanar(new Vec3(pOsn0, pOsn1), new Vec3(pOsn0, pOsn2), new Vec3(pOsn0, pOsn3));
        }
        public bool IsVectorsCoplanar(Point3[] ps)
        {
            if (ps.Length != 4)
            {
                Console.WriteLine("Передано некорректное чисто точек");
                return false;
            }
            return IsVectorsCoplanar(ps[0], ps[1], ps[2], ps[3]);
        }
    }
}
