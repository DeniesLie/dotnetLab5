using System.Numerics;
using ComplexNumbers;
using ComplexNumbers.Strategies;
using ConsoleApp;

Complex a, b;
CalculationContext context = new CalculationContext(new AdditionStrategy());

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

Console.Write($"Addition result: {context.ExecuteStrategy(a, b).ToPrettifiedString()}\n");

context.SetStrategy(new SubtractionStrategy());
Console.Write($"Subtraction result: {context.ExecuteStrategy(a, b).ToPrettifiedString()}\n");

context.SetStrategy(new MultiplicationStrategy());
Console.Write($"Multiplication result: {context.ExecuteStrategy(a, b).ToPrettifiedString()}\n");

context.SetStrategy(new DivisionStrategy());
Console.Write($"Division result: {context.ExecuteStrategy(a, b).ToPrettifiedString()}\n");

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
