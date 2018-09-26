using System;

namespace two_dimensional 
{
    class Line : Shape
    {
 
        public Line(int verticeOne, int verticeTwo, int x, int y, string color) : base(color)
        {
            this.VerticeOne = verticeOne;
            this.VerticeTwo = verticeTwo;
            this.Color = color;

            Vertex init = new Vertex(x,y);
            this.Translate(ref init);
        }

        public int VerticeOne
        { get; set; }         

        public int VerticeTwo
        { get; set; }

        public override string ToString()
        {
            return String.Format("\nLine Class\nThe Line Vertices are: {0} and {1}", VerticeOne, VerticeTwo);
        }

        public override string Translate(ref Vertex useable)
        {
            return String.Format("Value after Translation of X: {0} \nValue after Translation of Y: {1}", useable.X, useable.Y);
        }
    }
}