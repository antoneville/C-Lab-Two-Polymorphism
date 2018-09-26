using System;

namespace two_dimensional 
{
    class Line : Shape
    {
        private int verticeOne;
        private int verticeTwo;
        public Line(int verticeOne, int verticeTwo, int x, int y, string color) : base(color)
        {
            this.verticeOne = verticeOne;
            this.verticeTwo = verticeTwo;

            Vertex init = new Vertex(x,y);
            base.Translate(ref init);
        }

        public int VerticeOne
        {
            get { return verticeOne; }
            set { this.verticeOne = value; }
        }         

        public int VerticeTwo
        {
            get { return verticeTwo; }
            set { this.verticeTwo = value; }
        }

        public override string ToString()
        {
            return String.Format("Line Class\nThe Line Vertices are: {0} and {1}", verticeOne, verticeTwo);
        }

        public override string Translate(ref Vertex useable)
        {
            double safeTransX = useable.X;
            double safeTransY = useable.Y;

            return String.Format("Value after Translation of X: {0} \nValue after Translation of Y: {1}", safeTransX, safeTransY);
        }
    }
}