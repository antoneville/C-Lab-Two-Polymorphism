using System;

namespace two_dimensional
{
    class Circle : Shape
    {
        private int radius;
        public Circle (int x, int y, int radius, string color) : base(color)
        {
            this.radius = radius;
            this.Color = color;

            Vertex init = new Vertex(x,y);
            this.Translate(ref init);
        }

        public int Radius 
        {
            get { return radius; }
            set { this.radius = value; }
        }

        public override string ToString()
        {
            return String.Format("\nThe Radius value: {0}", radius);
        }

        public override string Translate(ref Vertex useable)
        {
            double translatedX = useable.X;
            double translatedY = useable.Y;

            return String.Format("\nValue after Translation of X: {0} \nValue after Translation of Y: {1}", translatedX, translatedY);
        }

        public double area()
        {
            double areaCalc = Math.Pow(Math.PI * radius, 2);
            return areaCalc;
        }
    }
}