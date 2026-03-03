using CalculatorModule;
using GreetingModule;
using Xunit;

namespace Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_ShouldReturnSum()
    {
        var calc = new Calculator();
        var result = calc.Add(2, 3);
        Assert.Equal(5, result);
    }
}

public class GreeterTests
{
    [Fact]
    public void Greet_ShouldReturnHello()
    {
        var greeter = new Greeter();
        var result = greeter.Greet("World");
        Assert.Equal("Hello, World!", result);
    }
}