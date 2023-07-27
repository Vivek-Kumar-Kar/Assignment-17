using System;

namespace Assignment17_27July
{
    

    class Program
    {
        static void Main(string[] args)
        {
            
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);
            Triangle triangle = new Triangle(3, 4, 5);

           
            Console.WriteLine("Circle Information:");
            circle.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Rectangle Information:");
            rectangle.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Triangle Information:");
            triangle.PrintInfo();
        }
    
 
        
        
    }
}
