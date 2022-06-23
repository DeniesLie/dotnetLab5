using System.Numerics;

namespace ConsoleApp;

public static class PrintExtensions
{
    public static string ToPrettifiedString(this Complex a)
    {
        var operationChar = a.Imaginary > 0 ? '+' : '-';
        return $"{a.Real} {operationChar} {Math.Abs(a.Imaginary)}*i";
    }
}