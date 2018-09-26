using System;

//2D space
namespace two_dimensional
{
    //
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

        //appropiate properties - getter and setters
        public int X {
            set { this.x = value; }
            get { return x; }
        }
        public int Y {
            set { this.y = value; }
            get { return y; }
        }

        static void Main() 
        {
            //Creating a Vertex 
            Vertex tu = new Vertex(9, 6);

            //Copying Values from Vertex 1 [tu] to Vertex 2 [jf]
            Vertex jf = tu;

            //Testing Original Vertex
            Console.WriteLine("*Vertex 1* \nX value: {0} \nY value: {1}\n",tu.X, tu.Y);
            //Testing Vertex 2 copied Vertex 1 values correctly
            Console.WriteLine("*Vertex 2* \nX value: {0} \nY value: {1}\n",jf.X, jf.Y);

            //Changing Vertex 2 values
            jf.X = 3;
            jf.Y = 12;

            //Checking if change successful
            Console.WriteLine("**Changed Vertex Values**\n*Vertex 2* \nX value: {0} \nY value: {1}\n",jf.X, jf.Y);
        }

    }
}
