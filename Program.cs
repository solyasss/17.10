public class Client
{
    public static void Main()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Clear(); 
        
        Shape_use help = new Shape_use(10);
        bool back = false;

        while (!back)
        {
            Console.WriteLine("\n----Shape Menu----");
            Console.WriteLine("1. Add triangle");
            Console.WriteLine("2. Add rectangle");
            Console.WriteLine("3. Add circle");
            Console.WriteLine("4. Show all shapes");
            Console.WriteLine("5. Show shapes by type of");
            Console.WriteLine("6. Count all area");
            Console.WriteLine("7. Count all area by type");
            Console.WriteLine("8. Save to file");
            Console.WriteLine("9. Load fron file");
            Console.WriteLine("10. Go back!");
            Console.Write("Choose option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter base and height of triangle: ");
                    double Base_1 = Convert.ToDouble(Console.ReadLine());
                    double Height_1 = Convert.ToDouble(Console.ReadLine());
                    help.add_shape(new Triangle(Base_1, Height_1));
                    break;
                case "2":
                    Console.Write("Enter coordinates of the rectangle (x1, y1, x2, y2): ");
                    double x1 = Convert.ToDouble(Console.ReadLine());
                    double y1 = Convert.ToDouble(Console.ReadLine());
                    double x2 = Convert.ToDouble(Console.ReadLine());
                    double y2 = Convert.ToDouble(Console.ReadLine());
                    help.add_shape(new Rectangle(x1, y1, x2, y2));
                    break;
                case "3":
                    Console.Write("Enter center (x, y) and radius of the circle: ");
                    double cx = Convert.ToDouble(Console.ReadLine());
                    double cy = Convert.ToDouble(Console.ReadLine());
                    double radius = Convert.ToDouble(Console.ReadLine());
                    help.add_shape(new Circle(cx, cy, radius));
                    break;
                case "4":
                    help.show_shapes();
                    break;
                case "5":
                    Console.WriteLine("Enter type: ");
                    string type = Console.ReadLine();
                    Type shape_type = null;

                    if (type == "Triangle")
                        shape_type = typeof(Triangle);
                    else if (type == "Rectangle")
                        shape_type = typeof(Rectangle);
                    else if (type == "Circle")
                        shape_type = typeof(Circle);
                    else
                    {
                        Console.WriteLine("Unknown type");
                        break;
                    }
                    help.show_shapes_type(shape_type);
                    break;
                case "6":
                    Console.WriteLine($"Total area: {help.all_area()}");
                    break;
                case "7":
                    Console.WriteLine("Enter type: ");
                    type = Console.ReadLine();
                    shape_type = null;

                    if (type == "Triangle")
                        shape_type = typeof(Triangle);
                    else if (type == "Rectangle")
                        shape_type = typeof(Rectangle);
                    else if (type == "Circle")
                        shape_type = typeof(Circle);
                    else
                    {
                        Console.WriteLine("Unknown type");
                        break;
                    }
                    Console.WriteLine($"Total area of {type.ToLower()}: {help.area_by_type(shape_type)}");
                    break;
                case "8":
                    Console.Write("Enter name of file to save: ");
                    string save = Console.ReadLine();
                    help.save_file(save);
                    break;
                case "9":
                    Console.Write("Enter filename to load: ");
                    string load= Console.ReadLine();
                    help.load_file(load);
                    break;
                case "10":
                    back = true;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}
