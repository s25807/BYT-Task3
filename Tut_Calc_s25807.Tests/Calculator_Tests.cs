namespace Tut_Calc_s25807.Tests;

public class Tests
{
    private readonly Calculator calculator = new Calculator();

    [Test]
    public void TestAddition()
    {
        Assert.That(calculator.Calculate(5, 5, '+'), Is.EqualTo(10));
        Assert.That(calculator.Calculate(27, 2, '+'), Is.EqualTo(29));
        Assert.That(calculator.Calculate(12, 7.2, '+'), Is.EqualTo(19.2).Within(0.001));
        Assert.That(calculator.Calculate(15, -75, '+'), Is.EqualTo(-60));
        Assert.That(calculator.Calculate(0, 3, '+'), Is.EqualTo(3));
    }

    [Test]
    public void TestSubtraction()
    {
        Assert.That(calculator.Calculate(-5, 5, '-'), Is.EqualTo(-10));
        Assert.That(calculator.Calculate(27, 2, '-'), Is.EqualTo(25));
        Assert.That(calculator.Calculate(12, -7.2, '-'), Is.EqualTo(19.2).Within(0.001));
        Assert.That(calculator.Calculate(15, 75, '-'), Is.EqualTo(-60));
        Assert.That(calculator.Calculate(0, 3, '-'), Is.EqualTo(-3));
    }

    [Test]
    public void TestMultiplication()
    {
        Assert.That(calculator.Calculate(1, 5, '*'), Is.EqualTo(5));
        Assert.That(calculator.Calculate(27, 2, '*'), Is.EqualTo(54));
        Assert.That(calculator.Calculate(12, 7.2, '*'), Is.EqualTo(86.4).Within(0.001));
        Assert.That(calculator.Calculate(15, -5, '*'), Is.EqualTo(-75));
        Assert.That(calculator.Calculate(0, -3, '*'), Is.EqualTo(0));
    }

    [Test]
    public void TestDivision()
    {
        Assert.That(calculator.Calculate(1, 5, '/'), Is.EqualTo(0.2).Within(0.001));
        Assert.That(calculator.Calculate(27, 2, '/'), Is.EqualTo(13.5).Within(0.001));
        Assert.That(calculator.Calculate(12, -6, '/'), Is.EqualTo(-2).Within(0.001));
        Assert.That(calculator.Calculate(50, 60, '/'), Is.EqualTo(0.833).Within(0.001));
        Assert.Throws<DivideByZeroException>(() => { calculator.Calculate(1, 0, '/'); });
    }

    [Test]
    public void TestInvalidOperation()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => { calculator.Calculate(5, 5, '%'); });
    }
}