using System;
using System.IO;

 public abstract class Shape
{
   public abstract double Area();
   public abstract void Show();
   public abstract void Save(BinaryWriter writer);
   public abstract void Load(BinaryReader reader);
}

