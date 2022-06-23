using System.Numerics;
using ComplexNumbers;
using ComplexNumbers.Strategies;
using ComplexNumbers.Strategies.ArithmeticStrategies;
using ComplexNumbers.Strategies.LogicalStrategies;
using ConsoleApp;

Complex a, b;
CalculationContext context = new CalculationContext(
    new AdditionStrategy(), 
    new EqualityStrategy());

try
{
    ReadNumbers();
}
catch (FormatException ex)
{
    Console.WriteLine("Invalid format, try again!");
    ReadNumbers();

}
catch (OverflowException ex)
{
    Console.WriteLine("Possible value overflow, try again!");
    ReadNumbers();
}

Console.Write($"Addition result: {context.ExecuteArithmeticStrategy(a, b).ToPrettifiedString()}\n");

context.SetArithmeticStrategy(new SubtractionStrategy());
Console.Write($"Subtraction result: {context.ExecuteArithmeticStrategy(a, b).ToPrettifiedString()}\n");

context.SetArithmeticStrategy(new MultiplicationStrategy());
Console.Write($"Multiplication result: {context.ExecuteArithmeticStrategy(a, b).ToPrettifiedString()}\n");

context.SetArithmeticStrategy(new DivisionStrategy());
Console.Write($"Division result: {context.ExecuteArithmeticStrategy(a, b).ToPrettifiedString()}\n");

Console.Write($"Are equals: {context.ExecuteLogicalStrategy(a, b)}\n");
context.SetLogicalStrategy(new InequalityStrategy());
Console.Write($"Are not equals: {context.ExecuteLogicalStrategy(a, b)}\n");


void ReadNumbers()
{
    Console.WriteLine("Enter number a");
    a = ReadNumber();
    Console.WriteLine("Enter number b");
    b = ReadNumber();
}

Complex ReadNumber()
{
    Console.Write("Enter real part: ");
    var real = Double.Parse(Console.ReadLine());
    Console.Write("Enter imaginary part: ");
    var imaginary = Double.Parse(Console.ReadLine());

    return new Complex(real, imaginary);
}
