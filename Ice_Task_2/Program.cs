using System.Drawing;

namespace Ice_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                while (true) // Loop until user chooses to exit
                {
                    Console.WriteLine("\nChoose a shape to calculate the area:");
                    Console.WriteLine("1. Rectangle");
                    Console.WriteLine("2. Circle");
                    Console.WriteLine("3. Exit");
                    Console.Write("Enter your choice: ");

                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        // Get user input for Rectangle
                        Console.Write("Enter length: ");
                        double length;
                        while (!double.TryParse(Console.ReadLine(), out length) || length <= 0)
                        {
                            Console.Write("Invalid input. Enter a valid length: ");
                        }

                        Console.Write("Enter width: ");
                        double width;
                        while (!double.TryParse(Console.ReadLine(), out width) || width <= 0)
                        {
                            Console.Write("Invalid input. Enter a valid width: ");
                        }

                        // Create and display rectangle
                        Rectangle rect = new Rectangle("Rectangle", length, width);
                        rect.Display();
                    }
                    else if (choice == "2")
                    {
                        // Get user input for Circle
                        Console.Write("Enter radius: ");
                        double radius;
                        while (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
                        {
                            Console.Write("Invalid input. Enter a valid radius: ");
                        }

                        // Create and display circle
                        Circle circ = new Circle("Circle", radius);
                        circ.Display();
                    }
                    else if (choice == "3")
                    {
                        Console.WriteLine("Exiting program...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                    }
                }
            }
        }
    }


 