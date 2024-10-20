public class Shape_use
{
    private Shape[] shapes;
    private int count;

    public Shape_use(int size)
    {
        shapes = new Shape[size];
        count = 0;
    }

    public void add_shape(Shape shape)
    {
        if (count < shapes.Length)
        {
            shapes[count] = shape;
            count++;
        }
        else
        {
            Console.WriteLine("Array is full");
        }
    }

    public void remove_shape(int ind)
    {
        if (ind >= 0 && ind < count)
        {
            for (int i = ind; i < count - 1; i++)
            {
                shapes[i] = shapes[i + 1];
            }
            shapes[count - 1] = null;
            count--;
        }
        else
        {
            Console.WriteLine("Incorrect index");
        }
    }

    public void show_shapes()
    {
        for (int i = 0; i < count; i++)
        {
            shapes[i].Show();
        }
    }

    public void show_shapes_type(Type type)
    {
        for (int i = 0; i < count; i++)
        {
            if (shapes[i].GetType() == type)
            {
                shapes[i].Show();
            }
        }
    }

    public double all_area()
    {
        double total = 0;
        for (int i = 0; i < count; i++)
        {
            total += shapes[i].Area();
        }
        return total;
    }

    public double area_by_type(Type type)
    {
        double total = 0;
        for (int i = 0; i < count; i++)
        {
            if (shapes[i].GetType() == type)
            {
                total += shapes[i].Area();
            }
        }
        return total;
    }

    public void save_file(string filename)
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(filename, FileMode.Create)))
        {
            writer.Write(count);
            for (int i = 0; i < count; i++)
            {
                shapes[i].Save(writer);
            }
        }
    }

    public void load_file(string filename)
    {
        using (BinaryReader reader = new BinaryReader(File.Open(filename, FileMode.Open)))
        {
            count = reader.ReadInt32();
            shapes = new Shape[count];
            for (int i = 0; i < count; i++)
            {
                string type = reader.ReadString();
                Shape shape = null;
                if (type == "Triangle")
                {
                    shape = new Triangle(0, 0);
                }
                else if (type == "Rectangle")
                {
                    shape = new Rectangle(0, 0, 0, 0);
                }
                else if (type == "Circle")
                {
                    shape = new Circle(0, 0, 0);
                }
                shape.Load(reader);
                shapes[i] = shape;
            }
        }
    }
}
