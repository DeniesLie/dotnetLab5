using System.Numerics;

namespace ComplexNumbers.Strategies.ArithmeticStrategies;

public class AdditionStrategy : IArithmeticStrategy
{
    public Complex Execute(Complex a, Complex b)
    {
        return a + b;
    }
}