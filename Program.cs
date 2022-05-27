namespace NumMethLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double e = 0.001;
            IMethod method = null;

            Console.WriteLine("Choose your method:\n" +
                "1. Newton method\n" +
                "2. Simple iteration method\n" +
                "3. Dichotomy method\n");

            string methodNum = Console.ReadLine();

            Console.WriteLine("" +
                "e = 0.001\n" +
                "Do you want to change e?" +
                "(Y/N)");

            string change = Console.ReadLine().ToUpper();
            if (change == "Y")
            {
                Console.WriteLine("Enter e: ");
                e = double.Parse(Console.ReadLine());
            }
            else if (change != "N")
            {
                Console.WriteLine("Input invalid!\n" +
                    "e = 0.001");
            }
            switch (methodNum)
            {
                case "1":
                    method = new NewtonMethod();
                    break;
                case "2":
                    method = new SimpleIterMethod();
                    break;
                case "3":
                    method = new DichotomyMethod();
                    break;
            }
            method.Result(e);

            Console.WriteLine();
        }
    }
}