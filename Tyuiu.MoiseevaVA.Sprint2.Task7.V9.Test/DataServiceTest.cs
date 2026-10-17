using Tyuiu.MoiseevaVA.Sprint2.Task7.V9.Lib;
namespace Tyuiu.MoiseevaVA.Sprint2.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0.2;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);

        }
    }
}
