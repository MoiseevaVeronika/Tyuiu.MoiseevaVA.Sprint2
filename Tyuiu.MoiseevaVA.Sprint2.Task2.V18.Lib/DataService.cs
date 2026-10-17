using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MoiseevaVA.Sprint2.Task2.V18.Lib
{

    public class DataService : ISprint2Task2V18
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if
            ((x >= 3 && x <= 5 && y >= 3 && y <= 7) ||

            (x == 2 && (y == 6 || y == 7)) ||

            (x >= 6 && x <= 8 && y >= 5 && y <= 7) ||

            (x >= 6 && x <= 13 && (y == 8 || y == 9)) ||

            (x == 12 && y >= 3 && y <= 7) ||

            (x == 13 && (y == 6 || y == 7)) ||

            (x >= 11 && x <= 12 && (y == 10 || y == 11)) ||

            (x >= 6 && x <= 7 && y == 10) ||
            (x >= 3 && x <= 7 && y == 11) ||
            (x == 7 && y == 12))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;

            

        }
    }
}
