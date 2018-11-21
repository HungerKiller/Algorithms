namespace AlgoLearning.Recursive
{
    public class Factorial
    {
        public static int CalculateFactorial(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * CalculateFactorial(n - 1);
        }
    }
}
