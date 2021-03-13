using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADO_task1.MathObjectLogic;

namespace ADO_task1
{
    class ConsoleInterface
    {
        private string com;
        private Point3[] points = new Point3[5];
        private Point3Logic point3Logic = new Point3Logic();
        private Mat3x3Logic mat3x3Logic = new Mat3x3Logic();
        private PyramidLogic pyramidLogic = new PyramidLogic();


        public void TestPyramidClass()
        {
            Point3 p0 = new Point3(0, 0, 0);
            Point3 p1 = new Point3(0, 0, 3);
            Point3 p2 = new Point3(0, 3, 0);
            Point3 p3 = new Point3(0, 3, 3);
            Point3 p4 = new Point3(8, 0, 0);

            Pyramid test;

            pyramidLogic.TryParsePyramid(p0, p1, p2, p3, p4, out test);
            pyramidLogic.GetPointsOfPyramid(test);

            Console.WriteLine("Площадь основания: {0}", test.SquareOsnPyramid);
            Console.WriteLine("Объем пирамиды:    {0}", test.VolumePyryamid);

            Console.WriteLine("Компланарность векторов в основании:     {0}",
                mat3x3Logic.IsVectorsCoplanar(test.Points[test.MasIndexOsn[0]], test.Points[test.MasIndexOsn[1]],
                                              test.Points[test.MasIndexOsn[2]], test.Points[test.MasIndexOsn[3]]));

            Console.WriteLine("Компланарность векторов не в основании:  {0}",
                mat3x3Logic.IsVectorsCoplanar(test.Points[test.MasIndexOsn[0]], test.Points[test.MasIndexOsn[1]],
                                              test.Points[test.MasIndexOsn[2]], test.Points[test.IndexNotOsn]));
        }

        private void GetFivePoint()
        {
            Console.WriteLine("Вводите 5 точек в формате:\nx, y, z");
            for (int i = 0; i < points.Length; i++)
            {
                bool getOkey = false;
                while (!getOkey)
                {
                    try
                    {
                        Console.WriteLine($"координаты {i + 1}:");
                        Point3 tempPoint;
                        if(point3Logic.TryParse(Console.ReadLine(), out tempPoint))
                        {
                            bool unicFlag = true;
                            foreach (var p in points)
                            {
                                if (tempPoint == p)
                                {
                                    unicFlag = false;
                                }
                            }
                            if (unicFlag)
                            {
                                points[i] = tempPoint;
                                getOkey = true;
                            }
                        } 
                    }
                    catch
                    {
                        Console.WriteLine("Некорректный форматный ввод координат точки");
                    }
                }
            }

            for (int j = 0; j < points.Length; j++)
            {
                Console.WriteLine(points[j]);
            }
        }

        private Pyramid PyramidMenu()
        {
            Pyramid newPyr;
            if (pyramidLogic.TryParsePyramid(points[0], points[1], points[2], points[3], points[4], out newPyr))
            {
                string pyrCom;

                bool stopPyrMenu = false;
                while (!stopPyrMenu)
                {
                    Console.WriteLine("Выберите желаемую команду по пирамиде:");
                    Console.WriteLine("'i': info по вершинам");
                    Console.WriteLine("'s': площадь основания");
                    Console.WriteLine("'v': объем");
                    Console.WriteLine("'e': выход");

                    pyrCom = Console.ReadLine();
                    switch (pyrCom)
                    {
                        case "i":
                            {
                                //newPyr.GetPointsOfPyramid();
                                break;

                            }
                        case "s":
                            {
                                Console.WriteLine(newPyr.SquareOsnPyramid);
                                break;
                            }
                        case "v":
                            {
                                Console.WriteLine(newPyr.VolumePyryamid);
                                break;
                            }
                        case "e":
                            {
                                Console.WriteLine("Нажмите любую кнопку для выхода");
                                //присвоение "флага" ниже только для читабельности получше
                                stopPyrMenu = true;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Некорректный выбор команды для пирамиды");
                                break;
                            }
                    }                    
                }

                return newPyr;
            }
            else
            {
                Console.WriteLine("Наблюдается ошибка в расположении точек, они не образуют 5 вершинную пирамиду");
                //метка в начало меню!
                return newPyr;
            }
        }

        public Pyramid ConsolePyramidValidation()
        {
            bool stopStartMenu = false;
            while (!stopStartMenu)
            {
                Console.WriteLine("Выберите желаемое:");
                Console.WriteLine("'p': ввод координат 5 вершин пирамиды");
                Console.WriteLine("'e': выход");
                com = Console.ReadLine();
                switch (com)
                {
                    case "p":
                        {
                            GetFivePoint();
                            return PyramidMenu();  
                        }
                    case "e":
                        {
                            Console.WriteLine("Нажмите любую кнопку для выхода");
                            stopStartMenu = true;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Некорректный выбор команды");
                            //метка на начало меню!
                            break;
                        }

                }                
            }
            return new Pyramid();
        }
    }
}
