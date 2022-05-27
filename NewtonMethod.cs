
namespace NumMethLab1
{
    internal class NewtonMethod : IMethod
    {
        public double F(double x)
        {
            return Math.Pow(x, 3) - 4 * Math.Pow(x, 2) - 15 * x + 18;
        }

        public double dF(double x)
        {
            return 3 * Math.Pow(x, 2) - 8 * x - 15;
        }

        public double dF2(double x)
        {
            return 6 * x - 8;
        }

        public void RunNewton(double a, double b, double e)
        {
            double x0 = b;
            double q = qF(a, b, b);
            IterCount(a, b, q, e);
            int n = 0;
            Console.WriteLine("n\txn\t\tf(xn)");
            Console.WriteLine(n + "\t" + string.Format("{0:F10}", x0) + "\t" + string.Format("{0:F10}", F(x0)));
            n++;
            double xn = x0 - (F(x0) / dF(x0));
            while (Math.Abs(F(xn)) > e)
            {
                Console.WriteLine(n + "\t" + string.Format("{0:F10}", xn) + "\t" + string.Format("{0:F10}", F(xn)));
                var temp = xn;
                xn = temp - F(temp) / dF(temp);
                n++;
            }
            Console.WriteLine(n + "\t" + string.Format("{0:F10}", xn) + "\t" + string.Format("{0:F10}", F(xn)));
        }

        public double qF(double a, double b, double x)
        {
            double m = Math.Min(dF(a), dF(b));
            double M = Math.Max(dF2(a), dF2(b));
            double xa = a;
            return Math.Abs(M * (x - xa) / (2 * m));
        }

        public void IterCount(double a, double b, double q, double e)
        {

            double k = Math.Log(((b - a) / e), Math.E);
            double m = Math.Log(1 / q, Math.E);
            double i = Math.Log2(k / m + 1);
            int ans = (int)(i + 1);
            Console.WriteLine("The assumption number of iterations : " + ans);

        }
        public void Result(double e)
        {
            double a = 5.5;
            double b = 6.5;
           
            RunNewton(a, b, e);
        }
    }
}
