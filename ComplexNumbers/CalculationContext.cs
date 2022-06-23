using System.Numerics;
using ComplexNumbers.Strategies;
using ComplexNumbers.Strategies.ArithmeticStrategies;
using ComplexNumbers.Strategies.LogicalStrategies;

namespace ComplexNumbers;

public class CalculationContext
{
    private IArithmeticStrategy _arithmeticStrategy;
    private ILogicalStrategy _logicalStrategy;

    public CalculationContext(IArithmeticStrategy arithmeticStrategy, ILogicalStrategy logicalStrategy)
    {
        _arithmeticStrategy = arithmeticStrategy;
        _logicalStrategy = logicalStrategy;
    }
    
    public void SetArithmeticStrategy(IArithmeticStrategy strategy)
    {
        _arithmeticStrategy = strategy;
    }
    
    public void SetLogicalStrategy(ILogicalStrategy strategy)
    {
        _logicalStrategy = strategy;
    }

    public Complex ExecuteArithmeticStrategy(Complex a, Complex b)
    {
        return _arithmeticStrategy.Execute(a, b);
    }
    
    public bool ExecuteLogicalStrategy(Complex a, Complex b)
    {
        return _logicalStrategy.Execute(a, b);
    }
}