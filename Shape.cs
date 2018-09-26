using System;

namespace two_dimensional 
{
    class Shape 
    {
        public Shape(string color)
        {
            this.Color = color;
        }

        public Shape()
        {
        }

        public string Color { get; set; }

        public override string ToString()
        {
            return String.Format("The Color of the Shape is: {0}", this.Color);
        }

        public virtual string Translate(ref Vertex useable)
        {
            double transX = useable.X;
            double transY = useable.Y;

            return String.Format("Value after Translation of X: {0} \nValue after Translation of Y: {1}", transX, transY);
        }
    }
}
