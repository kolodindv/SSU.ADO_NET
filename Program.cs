using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ADO_task1
//{
//    class Program
//    {
//        public static void PyramidValidation()
//        {
//            Point3[] points = new Point3[5];
//            Console.WriteLine("Вводите 5 точек в формате:\nx, y, z");
//            for (int i = 0; i < points.Length; i++)
//            {
//                bool getOkey = false;
//                while (!getOkey)
//                {
//                    try
//                    {
//                        Console.WriteLine($"координаты {i + 1}:");
//                        points[i] = GetPoint3FromString();
//                        if (coordString.Length == 3)
//                        {

//                        }

//                    }
//            for (int i = 0; i < points.Length; i++)
//                    {
//                        Console.WriteLine(points[i]);
//                    }
//                }
//                public static Point3 GetPoint3FromString()
//                {
//                    string[] delims = { ", " };
//                    double[] coordDouble = new double[3];
//                    string[] coordString = Console.ReadLine().Split(delims, StringSplitOptions.RemoveEmptyEntries);

//                    for (int i = 0; i < coordString.Length; i++)
//                    {
//                        coordDouble[i] = double.Parse(coordString[i]);
//                    }
//                    getOkey = true;
//                }
//                catch
//                {
//                    Console.WriteLine("Некорректный форматный ввод координат точки");
//                }
//            }
//            return new Point3(coordDouble[0], coordDouble[1], coordDouble[2]);
//        }
//        static void Main(string[] args)
//        {

//            //Pyramid.TestPyramidClass();

//            PyramidValidation();
//            Console.ReadLine();

//        }
//    }
//}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ADO_task1
//{
//    class Program
//    {
//        public static void PyramidValidation()
//        {
//            Point3[] points = new Point3[5];
//            Console.WriteLine("Вводите 5 точек в формате:\nx, y, z");
//            for (int i = 0; i < points.Length; i++)
//            {
//                bool getOkey = false;
//                while (!getOkey)
//                {
//                    try
//                    {
//                        Console.WriteLine($"координаты {i + 1}:");
//                        points[i] = GetPoint3FromString();
//                        for (int j = 0; j < points.Length; j++)
//                        {
//                            Console.WriteLine(points[j]);
//                        }

//                    }


//                }
//            }
//            public static Point3 GetPoint3FromString()
//            {
//                string[] delims = { ", " };
//                double[] coordDouble = new double[3];
//                string[] coordString = Console.ReadLine().Split(delims, StringSplitOptions.RemoveEmptyEntries);

//                for (int i = 0; i < coordString.Length; i++)
//                {
//                    coordDouble[i] = double.Parse(coordString[i]);
//                }
//                getOkey = true;
//            }
//                catch
//            {
//                Console.WriteLine("Некорректный форматный ввод координат точки");
//            }
//        }
//            return new Point3(coordDouble[0], coordDouble[1], coordDouble[2]);
//    }
//    static void Main(string[] args)
//    {

//        //Pyramid.TestPyramidClass();

//        PyramidValidation();
//        Console.ReadLine();

//    }
//}
//}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ADO_task1
//{
//    class Program
//    {
//        public static void PyramidValidation()
//        {
//            Point3[] points = new Point3[5];
//            Console.WriteLine("Вводите 5 точек в формате:\nx, y, z");
//            for (int i = 0; i < points.Length; i++)
//            {
//                bool getOkey = false;
//                while (!getOkey)
//                {
//                    try
//                    {
//                        Console.WriteLine($"координаты {i + 1}:");
//                        points[i] = GetPoint3FromString();
//                        if (coordString.Length == 3)
//                        {

//                        }

//                    }
//            for (int i = 0; i < points.Length; i++)
//                    {
//                        Console.WriteLine(points[i]);
//                    }
//                }
//                public static Point3 GetPoint3FromString()
//                {
//                    string[] delims = { ", " };
//                    double[] coordDouble = new double[3];
//                    string[] coordString = Console.ReadLine().Split(delims, StringSplitOptions.RemoveEmptyEntries);

//                    for (int i = 0; i < coordString.Length; i++)
//                    {
//                        coordDouble[i] = double.Parse(coordString[i]);
//                    }
//                    getOkey = true;
//                }
//                catch
//                {
//                    Console.WriteLine("Некорректный форматный ввод координат точки");
//                }
//            }
//            return new Point3(coordDouble[0], coordDouble[1], coordDouble[2]);
//        }
//        static void Main(string[] args)
//        {

//            //Pyramid.TestPyramidClass();

//            PyramidValidation();
//            Console.ReadLine();

//        }
//    }
//}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ADO_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleInterface consoleInterface = new ConsoleInterface();
            //consoleInterface.TestPyramidClass();

           Pyramid newPyr = consoleInterface.ConsolePyramidValidation();
            
            //Hashcode
            
            
            
            Console.ReadLine();
        }
    }

}

