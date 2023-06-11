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
      
      //Tạo một mảng các đối tượng hình học trong đó có ít nhất một Square. Với mỗi phần tử trong mảng, hiển thị diện tích của nó, nếu phần tử đó là một IColorable, gọi phương thức HowToColor()
      Shape[] shapes = new Shape[3];
      shapes[0] = new Circle(3.5, "indigo", false);
      shapes[1] = new Rectangle(2.0, 3.0);
      shapes[2] = new Square(5.8, "yellow", true);
      foreach (Shape shape1 in shapes)
      {
        Console.WriteLine(shape1);
        if (shape1 is Square)
        {
          Console.WriteLine("Area: " + ((Square) shape1).getArea());
        }
        else if(shape1 is Rectangle)
        {
          Console.WriteLine("Area: " + ((Rectangle) shape1).getArea());
        }
        else if (shape1 is Circle)
          {
          Console.WriteLine("Area: " + ((Circle) shape1).getArea());
        }
        if (shape1 is IColorable)
        {
          ((Square) shape1).HowToColor();
        }
      }

    }
  }
}
