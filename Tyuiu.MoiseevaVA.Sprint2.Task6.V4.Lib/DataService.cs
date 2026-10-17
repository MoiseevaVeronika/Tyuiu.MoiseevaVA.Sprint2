using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MoiseevaVA.Sprint2.Task6.V4.Lib
{
    public class DataService : ISprint2Task6V4
    {
        public string FindCardSuit(int value)
        {
            switch (value)
            {
                case 1: return "пики";
                case 2: return "трефы";
                case 3: return "бубны";
                case 4: return "червы";
                default:  throw new ArgumentException($"номер должен быть от 1 до 4 {value}");

            }
        }
    }
}
