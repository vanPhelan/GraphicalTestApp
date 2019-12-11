using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Vector3
    {
        //makes the 3 values public
        public float x;
        public float y;
        public float z;

        public Vector3() : this(0f, 0f, 0f)
        {

        }

        //sets the these to the public values
        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        //prints the numbers
        public override string ToString()
        {
            return "{ " + x + " , " + y + " , " + z + " }";
        }
        //gets the minimum numbers
        public static Vector3 Min(Vector3 a, Vector3 b)
        {
            return new Vector3(Math.Min(a.x, b.x), Math.Min(a.y, b.y), Math.Min(a.z, b.z));
        }

        //get the maximum numbers
        public static Vector3 Max(Vector3 a, Vector3 b)
        {
            return new Vector3(Math.Max(a.x, b.x), Math.Max(a.y, b.y), Math.Max(a.z, b.z));
        }

        //Range of the Vector
        public static Vector3 Clamp(Vector3 t, Vector3 a, Vector3 b)
        {
            return Max(a, Min(b, t));
        }
        // Vector3 + Vector3
        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        }

        // Vector3 - Vector3
        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        }

        // Vector3 * Vector3
        public static Vector3 operator *(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        }

        // Vector3 / Vector3
        public static Vector3 operator /(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        }

        // Vector3 * x,y,z
        public static Vector3 operator *(Vector3 lhs, float rhs)
        {
            return new Vector3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        }

        // the vector squared (squared)
        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }

        // returns x,y,z squared
        public float MagnitudeSqr()
        {
            return (x * x + y * y + z * z);
        }

        //the distance between 2 Vector3
        public float Distance(Vector3 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            float diffZ = z - other.z;
            return (float)Math.Sqrt(diffX * diffX + diffY * diffY + diffZ * diffZ);
        }

        //gets the Dot product of the Vector3
        public float Dot(Vector3 Current)
        {
            float Dot = Current.x * x + Current.y * y + z * Current.z;
            return (Dot);
        }

        // Multiplys the Vector3 on all fronts then subtracting it with another
        public Vector3 Cross(Vector3 other)
        {
            return new Vector3(
                y * other.z - z * other.y,
                z * other.x - x * other.z,
                x * other.y - y * other.x);
        }
    }
}