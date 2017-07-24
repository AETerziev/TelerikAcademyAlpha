using System;
using System.Collections.Generic;
using System.IO;

namespace Defining_Classes___Part_2
{
    public static class PathStorage
    {

        public static void SavePath(Path path, string fileName)
        {
            using (StreamWriter streamWrite = new StreamWriter(fileName))
            {
                foreach (Point3D point in path.Points)
                {
                    streamWrite.WriteLine(point);
                }
            }
        }

        public static string LoadPath(string fileName)
        {
            using (StreamReader streamRead = new StreamReader(fileName))
            {
                return streamRead.ReadLine();
            }

        }
    }
}
