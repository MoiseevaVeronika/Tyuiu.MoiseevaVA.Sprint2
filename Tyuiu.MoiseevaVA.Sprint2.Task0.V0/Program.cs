using Tyuiu.MoiseevaVA.Sprint2.Task0.V0.Lib;
namespace Tyuiu.MoiseevaVA.Sprint2.Task0.V0
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService(); //#создаем обьект от ссылочного класса
            int x = 105;
            int y = 223;
            bool[] res = new bool[6]; //#в массив присваиваем то, что нам вернет метод
            res = ds.GetCompareOperations(x, y);

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       * ");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(" Х= " + x);
            Console.WriteLine(" Y= " + y);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             * ");
            Console.WriteLine("**************************************************************************");

            for (int i=0; i<6; i++) //#в цикле от 0 до 6 будем выводить значения
            {
                Console.WriteLine(res[i]);
                Console.ReadKey();
            }
        }
    }
}
