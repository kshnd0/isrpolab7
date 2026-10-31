using CalcLib;
using Xunit;

namespace CalcLib.Tests;

public class MathUtilsTests
{
    [Theory]
    [InlineData(12, 18, 6)]
    [InlineData(0, 7, 7)]
    [InlineData(13, 13, 13)]
    [InlineData(100, 75, 25)]
    public void Gcd_ReturnsCorrectValue(long a, long b, long expected) 
        => Assert.Equal(expected, MathUtils.Gcd(a, b));

    [Fact]
    public void Gcd_NegativeArguments_Throw() 
        => Assert.Throws<ArgumentOutOfRangeException>(() => MathUtils.Gcd(-4, 2));

    [Theory]
    [InlineData(2, true)]
    [InlineData(97, true)]
    [InlineData(1, false)]
    [InlineData(9, false)]
    [InlineData(7919, true)]
    public void IsPrime_ReturnsCorrectValue(int n, bool expected) 
        => Assert.Equal(expected, MathUtils.IsPrime(n));
    [Theory]
    [InlineData(4, 6, 12)]
    [InlineData(3, 5, 15)]
    [InlineData(0, 9, 0)]
    public void Lcm_ReturnsCorrectValue(long a, long b, long expected) 
        => Assert.Equal(expected, MathUtils.Lcm(a, b));

    [Fact]
    public void Factorial_5_Returns120() 
        => Assert.Equal(120, MathUtils.Factorial(5));

    [Fact]
    public void Factorial_0_Returns1() 
        => Assert.Equal(1, MathUtils.Factorial(0));

    [Fact]
    public void Factorial_Negative_Throws() 
        => Assert.Throws<ArgumentOutOfRangeException>(() => MathUtils.Factorial(-1));

    [Fact]
    public void Factorial_Large_Overflows() 
        => Assert.Throws<OverflowException>(() => MathUtils.Factorial(21));
}