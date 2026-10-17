using Tyuiu.MoiseevaVA.Sprint2.Task5.V2.Lib;
namespace Tyuiu.MoiseevaVA.Sprint2.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       * ");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Введите номер месяца");
            int numMouth = Convert.ToInt32(Console.ReadLine());
            string res;
            if ((numMouth<1)||(numMouth>12))
            {
                res = "Введено неверное значение";
            }
            else
            {
                res = "Это время года:" + ds.FindMonthSeason(numMouth);
            }


                Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             * ");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
