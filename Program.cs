using System;

namespace Shape
{
  class Program
  {
    static void Main(string[] args)
    {
      // Shape Test
      Shape shape = new Shape();
      Console.WriteLine(shape);

      shape = new Shape("red", false);
      Console.WriteLine(shape);

      // Circle Test
      Circle circle = new Circle();
      Console.WriteLine(circle);

      circle = new Circle(3.5);
      Console.WriteLine(circle);

      circle = new Circle(3.5, "indigo", false);
      Console.WriteLine(circle);

      // Square Test
      Square square = new Square();
      Console.WriteLine(square);

      square = new Square(2.3);
      Console.WriteLine(square);

      square = new Square(5.8, "yellow", true);
      Console.WriteLine(square);
      
      //Viết mã kiểm thử cho interface Resizeable
      Console.WriteLine("Before resize: ");
      Console.WriteLine("Circle: ");
      Console.WriteLine(circle);
      Console.WriteLine("Square: ");
      Console.WriteLine(square);
      Console.WriteLine("Rectangle: ");
      Rectangle rectangle = new Rectangle(2.0, 3.0);
      Console.WriteLine(rectangle);
      Console.WriteLine("After resize: ");
      Random random = new Random();
      double percent = random.NextDouble() * 100;
      Console.WriteLine("Circle: ");
      circle.Resize(percent);
      Console.WriteLine(circle);
      Console.WriteLine("Square: ");
      square.Resize(percent);
      Console.WriteLine(square);
      Console.WriteLine("Rectangle: ");
      rectangle.Resize(percent);
      Console.WriteLine(rectangle);
      
      

    }
  }
}
