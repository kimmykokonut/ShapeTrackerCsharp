using System;
using ShapeTracker.Models;

namespace ShapeTracker
{

  public class Program
  {
    static void Main()
    {
      Triangle testTriangle = new Triangle(17,4,4);
      Console.WriteLine(testTriangle.GetType());
      Console.WriteLine($"Side one of triangle: {testTriangle.Side1} ");
      Console.WriteLine($"Side two of the triangle: {testTriangle.Side2}");
      Console.WriteLine($"Side three of the triangle: {testTriangle.Side3}");
      Console.WriteLine("Want to know what type of triangle?");
      Console.WriteLine("calculating...");
      Console.WriteLine($"Your triangle is: {testTriangle.CheckType()}");
    }
  }
}