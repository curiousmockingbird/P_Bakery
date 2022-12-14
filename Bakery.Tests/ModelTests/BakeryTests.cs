using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread bread = new Bread(3);
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }

    [TestMethod]
    public void SetQuantity_SetsQuantityOfBreadNeeded_Int()
    {
      //Arrange
      int quantity = 3;
      Bread bread = new Bread(quantity);
      //Act
      int result = bread.Quantity;
      //Assert
      Assert.AreEqual(quantity, result);
    }

    [TestMethod]
    public void CalcBreadOrderPrice_CalcsSingleLoafPrice_Int()
    {
      //Arrange
      int quantity = 1;
      Bread bread = new Bread(quantity);
      //Act
      int result = bread.CalcBreadOrderPrice();
      //Assert
      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void CalcBreadOrderPrice_CalcsPriceForTwoLoaves_Int()
    {
      //Arrange
      int quantity = 2;
      Bread bread = new Bread(quantity);
      //Act
      int result = bread.CalcBreadOrderPrice();
      //Assert
      Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void CalcBreadOrderPrice_CalcsPriceForEveryThirdLoaf_Int()
    {
      //Arrange
      int quantity = 3;
      Bread bread = new Bread(quantity);
      //Act
      int result = bread.CalcBreadOrderPrice();
      //Assert
      Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void GetTotal_ReturnsTotalOrderPriceForBread_Int()
    {
      //Arrange
      int quantity = 3;
      Bread bread = new Bread(quantity);
      //Act
      int result = bread.TotalPrice;
      //Assert
      Assert.AreEqual(10, result);
    }
  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry pastry = new Pastry(3);
      Assert.AreEqual(typeof(Pastry), pastry.GetType());
    }

    [TestMethod]
    public void SetQuantity_SetsQuantityOfPastryNeeded_Int()
    {
      //Arrange
      int quantity = 3;
      Pastry pastry = new Pastry(quantity);
      //Act
      int result = pastry.Quantity;
      //Assert
      Assert.AreEqual(quantity, result);
    }

    [TestMethod]
    public void CalcPastryOrderPrice_CalcsSinglePastry_Int()
    {
      //Arrange
      int quantity = 1;
      Pastry pastry = new Pastry(quantity);
      //Act
      int result = pastry.CalcPastryOrderPrice();
      //Assert
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void CalcPastryOrderPrice_CalcsTwoPastry_Int()
    {
      //Arrange
      int quantity = 2;
      Pastry pastry = new Pastry(quantity);
      //Act
      int result = pastry.CalcPastryOrderPrice();
      //Assert
      Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void CalcPastryOrderPrice_CalcsDealForPastries_Int()
    {
      //Arrange
      int quantity = 3;
      Pastry pastry = new Pastry(quantity);
      //Act
      int result = pastry.CalcPastryOrderPrice();
      //Assert
      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void GetTotal_ReturnsTotalOrderPriceForPastry_Int()
    {
      //Arrange
      int quantity = 3;
      Pastry pastry = new Pastry(quantity);
      //Act
      int result = pastry.TotalPrice;
      //Assert
      Assert.AreEqual(5, result);
    }
  }
}
