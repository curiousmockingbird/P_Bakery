using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread bread = new Bread();
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }

    [TestMethod]
    public void SetQuantity_SetsQuantityOfBreadNeeded_Int()
    {
      //Arrange
      int quantity = 3;
      Bread bread = new Bread();
      //Act
      int result = bread.Quantity;
      //Assert
      Assert.AreEqual(quantity, result);
    }
  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry pastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), pastry.GetType());
    }
  }
}