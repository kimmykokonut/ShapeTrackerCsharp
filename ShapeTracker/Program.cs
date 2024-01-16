using System;
using System.Collections.Generic; //directive for namespace
using ShapeTracker.Models;

namespace ShapeTracker
{

  class Program
  {
    static void Main()
    {
      List<Triangle> allTriangles = Triangle.GetAll();  //gets static list tri obj.
      Triangle testTriangle = new Triangle(3,4,5);
      Triangle secondTriangle = new Triangle(32, 74, 75);
      Triangle.ClearAll();
      if (allTriangles.Count == 0)
      {
        Console.WriteLine("There are no triangles!");
      }
      else
      {
        Console.WriteLine("----------");
        foreach (Triangle tri in allTriangles)
        {
          Console.WriteLine($"Side one of the triangle: {tri.GetSide1()}");
          Console.WriteLine($"Side two of the triangle: {tri.GetSide2()}");
          Console.WriteLine($"Side three of the triangle: {tri.GetSide3()}");
          Console.WriteLine("----------");

        }
      }
      // Console.WriteLine(testTriangle.GetType());
      // Console.WriteLine($"Side one of triangle: {testTriangle.GetSide1()} ");
      // Console.WriteLine($"Side two of the triangle: {testTriangle.GetSide2()}");
      // Console.WriteLine($"Side three of the triangle: {testTriangle.GetSide3()}");
      // Console.WriteLine("Want to know what type of triangle?");
      // Console.WriteLine("calculating...");
      // Console.WriteLine($"Your triangle is: {testTriangle.CheckType()}");
      // Console.WriteLine("Updating...");
      // testTriangle.SetSide1(44);
      // testTriangle.SetSide2(44);
      // testTriangle.SetSide3(70);
      // Console.WriteLine($"Actually, I've just changed the values of your triangle's sides to {testTriangle.GetSide1()}, {testTriangle.GetSide2()}, and {testTriangle.GetSide3()}.");
      // Console.WriteLine($"Now your triangle is: {testTriangle.CheckType()}.");
    }
  }
}