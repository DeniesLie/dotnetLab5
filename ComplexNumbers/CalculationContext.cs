using System.Numerics;
using ComplexNumbers.Strategies;

namespace ComplexNumbers;

public class CalculationContext
{
    private ICalculationStrategy _strategy;

    public CalculationContext(ICalculationStrategy strategy)
    {
        SetStrategy(strategy);
    }
    
    public void SetStrategy(ICalculationStrategy strategy)
    {
        _strategy = strategy;
    }

    public Complex ExecuteStrategy(Complex a, Complex b)
    {
        return _strategy.Execute(a, b);
    }
}