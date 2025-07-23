namespace NthFibonnaci
{
    public class NthFibonacci   
    {
        public IEnumerable<int> GetFibonacci(int n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException(nameof(n), "n must be non-negative");
            if (n == 0) return new List<int> { 0 };
            if (n == 1) return new List<int> { 0, 1 };
            var fib = new List<int> { 0, 1 };
            for (int i = 2; i <= n; i++)
            {
                fib.Add(fib[i - 1] + fib[i - 2]);
            }
            return fib;
        }
    }
}
