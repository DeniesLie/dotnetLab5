using System.Numerics;

namespace ComplexNumbers.Strategies.ArithmeticStrategies;

public interface IArithmeticStrategy
{
    Complex Execute(Complex a, Complex b);
}