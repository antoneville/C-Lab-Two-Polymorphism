using System;


class Shape {
    private string color;

    public Shape(string color)
    {
        this.color = color;
    }

    public string Color {
        get {return color;}
        set {this.color = value;}
    }

    public override string ToString()
    {
        return String.Format("The Color of the Shape is: {0}", this.Color);
    }

    static void Main() 
    {
        Shape redobj = new Shape("Red");
        Console.WriteLine(redobj);
        
    }
}
