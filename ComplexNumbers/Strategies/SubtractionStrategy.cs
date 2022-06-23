using System.Numerics;
using ComplexNumbers.Strategies;

namespace ComplexNumbers;

public class SubtractionStrategy: ICalculationStrategy
{
    public Complex Execute(Complex a, Complex b)
    {
        return a - b;
    }
}