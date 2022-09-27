using MySeventhProjectTest;

namespace MySeventhProjecTest.UnitTests;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void addNumbersTest1()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        var result = calculator.addNumbers(2, 5);

        // Assert
        Assert.AreEqual(7, result);
    }

    [TestMethod]
    public void addNumbersTest2()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        var result = calculator.addNumbers(5, 10);

        // Assert
        Assert.AreEqual(15, result);
    }
}
