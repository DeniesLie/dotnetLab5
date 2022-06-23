using System.Numerics;

namespace ComplexNumbers.Strategies.ArithmeticStrategies;

public class MultiplicationStrategy: IArithmeticStrategy
{
    public Complex Execute(Complex a, Complex b)
    {
        return a * b;
    }
}