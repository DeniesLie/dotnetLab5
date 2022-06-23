using System.Numerics;

namespace ComplexNumbers.Strategies;

public interface ICalculationStrategy
{
    Complex Execute(Complex a, Complex b);
}