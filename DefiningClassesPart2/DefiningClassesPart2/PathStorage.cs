using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    public static class PathStorage
    {
        private static string pathBegining = "Path:";

        public static List<Path> LoadPathsFromFile(string fileName)
        {
            List<Path> paths = new List<Path>();
            using (StreamReader reader = new StreamReader(fileName))
            {
                Path currentPath = new Path();
                List<Point3D> currentPoints = new List<Point3D>();
                while (!reader.EndOfStream)
                {
                    string input = reader.ReadLine();
                    if (input.StartsWith(pathBegining))
                    {
                        if (currentPoints.Count > 0)
                        {
                            currentPath.Points = currentPoints;
                            paths.Add(currentPath);
                        }
                        currentPoints.Clear();
                        continue;
                    }
                    currentPoints.Add(Point3DStatic.GetPointFromString(input));
                }
                if (currentPoints.Count > 0)
                {
                    currentPath.Points = currentPoints;
                    paths.Add(currentPath);
                }
            }
            return paths;
        }

        public static void SavePathsToFile(List<Path> paths, string fileName)
        {
            if (!File.Exists(fileName)) 
                File.Create(fileName);

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach(Path path in paths)
                {
                    writer.WriteLine("Path:");
                    foreach (Point3D point in path.Points)
                    {
                        writer.WriteLine(point.ToString());
                    }
                }
            }
        }
    }
}
