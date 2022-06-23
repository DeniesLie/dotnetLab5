using System.Numerics;

namespace ComplexNumbers.Strategies.LogicalStrategies;

public interface ILogicalStrategy
{
    public bool Execute(Complex a, Complex b);
}