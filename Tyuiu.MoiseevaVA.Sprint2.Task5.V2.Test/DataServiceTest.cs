using Tyuiu.MoiseevaVA.Sprint2.Task5.V2.Lib;
namespace Tyuiu.MoiseevaVA.Sprint2.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual (ds.FindMonthSeason(1),"Зима");
            Assert.AreEqual(ds.FindMonthSeason(2), "Зима");
            Assert.AreEqual(ds.FindMonthSeason(3), "Весна");
            Assert.AreEqual(ds.FindMonthSeason(4), "Весна");
            Assert.AreEqual(ds.FindMonthSeason(5), "Весна");
            Assert.AreEqual(ds.FindMonthSeason(6), "Лето");
            Assert.AreEqual(ds.FindMonthSeason(7), "Лето");
            Assert.AreEqual(ds.FindMonthSeason(8), "Лето");
            Assert.AreEqual(ds.FindMonthSeason(9), "Осень");
            Assert.AreEqual(ds.FindMonthSeason(10), "Осень");
            Assert.AreEqual(ds.FindMonthSeason(11), "Осень");
            Assert.AreEqual(ds.FindMonthSeason(12), "Зима");

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthSeason(-1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthSeason(13);
            });



        }
    }
}
