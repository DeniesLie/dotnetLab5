using System.Numerics;

namespace ComplexNumbers.Strategies;

public class DivisionStrategy: ICalculationStrategy
{
    public Complex Execute(Complex a, Complex b)
    {
        return a/b;
    }
}