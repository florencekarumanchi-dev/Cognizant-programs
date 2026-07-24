using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests;

[TestFixture]
public class CalculatorTests
{
    private Calculator calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [TearDown]
    public void TearDown()
    {
        calculator = null;
    }

    [Test]
    public void Add_Test()
    {
        int result = calculator.Add(10, 20);

        Assert.That(result, Is.EqualTo(30));
    }

    [TestCase(5,10,15)]
    [TestCase(20,30,50)]
    [TestCase(-5,10,5)]
    [TestCase(0,0,0)]
    public void Add_TestCases(int a,int b,int expected)
    {
        int result = calculator.Add(a,b);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Ignore("Ignored Example")]
    [Test]
    public void Ignore_Test()
    {
        Assert.Fail();
    }
}