using System;

namespace two_dimensional
{
    class Circle : Shape
    {
        public Circle (int x, int y, int radius, string color) : base(color)
        {
            this.Radius = radius;
            this.Color = color;
            this.X = x;
            this.Y = y;
        }

        //Properties
        public int Radius { get; set; }

        public int X { get; set; }
        public int Y { get; set; } 

        public override string ToString()
        {
            return String.Format("\nThe Radius value: {0} \nColor: {1}", Radius, Color);
        }

        public override string Translate(ref Vertex useable)
        {
            return String.Format("\nValue after Translation of X: {0} \nValue after Translation of Y: {1}", x, y);
        }

        public double area()
        {
            double areaCalc = Math.Pow(Math.PI * Radius, 2);
            return areaCalc;
        }
    }
}