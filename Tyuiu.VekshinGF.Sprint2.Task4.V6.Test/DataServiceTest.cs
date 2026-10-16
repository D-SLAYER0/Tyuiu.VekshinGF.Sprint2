using Tyuiu.VekshinGF.Sprint2.Task4.V6.Lib;

namespace Tyuiu.VekshinGF.Sprint2.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 2.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.5, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();

            
            double x = 1.0;
            double y = 10.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(3.667, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();

            // x = 1, y = 100: условие 1 + 20 = 21 > 100 × 2 = 200 → false
            // z = 100² + 2·1 + 6/1 = 10000 + 2 + 6 = 10008
            double x = 1.0;
            double y = 100.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(10008.0, res);
        }
    }
    
}
