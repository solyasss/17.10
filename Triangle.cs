public class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public Triangle(double b, double h)
    {
        Base = b;
        Height = h;
    }

    public override void Show()
    {
        Console.WriteLine($"Your triangle with base: {Base} and height: {Height}");
    }

    public override double Area()
    {
        return 0.5 * Base * Height;
    }

    public override void Save(BinaryWriter writer)
    {
        writer.Write("Triangle");
        writer.Write(Base);
        writer.Write(Height);
    }

    public override void Load(BinaryReader reader)
    {
        Base = reader.ReadDouble();
        Height = reader.ReadDouble();
    }
}