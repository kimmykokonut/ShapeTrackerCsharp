using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System.Collections.Generic; 
using System;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class RectangleTests : IDisposable
  {
    public void Dispose()
    {
      Rectangle.ClearAll();
    }

    [TestMethod]
    public void RectangleConstructor_CreatesInstanceOfRectangle_Rectangle()
    {
      Rectangle newRectangle = new Rectangle(2, 5);
      Assert.AreEqual(typeof(Rectangle), newRectangle.GetType());
    }

    [TestMethod]
    public void GetSide1_ReturnsSide1_Int()
    {
      int length1 = 3;
      Rectangle newRectangle = new Rectangle(length1, 5);
      int result = newRectangle.Side1;
      Assert.AreEqual(length1, result);
    }

    [TestMethod]
    public void SetSide1_SetsValueOfSide1_Void()
    {
      Rectangle newRectangle = new Rectangle(3, 5);
      int newLength1 = 44;
      newRectangle.Side1 = newLength1;
      Assert.AreEqual(newLength1, newRectangle.Side1);
    }

    [TestMethod]
    public void GetSide2_ReturnsSide2_Int()
    {
      int length2 = 3;
      Rectangle newRectangle = new Rectangle (2, length2);
      int result = newRectangle.Side2;
      Assert.AreEqual(length2, result);
    }
    [TestMethod]
    public void SetSide2_SetsValueOfSide2_Void()
    {
      Rectangle newRectangle = new Rectangle(3,4);
      int newLength2 = 6;
      newRectangle.Side2 = newLength2;
      Assert.AreEqual(newLength2, newRectangle.Side2);
    }

    [TestMethod]
    public void GetArea_DeterminesArea_Int()
    {
      int length1 = 3;
      int length2 = 3;
      int area = length1 * length2;
      Rectangle test = new Rectangle(length1, length2);
      int result = test.GetArea();
      Assert.AreEqual(area, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllRectangleInstances_List()
    {
      Rectangle rect1 = new Rectangle(2, 3);
      Rectangle rect2 = new Rectangle(21, 3);
      Rectangle rect3 = new Rectangle(1, 3);
      List<Rectangle> expected = new List<Rectangle> { rect1, rect2, rect3 };
      List<Rectangle> actualResult = Rectangle.GetAll();
      CollectionAssert.AreEqual(expected, actualResult);
    }
    [TestMethod]
    public void ClearAll_DeletesAllRectangleInList_Void()
    {
      Rectangle rect1 = new Rectangle(2, 3);
      Rectangle rect2 = new Rectangle(21, 3);
      Rectangle rect3 = new Rectangle(1, 3);
      List<Rectangle> expected = new List<Rectangle> { };
      Rectangle.ClearAll();
      CollectionAssert.AreEqual(expected, Rectangle.GetAll());
    }

  }
}
