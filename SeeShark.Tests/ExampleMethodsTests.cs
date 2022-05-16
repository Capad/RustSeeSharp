using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeeShark.Tests;

[TestClass]
public class ExampleMethodsTests
{
    [TestMethod]
    public void AddNumbersShouldReturnSameResult()
    {
        var rustAddedNumbers = RustExampleMethods.add_numbers(10, 5);
        var sharpAddedNumbers = SharpExampleMethods.add_numbers(10, 5);
        Assert.AreEqual(sharpAddedNumbers, rustAddedNumbers);
    }

    [TestMethod]
    public void OppositeOfTrueShouldReturnFalse()
    {
        var rustBool = RustExampleMethods.get_opposite_bool(true);
        var sharpBool = SharpExampleMethods.get_opposite_bool(true);
        Assert.AreEqual(sharpBool, rustBool);
    }
    [TestMethod]
    public void OppositeOfFalseShouldReturnTrue()
    {
        var rustBool = RustExampleMethods.get_opposite_bool(false);
        var sharpBool = SharpExampleMethods.get_opposite_bool(false);
        Assert.AreEqual(sharpBool, rustBool);
    }
}