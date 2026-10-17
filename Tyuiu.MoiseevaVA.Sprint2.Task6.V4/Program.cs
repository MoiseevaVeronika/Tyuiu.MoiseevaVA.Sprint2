using Tyuiu.MoiseevaVA.Sprint2.Task6.V4.Lib;
namespace Tyuiu.MoiseevaVA.Sprint2.Task6.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       * ");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Введите порядковый номер: ");
            int numCard = Convert.ToInt32(Console.ReadLine());
            string res;
            if ((numCard< 1) || (numCard > 4))
            {
                res = "Введено неверное значение";
            }
            else
            {
                res = "Масть:" + ds.FindCardSuit(numCard);
            }


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             * ");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
