using System;

//2D space
namespace two_dimensional
{
    //Vertex Class
    class Vertex
    {
        //endpoint of a line
        private int x;
        //origin of a circle
        private int y;   

        //Constructor
        public Vertex (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Vertex() 
        {
        }

        //appropiate properties - getter and setters
        public int X {
            set { this.x = value; }
            get { return x; }
        }
        public int Y {
            set { this.y = value; }
            get { return y; }
        }
    }
}
