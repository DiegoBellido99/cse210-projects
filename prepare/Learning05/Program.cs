using System;

class Program
{
    static void Main(string[] args)
    {
       List<Shapes> shapes= new List<Shapes>();

       shapes.Add(new Square(15,"azul"));
       shapes.Add(new Rectangle(15,10,"rojo"));
       shapes.Add(new Circle(10,"verde"));

       foreach(Shapes shapes1 in shapes)
       {
         string color = shapes1.GetColor();
         double area = Math.Round(shapes1.GetArea(),2);

         Console.WriteLine($"The {color} shape has an area of {area}");
       }      
    }
}
