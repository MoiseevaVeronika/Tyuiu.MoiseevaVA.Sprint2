using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MoiseevaVA.Sprint2.Task4.V28.Lib
{
    public class DataService : ISprint2Task4V28
    {
        public double Calculate(double x, double y)
        {
            double z;

            // Проверяем условие
            if (x < y * 2 - 10)
            {
                // Если условие верное
                z = Math.Pow(1 + (y + 2) / (x * x), x);
            }
            else
            {
                // Если условие ложное (ветка "иначе")
                double chislitel = 2 * (x * x) - Math.Pow(Math.Cos(y), 2) + 12;
                double znamenatel = (y * y) - Math.Pow(Math.Sin(x), 2) + 9;
                z = chislitel / znamenatel;
            }

            return Math.Round(z, 3);
        }
    }
}
