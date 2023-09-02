class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Enter the radius of the circle");
        double radius = double.Parse(Console.ReadLine());
        IShape circle = new Circle(radius);
        Console.WriteLine($"Area: {circle.CalculateArea()}");
        Console.WriteLine($"Perimeter: {circle.CalculatePerimeter()}");

        Console.WriteLine();

        Console.WriteLine("Enter the length of the rectangle");
        double length = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the width of the rectangle");
        double width = double.Parse(Console.ReadLine());

        IShape rectangle = new Rectangle(length, width);
        Console.WriteLine($"Area: {rectangle.CalculateArea()}");
        Console.WriteLine($"Perimeter: {rectangle.CalculatePerimeter()}");

        Console.ReadLine();

    }
}
