

namespace NumMethLab1
{
    internal class DichotomyMethod : IMethod
    {
        public double F(double x)
        {
            return Math.Pow(x, 3) - 8 * Math.Pow(x, 2) + 9 * x + 18;
        }

        public void RunDichotomy(double a, double b, double e)
        {
            double x0 = (a + b) / 2;
            int n = 0;
            double x1 = 0;
            Console.WriteLine("n\txn\t\tf(xn)");
            while (true)
            {
                Console.WriteLine(n + "\t" + string.Format("{0:F10}", x0) + "\t" + string.Format("{0:F10}", F(x0)));
                if (F(a) * F(x0) >= 0)
                {
                    a = x0;
                }
                if (F(b) * F(x0) >= 0)
                {
                    b = x0;
                }
                x1 = x0;
                x0 = (a + b) / 2;
                if (Math.Abs(x0 - x1) < e)
                {
                    break;
                }
                n++;
            }
        }
        public void IterCount(double a, double b, double e)
        {
            int ans = (int)Math.Log2((b-a)/e);
            Console.WriteLine("The assumption number of iterations: " + ans);
        }
        public void Result(double e)
        {
            double a = -3;
            double b = 0;
            IterCount(a, b, e);
            RunDichotomy(a, b, e);
        }
    }
}