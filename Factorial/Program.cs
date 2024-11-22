

using System.Numerics;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static BigInteger FactoIterative(int n) 
        {
            BigInteger result = 1;
            for (int i = 0; i <= n; i++) 
            { 
                result *= i;
            }
            return result;
        }
        public static BigInteger FactoRecursive(int n)
        {
            return (n > 1) ? n * FactoRecursive(n - 1) : 1;
        }
    }
}
