using Tyuiu.MoiseevaVA.Sprint2.Task3.V8.Lib;
namespace Tyuiu.MoiseevaVA.Sprint2.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidConditions1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = -4.588;
            Assert.AreEqual(wait, res);
        }
        public void ValidConditions2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(wait, res);
        }
        
        public void ValidConditions3()
        {
            DataService ds = new DataService();
            double x = -1;
            double res = ds.Calculate(x);
            double wait = 0.25;
            Assert.AreEqual(wait, res);
        }
        
        public void ValidConditions4()
        {
            DataService ds = new DataService();
            double x = -20;
            double res = ds.Calculate(x);
            double wait = -219.75;
            Assert.AreEqual(wait, res);
        }
        

    }
}
