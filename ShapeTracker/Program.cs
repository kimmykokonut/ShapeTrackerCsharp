using System;
using System.Collections.Generic;
using ShapeTracker.Models;

namespace ShapeTracker
{

  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to the Shape Tracker app!");
      Console.WriteLine("We'll calculate what type of triangle you have based off of the lengths of the triangle's 3 sides.");
      CreateTriangle();
      
    }
    static void CreateTriangle()
    {
      Console.WriteLine("Please enter a number:");
      string stringNumber1 = Console.ReadLine();
      Console.WriteLine("Enter another number:");
      string stringNumber2 = Console.ReadLine();
      Console.WriteLine("Enter a third number:");
      string stringNumber3 = Console.ReadLine();
      int length1 = int.Parse(stringNumber1);
      int length2 = int.Parse(stringNumber2);
      int length3 = int.Parse(stringNumber3);
      Triangle tri = new Triangle(length1, length2, length3);
      ConfirmOrEditTriangle(tri);
    }
    static void ConfirmOrEditTriangle(Triangle tri)
    {
      Console.WriteLine("Please confirm that you entered in  your triangle correctly:");
      Console.WriteLine($"Side 1 has a length of {tri.Side1}."); //using Properties
      Console.WriteLine($"Side 2 has a length of {tri.Side2}."); //using auto-impl. properties
      Console.WriteLine($"Side 3 has a length of {tri.GetSide3()}.");
      Console.WriteLine("Is that correct? Enter 'yes' to proceed or 'no' to re-enter the triangle's sides");
      string userInput = Console.ReadLine();
      if (userInput == "yes")
      {
        CheckTriangleType(tri);
      }
      else
      {
        Console.WriteLine("Let's fix your triangle. Please enter the 3 sides again: ");
        CreateTriangle();
      }
    }
    static void CheckTriangleType(Triangle tri)
    {
      string result = tri.CheckType();
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Your result is: " + result + ".");
      Console.WriteLine("-----------------------------------------");
      Navigate();
    }
    static void ShowList()
    {
      List<Triangle> triangles = Triangle.GetAll();
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine($"Here is the list of Triangles: ");
      Console.WriteLine("-----------------------------------------");
      foreach (Triangle triangle in triangles)
      {
        Console.WriteLine($"Triangle Side1: {triangle.Side1}, Side2: {triangle.Side2}, Side3: {triangle.GetSide3()}, Type: {triangle.CheckType()}");
      }
      Navigate();
    }
    static void Navigate()
    {
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("What's next?");
      Console.WriteLine("Would you like to check a new triangle (new) or see the Triangle list (list)?");
      Console.WriteLine("Please enter 'new' to check the type of a new triangle, or 'list' to see the list of triangles created. To exit, enter any other key.");
      string userResponse = Console.ReadLine();
      if (userResponse == "new" || userResponse == "New")
      {
        Main();
      }
      else if (userResponse == "list" || userResponse == "List")
      {
        ShowList();
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }
    }
  }
}