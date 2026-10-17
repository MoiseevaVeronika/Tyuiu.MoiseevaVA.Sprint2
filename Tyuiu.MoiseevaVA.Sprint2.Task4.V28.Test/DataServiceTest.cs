using Tyuiu.MoiseevaVA.Sprint2.Task4.V28.Lib;
namespace Tyuiu.MoiseevaVA.Sprint2.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 6;
            double res = ds.Calculate(x, y);
            double wait = 9;
            Assert.AreEqual(wait, res);
        }
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 21.817;
            Assert.AreEqual(wait, res);
        }
    }
}
