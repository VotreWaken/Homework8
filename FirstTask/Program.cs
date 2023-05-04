using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreeDimensionVector _vector = new ThreeDimensionVector(2, 5, 7);
            Console.WriteLine($"Multiply = {_vector.Multiply(6)}");
            ThreeDimensionVector three_Vector = new ThreeDimensionVector(3, 4, 6);
            Console.WriteLine($"Addition = {_vector.Addition(three_Vector)}");
            Console.WriteLine($"Subtraction = {_vector.Subtraction(three_Vector)}");

        }
    }

    struct ThreeDimensionVector
    {
        public float x;
        public float y;
        public float z;

        public ThreeDimensionVector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public ThreeDimensionVector Multiply(float num)
        {
            return new ThreeDimensionVector(x * num, y * num, z * num);
        }
        public ThreeDimensionVector Addition(ThreeDimensionVector temp)
        {
            float x = this.x + temp.x;
            float y = this.y + temp.y;
            float z = this.z + temp.z;

            return new ThreeDimensionVector(x, y, z);
        }
        public ThreeDimensionVector Subtraction(ThreeDimensionVector temp)
        {
            float x = this.x - temp.x;
            float y = this.y - temp.y;
            float z = this.z - temp.z;

            return new ThreeDimensionVector(x, y, z);
        }
        public override string ToString()
        {
            return $"({x}, {y}, {z})";
        }

    }
}
