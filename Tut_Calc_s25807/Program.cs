namespace Tut_Calc_s25807;

public class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new();
        Console.WriteLine($"5.04 + 2.01 = {calculator.Calculate(5.04, 2.01, '+')}");
        Console.WriteLine($"19 - 12.2 = {calculator.Calculate(19, 12.2, '-')}");
        Console.WriteLine($"55 * 32 = {calculator.Calculate(55, 32, '*')}");
        Console.WriteLine($"44 / 11 = {calculator.Calculate(44, 11, '/')}");
        try
        {
            Console.WriteLine($"8 / 0 = {calculator.Calculate(8, 0, '/')}");
        }
        catch (DivideByZeroException f)
        {
            Console.WriteLine(f.Message);
        }
        
    }
}