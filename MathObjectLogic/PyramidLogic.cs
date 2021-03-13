using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_task1.MathObjectLogic
{
    class PyramidLogic
    {        
        private readonly Mat3x3Logic mat3x3Logic = new Mat3x3Logic();        

        private double GetDetTetrahedron(Vec3 vec1, Vec3 vec2, Vec3 vec3)
        {
            return mat3x3Logic.GetDeterminant(vec1, vec2, vec3);
        }
        private double GetDetTetrahedron(Point3 pNotOsn, Point3 pOsn1, Point3 pOsn2, Point3 pOsn3)
        {
            return GetDetTetrahedron(new Vec3(pNotOsn, pOsn1),
                                     new Vec3(pNotOsn, pOsn2),
                                     new Vec3(pNotOsn, pOsn3));
        }

        private double GetSquareTriangle(Point3 pOsn1, Point3 pOsn2, Point3 pOsn3)
        {
            //Формула Герона
            double a = new Vec3(pOsn1, pOsn2).LenVec3;
            double b = new Vec3(pOsn2, pOsn3).LenVec3;
            double c = new Vec3(pOsn3, pOsn1).LenVec3;
            double p = 0.5 * (a + b + c);
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }

        public double FindVolumePyr(Pyramid pyr)
        {
            double DetFirstTetrahedron = GetDetTetrahedron(pyr.Points[pyr.IndexNotOsn],
                                                           pyr.Points[pyr.MasIndexOsn[0]],
                                                           pyr.Points[pyr.MasIndexOsn[1]],
                                                           pyr.Points[pyr.MasIndexOsn[3]]);

            double DetSecondTetrahedron = GetDetTetrahedron(pyr.Points[pyr.IndexNotOsn],
                                                            pyr.Points[pyr.MasIndexOsn[1]],
                                                            pyr.Points[pyr.MasIndexOsn[2]],
                                                            pyr.Points[pyr.MasIndexOsn[3]]);

            return (Math.Abs(DetFirstTetrahedron) + Math.Abs(DetSecondTetrahedron)) / 6.0;
        }       

        public double FindSquareOsnPyr(Pyramid pyr)
        {
            double SquareFirstTriangle = GetSquareTriangle(pyr.Points[pyr.MasIndexOsn[0]],
                                                           pyr.Points[pyr.MasIndexOsn[1]],
                                                           pyr.Points[pyr.MasIndexOsn[3]]);

            double SquareSecondTriangle = GetSquareTriangle(pyr.Points[pyr.MasIndexOsn[1]],
                                                            pyr.Points[pyr.MasIndexOsn[2]],
                                                            pyr.Points[pyr.MasIndexOsn[3]]);

            double res = SquareFirstTriangle + SquareSecondTriangle;
            return res;
        }

        public void GetPointsOfPyramid(Pyramid pyr)
        {
            Console.WriteLine("Основание пирамиды образуют точки:");
            foreach (int ind in pyr.MasIndexOsn)
            {
                Console.WriteLine(pyr.Points[ind]);
            }
            Console.WriteLine("Вершина не принадлежащая данной плоскости:");
            Console.WriteLine(pyr.Points[pyr.IndexNotOsn]);
        }

        public bool TryParsePyramid(Point3 p0, Point3 p1, Point3 p2, Point3 p3, Point3 p4, out Pyramid newP)
        {
            Point3[] allPs = new Point3[5] { p0, p1, p2, p3, p4 };
            Point3[] tempPoints = new Point3[4];
            List<int> indxList = new List<int>();
            int[] osnIndex = new int[4];

            // что я тут делаю понятно, тут ведь чистая комбинаторика
            // однако выглядит как то, что можно сильно упростить, но я чет не понял как

            int indNotOsn = -1;

            for (int i = 0; i < allPs.Length; i++)
            {
                for (int j = 0; j < allPs.Length; j++)
                {
                    if (j != i) { indxList.Add(j); }
                }

                for (int j = 0; j < indxList.Count; j++)
                {
                    tempPoints[j] = allPs[indxList[j]];
                }

                if (mat3x3Logic.IsVectorsCoplanar(tempPoints))
                {
                    if (indNotOsn != -1)
                    {
                        Console.WriteLine("Имеется более одного основания, а значит пирамида задана некорректно");
                        Console.WriteLine("Первому основанию не принадлежит точка {0}", allPs[indNotOsn]);
                        Console.WriteLine("Второму основанию не принадлежит точка {0}", allPs[i]);
                        newP = new Pyramid();
                        return false;
                    }
                    indNotOsn = i;
                    osnIndex = indxList.ToArray();
                }
                indxList.Clear();
            }

            newP = new Pyramid(allPs, osnIndex, indNotOsn);
            newP = new Pyramid(newP, FindSquareOsnPyr(newP), FindVolumePyr(newP));
            return true;
        }
    }
}
