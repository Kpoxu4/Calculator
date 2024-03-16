namespace Calculator
{
    public class ArithmeticOperations
    {
        public static double Arithmetic(double x, double y, char arithmetic)
        {
            double result = 0;
            switch (arithmetic)
            {
                case '+':
                    result = x + y;
                    break;
                case '-':
                    result = x - y;
                    break;
                case '*':
                    result = x * y;
                    break;
                case '/':
                    if (y != 0)
                        result = x / y;
                    break;
            }
            return result;
        }
    }
}
