using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MoiseevaVA.Sprint2.Task7.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (x < 0||x>Math.PI)
            {
                return false;
            }
            if (y<0||y>0.5)
            {
                return false;
            }
            if (y>Math.Sin(x))
            {
                return false;
            }
            return true;
        }
    }
}
