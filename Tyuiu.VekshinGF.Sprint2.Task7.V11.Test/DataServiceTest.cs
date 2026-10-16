using Tyuiu.VekshinGF.Sprint2.Task7.V11.Lib;

namespace Tyuiu.VekshinGF.Sprint2.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            
            double x = -0.5, y = 0.5;
            Assert.AreEqual(true, ds.CheckDotInShadedArea(x, y));
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            
            double x = 0.5, y = 0.1;
            Assert.AreEqual(false, ds.CheckDotInShadedArea(x, y));
        }

        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();
            
            double x = 0.3, y = 0.5;
            Assert.AreEqual(true, ds.CheckDotInShadedArea(x, y));
        }

        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();
           
            double x = 2.0, y = 2.0;
            Assert.AreEqual(false, ds.CheckDotInShadedArea(x, y));
        }

        [TestMethod]
        public void TestMethod5()
        {
            DataService ds = new DataService();
            
            double x = -0.5, y = -0.5;
            Assert.AreEqual(true, ds.CheckDotInShadedArea(x, y));
        }

        [TestMethod]
        public void TestMethod6()
        {
            DataService ds = new DataService();
            
            double x = 0.5, y = 0.5;
            Assert.AreEqual(true, ds.CheckDotInShadedArea(x, y));
        }
    }
}
