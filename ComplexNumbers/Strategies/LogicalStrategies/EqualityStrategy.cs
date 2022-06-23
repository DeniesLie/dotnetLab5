using System.Numerics;

namespace ComplexNumbers.Strategies.LogicalStrategies;

public class EqualityStrategy : ILogicalStrategy
{
    public bool Execute(Complex a, Complex b)
    {
        return a == b;
    }
}