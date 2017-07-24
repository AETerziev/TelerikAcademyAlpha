using System;
using System.Collections.Generic;

namespace Defining_Classes___Part_2
{
   public class Path
    {
        public Path(IEnumerable<Point3D> points)
        {
            this.Points = points;
        }
        public IEnumerable<Point3D> Points
        {
            get;
            set;
        }

    }
}
