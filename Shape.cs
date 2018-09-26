using System;

namespace two_dimensional 
{
    class Shape 
    {
        private string color;

        public Shape(string color)
        {
            this.color = color;
        }

        public string Color 
        {
            get {return color;}
            set {this.color = value;}
        }

        public override string ToString()
        {
            return String.Format("The Color of the Shape is: {0}", this.Color);
        }

        public string Translate(ref Vertex useable)
        {
            double transX = useable.X;
            double transY = useable.Y;
        
            return String.Format("Value after Translation of X: {0} \nValue after Translation of Y: {1}", transX, transY);
        }
    }
}
