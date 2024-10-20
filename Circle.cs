public class Circle : Shape
{
    public double Center_1 { get; set; }
    public double Center_2{ get; set; }
    public double Radius { get; set; }

    public Circle(double a, double b, double r)
    {
        Center_1 = a;
        Center_2 = b;
        Radius = r;
    }

    public override void Show()
    {
        Console.WriteLine($"Your circle with center ({Center_1}, {Center_2}) and radius {Radius}");
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public override void Save(BinaryWriter writer)
    {
        writer.Write("Circle");
        writer.Write(Center_1);
        writer.Write(Center_2);
        writer.Write(Radius);
    }

    public override void Load(BinaryReader reader)
    {
        Center_1 = reader.ReadDouble();
        Center_2 = reader.ReadDouble();
        Radius = reader.ReadDouble();
    }
}