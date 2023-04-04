namespace Plot
{
    public static class IntegralCalculation
    {
        public static Func<double, double> Function { get; set; }

        public static double LeftRectangle(double a, double b, int n)
        {
            var h = (b - a) / n;
            var sum = 0d;
            for (var i = 0; i <= n - 1; i++)
            {
                var x = a + i * h;
                sum += Function(x);
            }

            var result = h * sum;
            return result;
        }

        public static double RightRectangle(double a, double b, int n)
        {
            var h = (b - a) / n;
            var sum = 0d;
            for (var i = 1; i <= n; i++)
            {
                var x = a + i * h;
                sum += Function(x);
            }

            var result = h * sum;
            return result;
        }

        public static double CentralRectangle(double a, double b, int n)
        {
            var h = (b - a) / n;
            var sum = (Function(a) + Function(b)) / 2;
            for (var i = 1; i < n; i++)
            {
                var x = a + h * i;
                sum += Function(x);
            }

            var result = h * sum;
            return result;
        }

        public static double TrapeziumMethod(double a, double b, int n)
        {
            var s = Function(a);
            var h = (b - a) / n;

            for (var i = 1; i < n; i += 1)
            {
                s += Function(a + i * h);
            }
            
            s += Function(b) / 2;
            return s * h;
        }

        public static double SimpsonMethod(double a, double b, int n)
        {
            var h = (b - a) / n;
            var sum1 = 0d;
            var sum2 = 0d;
            for (var k = 1; k <= n; k++)
            {
                var xk = a + k * h;
                if (k <= n - 1)
                {
                    sum1 += Function(xk);
                }

                var xk_1 = a + (k - 1) * h;
                sum2 += Function((xk + xk_1) / 2);
            }

            var result = h / 3d * (1d / 2d * Function(a) + sum1 + 2 * sum2 + 1d / 2d * Function(b));
            return result;
        }
    }
}
