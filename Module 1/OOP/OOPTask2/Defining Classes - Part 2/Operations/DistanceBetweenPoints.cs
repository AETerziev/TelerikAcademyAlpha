using System;

namespace Defining_Classes___Part_2
{
    public static class DistanceBetweenPoints
    {
       public static double GetDistance(Point3D firstPoint,Point3D secondPoint)
        {
            double distance = Math.Sqrt(Math.Pow((firstPoint.XCoord-secondPoint.XCoord),2) + Math.Pow((firstPoint.YCoord - secondPoint.YCoord), 2) + Math.Pow((firstPoint.ZCoord - secondPoint.ZCoord), 2));
            return distance;
        }
    }
}
