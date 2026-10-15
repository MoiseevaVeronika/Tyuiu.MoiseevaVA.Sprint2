using Tyuiu.MoiseevaVA.Sprint2.Task0.V5.Lib;
namespace Tyuiu.MoiseevaVA.Sprint2.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 105;
            int y = 223;
            bool[] res = new bool[6]; //#создаем массив и кол-во значений
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, true, true, true, false, true, };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
