using System.Drawing;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point3D point1 = new Point3D(1 , 2 , 3);
            Point3D point2 = new Point3D(1, 2, 3);
            if(point1.Equals(point2)) Console.WriteLine("Yes");
            else Console.WriteLine("No");
                
            if (point1==point2) Console.WriteLine("Yes");
            else Console.WriteLine("No");


            Point3D[] points = {
                new Point3D(2,1,0),
                new Point3D(1,5,0),
                new Point3D(1,2,0)
            };

            Array.Sort(points);

            foreach (var point in points)
            {
                Console.WriteLine(point);
            }
        }
    }
}
