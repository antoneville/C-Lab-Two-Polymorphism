using System;

namespace two_dimensional
{
    class Test
    {
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


            //Creating a Shape
            Shape redobj = new Shape("Red");
            //Testing ToString Output of a Shape
            Console.WriteLine(redobj);
            //Testing the Translate Method
            Console.WriteLine(redobj.Translate(ref jf));
        
        }
    }
}