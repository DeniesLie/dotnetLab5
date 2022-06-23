using System.Numerics;

namespace ComplexNumbers.Strategies;

public class AdditionStrategy : ICalculationStrategy
{
    public Complex Execute(Complex a, Complex b)
    {
        return a + b;
    }
}