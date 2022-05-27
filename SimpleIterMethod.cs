

namespace NumMethLab1
{
    internal class SimpleIterMethod : IMethod
    {
        public void RunSimlpeIter(double e)
        {
            int n = 0;
            double x0 = 6.75;
            double x1;
            Console.WriteLine("n\txn\t\ttxn - fi(xn)");
            while (true)
            {
                x1 = Math.Pow(10 * Math.Pow(x0, 2) - 11 * x0 - 70, 1.0 / 3);
                Console.WriteLine(n + "\t" + string.Format("{0:F10}", x0) + "\t" + string.Format("{0:F10}", x0 - x1));
                if (Math.Abs(x1 - x0) < e)
                {
                    break;
                }
                n++;
                x0 = x1;
            }
        }

        public void IterCount(double e, double a, double b, double q)
        {
            
            double logTop = Math.Log(Math.Abs(b - a)/((1 - q) * e), Math.E);
            double logBottom = Math.Log(1 / q, Math.E);
            int ans = (int)(logTop / logBottom + 1);
            Console.WriteLine("The assumption number of iterations: " + ans);           
        }
        public void Result(double e)
        {
            double q = 0.9;
            double a = 6.75;
            double b = 7.25;
            IterCount(e, a, b, q);
            RunSimlpeIter(e);
        }
    }
}
