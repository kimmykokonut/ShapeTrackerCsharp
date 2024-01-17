using System;
using System.Collections.Generic;
using ShapeTracker.Models;
using ShapeTracker.UserInterfaceModels;

namespace ShapeTracker
{

  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine(ShapeTracker.UserInterfaceModels.WelcomeBanner.Welcome);
      Console.WriteLine("Choose 't' to make a triangle and determine it's type or 'r' to make a rectangle and calculate it's area...");
      string userInput = Console.ReadLine(); 
      if (userInput == "t" || userInput == "T")
      {
        Console.WriteLine("We'll calculate what type of triangle you have based off of the lengths of the triangle's 3 sides.");
        CreateTriangle();
      }
      else if (userInput == "r" || userInput == "R")
      {
        Console.WriteLine("We'll calculate the area of a rectangle based off of the lengths of the rectangle's 2 sides.");
        CreateRectangle();
      }
      else{
        Console.WriteLine("Goodbye");
      }
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
      Console.WriteLine(ShapeTracker.UserInterfaceModels.SubMenuBanner.menuBanner);
      Console.WriteLine("Your result is: " + result + ".");
      Console.WriteLine("-----------------------------------------");
      Navigate();
    }
    static void ShowList()
    {
      List<Triangle> triangles = Triangle.GetAll();
      if (triangles.Count > 0)
      {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine($"Here is the list of Triangles: ");
        Console.WriteLine("-----------------------------------------");
        foreach (Triangle triangle in triangles)
        {
          Console.WriteLine($"Triangle Side1: {triangle.Side1}, Side2: {triangle.Side2}, Side3: {triangle.GetSide3()}, Type: {triangle.CheckType()}");
        }
        Console.WriteLine($"Do you want to clear the list? ");
        Console.WriteLine("Please enter yes or no");
        string userResponse = Console.ReadLine();
        if (userResponse == "yes" || userResponse == "Yes")
        {
          ClearList();
        }
        else if (userResponse == "no" || userResponse == "No")
        {
          Navigate();
        }
      }
      else 
      {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("No List");
        Console.WriteLine("-----------------------------------------");
        Navigate();
      }

    }

    static void ClearList()
    {
      Triangle.ClearAll();
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Your list has been cleared.");
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
        Console.WriteLine(ShapeTracker.UserInterfaceModels.GoodbyeBanner.Goodbye);      }
      }
      static void CreateRectangle()
    {
      Console.WriteLine("Please enter a number:");
      string stringNumber1 = Console.ReadLine();
      Console.WriteLine("Enter another number:");
      string stringNumber2 = Console.ReadLine();
      int length1 = int.Parse(stringNumber1);
      int length2 = int.Parse(stringNumber2);
      Rectangle rect = new Rectangle(length1, length2);
      ConfirmOrEditRectangle(rect);
    }
    static void ConfirmOrEditRectangle(Rectangle rect)
    {
      Console.WriteLine("Please confirm that you entered in  your rectangle correctly:");
      Console.WriteLine($"Side 1 has a length of {rect.Side1}."); //using Properties
      Console.WriteLine($"Side 2 has a length of {rect.Side2}."); //using auto-impl. properties
      Console.WriteLine("Is that correct? Enter 'yes' to proceed or 'no' to re-enter the rectangle's sides");
      string userInput = Console.ReadLine();
      if (userInput == "yes")
      {
        GetRectArea(rect);
      }
      else
      {
        Console.WriteLine("Let's fix your rectangle. Please enter the 2 sides again: ");
        CreateRectangle();
      }
    }
    static void GetRectArea(Rectangle rect)
    {
      int result = rect.GetArea();
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Your rectangle's area is: " + result + ".");
      Console.WriteLine("-----------------------------------------");
      Main();
      // instead of main, navigate to a rect-nav or update the nav for triangle/rect.
    }

  }
}