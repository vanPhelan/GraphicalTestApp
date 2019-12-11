using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Vector4
    {
        //makes the 3 values public
        public float x;
        public float y;
        public float z;
        public float w;

        //sets the these to the public values
        public Vector4(float x, float y, float z, float w)// : this()
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        // the vector squared (squared)
        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z + w * w);
        }

        // returns x,y,z squared
        public float MagnitudeSqr()
        {
            return (x * x + y * y + z * z + w * w);
        }

        //gets the Dot product of the Vector3
        public float Dot(Vector4 Current)
        {
            float Dot = Current.x * x + Current.y * y + z * Current.z + w * Current.w;
            return (Dot);
        }

        //Returns a new string value making it the same
        public void Normalize()
        {
            float m = Magnitude();
            this.x /= m;
            this.y /= m;
            this.z /= m;
            this.w /= m;
        }

        //// Multiplys the Vector3 on all fronts then subtracting it with another
        public Vector4 Cross(Vector4 rhs)
        {
            return new Vector4(
           y * rhs.z - z * rhs.y,
           z * rhs.x - x * rhs.z,
           x * rhs.y - y * rhs.x,
           0);
        }

        // Vector4 + Vector4
        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(
                lhs.x + rhs.x,
                lhs.y + rhs.y,
                lhs.z + rhs.z,
                lhs.w + rhs.w);
        }

        // Vector4 - Vector4
        public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(
                lhs.x - rhs.x,
                lhs.y - rhs.y,
                lhs.z - rhs.z,
                lhs.w - rhs.w);
        }

        // Vector4 * Vector4
        public static Vector4 operator *(Vector4 lhs, float rhs)
        {
            return new Vector4(
                lhs.x * rhs,
                lhs.y * rhs,
                lhs.z * rhs,
                lhs.w * rhs);
        }
    }
}