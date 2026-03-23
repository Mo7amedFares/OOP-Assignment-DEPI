namespace FirstProject
{
    public class Point3D:IComparable<Point3D>
    {
        private double x;
        private double y;
        private double z;

        public Point3D() : this(0, 0, 0)
        {

        }

        public Point3D(double x , double y): this(x, y, 0)
        {
        }

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override string ToString()
        {
            return $"Point Coordinates: ({x}, {y}, {z})";
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Point3D point)
                return false;

            return this.x == point.x && this.y == point.y && this.z == point.z;
        }

        public int CompareTo(Point3D? other)
        {
            if (other is null) return 1;
            if (this.x==other.x)
            {
                if(this.y==other.y)
                {
                    if(this.z==other.z)
                        return 0;
                    else if(this.z>other.z)
                        return 1;
                    else
                        return -1;
                }
                else if(this.y>other.y)
                    return 1;
                else
                    return -1;
            }
            return this.x > other.x ? 1 : -1;
        }

        public static bool operator == (Point3D point1, Point3D point2)
        {
            if(ReferenceEquals(point1, point2))
                return true;

            if (point1 is null || point2 is null)
                return false;

            return point1.Equals(point2);
        }
        public static bool operator !=(Point3D point1, Point3D point2)
        {
            return !(point1 == point2);
        }

        public object Clone()
        {
            return new Point3D(this.x, this.y, this.z);
        }
    }
}
