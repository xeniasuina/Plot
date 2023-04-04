using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plot
{
    class Calculations
    {
        static void Main(string[] args)
        {

        }




        public abstract class Integral

        {

            public Integral(double a, double b, int n)

            {

                this.a = a; this.b = b; this.n = n;



                Solve();



                accuracy = Math.Abs(Exact_value(a, b) - square);

            }

            public static double F(double x)

            {

                return 1 / Math.Sqrt(1 + x * x);

            }

            protected static double Exact_value(double a, double b)

            {

                return Math.Log(Math.Abs(b + Math.Sqrt(1 + b * b))) -

                Math.Log(Math.Abs(a + Math.Sqrt(1 + a * a)));

            }

            abstract protected void Solve();

            public double Square

            {

                get

                {

                    return square;

                }

            }

            public double Accuracy //погрешность 

            {

                get

                {

                    return accuracy;

                }

            }

            public static volatile bool Killed;

            public static bool operator <(Integral x1, Integral x2)

            {

                if (x1.accuracy < x2.accuracy) return true;

                return false;

            }

            public static bool operator >(Integral x1, Integral x2)

            {

                if (x1.accuracy > x2.accuracy) return true;

                return false;

            }

            public override string ToString()

            {

                //return base.ToString();

                string s;

                if (Killed) return "";

                s = Square.ToString() + " / " + Accuracy.ToString();

                return s;

            }

            protected double square, accuracy, a, b;

            protected int n;

        }

        public sealed class Rectangles : Integral //метод прямоугольников

        {

            public Rectangles(double a, double b, int n) : base(a, b, n) { }

            override protected void Solve()

            {

                double yn = 0, y0, x0 = a, Delta = (b - a) / n;

                for (int i = 0; i < n; i++, yn += y0, x0 += Delta)

                {

                    if (Killed) { square = -1; return; }

                    y0 = F((2 * x0 + Delta) / 2);

                }

                square = yn * Delta;

            }

        }

        public sealed class Trapezoids : Integral //метод трапеций

        {

            public Trapezoids(double a, double b, int n) : base(a, b, n) { }

            override protected void Solve()

            {

                double yn = 0, y0, Delta = (b - a) / n, x0 = a + Delta;

                for (int i = 1; i < n; i++, yn += y0, x0 += Delta)

                {

                    if (Killed) { square = -1; return; }

                    y0 = F(x0);

                }

                square = Delta * ((F(a) + F(b)) / 2 + yn);

            }

        }

        public sealed class Simpsons : Integral //метод симпсона

        {

            public Simpsons(double a, double b, int n) : base(a, b, n) { }

            override protected void Solve()

            {

                double yn1 = 0, yn2 = 0, y0, Delta = (b - a) / n, x0 = a + Delta;

                for (int i = 1; i < n; i += 2, yn1 += y0, x0 += 2 * Delta)

                {

                    if (Killed == true) { square = -1; return; }

                    y0 = F(x0);

                }

                x0 = a + 2 * Delta;

                for (int i = 2; i < n - 1; i += 2, yn2 += y0, x0 += 2 * Delta)

                {

                    if (Killed == true) { square = -1; return; }

                    y0 = F(x0);

                }

                square = (b - a) / 3 / n * (F(a) + F(b) + 4 * yn1 + 2 * yn2);

            }

        }

    }

}

