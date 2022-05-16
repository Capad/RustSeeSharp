using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeeShark.Tests;

[TestClass]
public class ExampleMethodsTests
{
    [TestMethod]
    public void WhenInt32AddNumbersShouldReturnProperInt32Outcome()
    {
        var addedNumbers = ExampleMethods.add_numbers(10, 5);
        Assert.AreEqual(15, addedNumbers);
    }
}