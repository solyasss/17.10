public class Rectangle : Shape
{
    public double PosX1 { get; set; }
    public double PosY1 { get; set; }
    public double PosX2 { get; set; }
    public double PosY2 { get; set; }

    public Rectangle(double x1, double y1, double x2, double y2)
    {
        PosX1 = x1;
        PosY1 = y1;
        PosX2 = x2;
        PosY2 = y2;
    }

    public override void Show()
    {
        Console.WriteLine($" Your rectangle with coordinates  ({PosX1}, {PosY1}) and ({PosX2}, {PosY2})");
    }

    public override double Area()
    {
        return Math.Abs((PosX2 - PosX1) * (PosY2 - PosY1));
    }

    public override void Save(BinaryWriter writer)
    {
        writer.Write("Rectangle");
        writer.Write(PosX1);
        writer.Write(PosY1);
        writer.Write(PosX2);
        writer.Write(PosY2);
    }

    public override void Load(BinaryReader reader)
    {
        PosX1 = reader.ReadDouble();
        PosY1 = reader.ReadDouble();
        PosX2 = reader.ReadDouble();
        PosY2 = reader.ReadDouble();
    }
}