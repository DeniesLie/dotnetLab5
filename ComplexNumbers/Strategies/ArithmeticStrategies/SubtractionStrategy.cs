using System.Numerics;
using ComplexNumbers.Strategies;

namespace ComplexNumbers.Strategies.ArithmeticStrategies;

public class SubtractionStrategy: IArithmeticStrategy
{
    public Complex Execute(Complex a, Complex b)
    {
        return a - b;
    }
}