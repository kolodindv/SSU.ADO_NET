using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_task1
{
    public class Pyramid
    {
        // поля
        public Point3[] Points { get; }
        public int[] MasIndexOsn { get; }
        public int IndexNotOsn { get; }
        public double SquareOsnPyramid { get; }
        public double VolumePyryamid { get; }        
        // конструкторы
        public Pyramid() { }
        public Pyramid(Point3[] ps, int[] masIndOsn, int indNoOsn)
        {
            Points = ps;
            MasIndexOsn = masIndOsn;
            IndexNotOsn = indNoOsn;
        }        
        public Pyramid(Point3[] ps, int[] masIndOsn, int indNoOsn, double sqrOsnPyr, double vlmPyr)
            : this(ps, masIndOsn, indNoOsn)
        {            
            SquareOsnPyramid = sqrOsnPyr;
            VolumePyryamid = vlmPyr;
        }
        public Pyramid(Pyramid pyr) 
            : this(pyr.Points, pyr.MasIndexOsn, pyr.IndexNotOsn, pyr.SquareOsnPyramid, pyr.VolumePyryamid) { }
        public Pyramid(Pyramid pyr, double sqrOsnPyr, double vlmPyr) : this(pyr)
        {
            SquareOsnPyramid = sqrOsnPyr;
            VolumePyryamid = vlmPyr;
        }




    }
}
