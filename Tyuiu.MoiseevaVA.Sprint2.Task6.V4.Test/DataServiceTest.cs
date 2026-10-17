using Newtonsoft.Json.Linq;
using Tyuiu.MoiseevaVA.Sprint2.Task6.V4.Lib;
namespace Tyuiu.MoiseevaVA.Sprint2.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(ds.FindCardSuit(1), "пики");
            Assert.AreEqual(ds.FindCardSuit(2), "трефы");
            Assert.AreEqual(ds.FindCardSuit(3), "бубны");
            Assert.AreEqual(ds.FindCardSuit(4), "червы");
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardSuit(-1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardSuit(13);
            });

        }
    }
}
