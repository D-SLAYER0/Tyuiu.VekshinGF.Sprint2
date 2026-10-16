using Tyuiu.VekshinGF.Sprint2.Task2.V19.Lib;

namespace Tyuiu.VekshinGF.Sprint2.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            
            int x = 7;
            int y = 6;

            var res = ds.CheckDotInShadedArea(x, y);

            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();

            
            int x = 1;
            int y = 1;

            var res = ds.CheckDotInShadedArea(x, y);

            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();

            // Точка на границе (X=3, Y=3 — угол левой верхней полосы)
            int x = 3;
            int y = 3;

            var res = ds.CheckDotInShadedArea(x, y);

            Assert.AreEqual(true, res);
        }
    }
}
