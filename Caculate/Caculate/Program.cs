namespace Caculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public enum SIGN
    {
        PLUS, MINUS, MULTIPLY, DIVIDE
    }

    public class Calculator
    {
        public double Calculate(SIGN sign, double a, double b)
        {
            switch (sign)
            {
<<<<<<< HEAD
                case SIGN.DIVIDE:
                    if (b == 0) return 0;
                    return a / b;
=======
                case SIGN.MULTIPLY:
                    return a * b;
>>>>>>> feature/CPL26/PhucNDHE187145/implement_multiply
                default:
                    break;
            }
            return 0d;
        }
    }

}
