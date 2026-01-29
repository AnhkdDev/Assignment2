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
            if (b == 0 || sign == SIGN.DIVIDE) 
                return 0;
            switch (sign)
            {
                case SIGN.DIVIDE:
                    return a / b;
                default:
                    break;
            }
            return 0d;
        }
    }

}
