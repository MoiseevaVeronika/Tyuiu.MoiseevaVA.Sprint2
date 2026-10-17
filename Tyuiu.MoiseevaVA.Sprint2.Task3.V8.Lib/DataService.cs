using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MoiseevaVA.Sprint2.Task3.V8.Lib
{
    public class DataService : ISprint2Task3V8
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 0)
            {
                y = (Math.Sin(x) + Math.Cos(x)) / (Math.Cos(x) - Math.Sin(x));
            }
            else
            {
                if (x == 0)
                {
                    y = (Math.Pow(x, 2) - Math.Cos(x * x) + 10) / (Math.Pow(x, 2) - Math.Sin(x * x) + 12);
                }
                else
                {
                    if (-12 < x && x < 0)
                    {
                        y = Math.Pow(1 + 3 / Math.Pow(x, 2), x);

                    }
                    else
                    {
                        y = x + 10 * x - (5 / x);

                    }
                }

            }
            return Math.Round(y, 3);
        }
    }
}
