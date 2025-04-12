public class Program
{
    private static void Main(string[] args)
    {
        int numFactorial = Factorial(3);
        int numFibonnaci = Fibonacci(2);
        Console.WriteLine(numFibonnaci);

    }

    public static int Factorial(int n)
    {
        int r = 0;

        //Caso inductivo
        if (n > 1)
        {
            r = n * Factorial(n - 1);
        }
        if (n == 1)
        {
            r = 1;
        }
        return r;
    }

    public static int Fibonacci(int n)
    {
        int r = 0;
     

        //Caso inductivo
        if (n > 1)
        {
            r = Fibonacci(n-1) + Fibonacci(n - 2);
        }
        //Cso base
        if (n <= 1)
        {
            r = 1;
        }

        return r ;
    }
}