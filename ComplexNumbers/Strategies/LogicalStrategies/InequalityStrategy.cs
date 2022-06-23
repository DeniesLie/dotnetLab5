using System.Numerics;

namespace ComplexNumbers.Strategies.LogicalStrategies;

public class InequalityStrategy : ILogicalStrategy
{
    public bool Execute(Complex a, Complex b)
    {
       return a != b;
    }
}