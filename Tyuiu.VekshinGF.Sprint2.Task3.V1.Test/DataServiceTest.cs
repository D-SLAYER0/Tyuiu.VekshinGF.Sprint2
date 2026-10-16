using Tyuiu.VekshinGF.Sprint2.Task3.V1.Lib;

namespace Tyuiu.VekshinGF.Sprint2.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            // x = 2 → y = 2 + 15/2 = 2 + 7.5 = 9.5
            double x = 2.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(9.5, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();

            // x = 1 → y = e^1 - 12·1 + cos(1) ≈ 2.7183 - 12 + 0.5403 ≈ -8.7414
            // Округление до 3 знаков: -8.741
            double x = 1.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(-8.741, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();

            // x = -6 → y = 11·(-6) - 1/((-6)³ + 3) = -66 - 1/(-213) = -66 + 0.00469 ≈ -65.995
            double x = -6.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(-65.995, res);
        }
    
    }
}
