namespace Tut_Calc_s25807;

public class Calculator
{
    public double Calculate(double A, double B, char Operation)
    {
        switch (Operation)
        {
            case '+':
                return A + B;
            case '-':
                return A - B;
            case '*':
                return A * B;
            case '/':
                if (B == 0) throw new DivideByZeroException("Division by zero is not allowed");
                return A / B;
            default:
                throw new ArgumentOutOfRangeException(nameof(Operation), Operation, null);
        }
    }
}