using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_task1.MathObjectLogic
{
    class Point3Logic
    {
        public bool TryParse(string inn, out Point3 p3)
        {
            string[] delims = { ", " };
            double[] coordDouble = new double[3];
            string[] coordString = inn.Split(delims, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < coordString.Length; i++)
            {
                coordDouble[i] = double.Parse(coordString[i]);
            }

            if (coordString.Length == 3)
            {               
                p3 = new Point3(coordDouble[0], coordDouble[1], coordDouble[2]);
                return true;
            }
            else 
            {
                p3 = new Point3();
                return false; 
            }
        }
    }
}
