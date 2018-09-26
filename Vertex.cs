using System;

//2D space
namespace two_dimensional
{
    //Vertex Class
    class Vertex
    {  

        //Constructor
        public Vertex (int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public Vertex() 
        {
        }

        //appropiate properties
        public int X { set; get; }
        public int Y { set; get; }
    }
}
