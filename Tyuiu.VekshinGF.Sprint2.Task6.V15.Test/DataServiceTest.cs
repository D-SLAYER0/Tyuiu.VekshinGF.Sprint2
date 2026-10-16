using Tyuiu.VekshinGF.Sprint2.Task6.V15.Lib;

namespace Tyuiu.VekshinGF.Sprint2.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("воскресенье", ds.FindDayName(7));
        }
        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();
            // 8 января — снова понедельник
            Assert.AreEqual("понедельник", ds.FindDayName(8));
        }

        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();
            // 31 декабря (365-й день): (364 % 7) + 1 = 0 + 1 = 1 → понедельник
            Assert.AreEqual("понедельник", ds.FindDayName(365));
        }

        [TestMethod]
        public void TestMethod5()
        {
            DataService ds = new DataService();
            // 100-й день: (99 % 7) + 1 = 1 + 1 = 2 → вторник
            Assert.AreEqual("вторник", ds.FindDayName(100));
        }
    }
}
