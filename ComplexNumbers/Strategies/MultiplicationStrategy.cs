using System.Numerics;

namespace ComplexNumbers.Strategies;

public class MultiplicationStrategy: ICalculationStrategy
{
    public Complex Execute(Complex a, Complex b)
    {
        return a * b;
    }
}