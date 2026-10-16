using Tyuiu.VekshinGF.Sprint2.Task5.V11.Lib;

namespace Tyuiu.VekshinGF.Sprint2.Task5.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            // Обычный день внутри месяца
            int g = 2023, m = 4, n = 15;
            var res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual("16.4.2023", res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();

            // Конец месяца (апрель, 30 дней)
            int g = 2023, m = 4, n = 30;
            var res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual("1.5.2023", res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();

            // Конец февраля (невисокосный год)
            int g = 2023, m = 2, n = 28;
            var res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual("1.3.2023", res);
        }

        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();

            // Переход на новый год
            int g = 2023, m = 12, n = 31;
            var res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual("1.1.2024", res);
        }

        [TestMethod]
        public void TestMethod5()
        {
            DataService ds = new DataService();

            // Конец января (31 день)
            int g = 2023, m = 1, n = 31;
            var res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual("1.2.2023", res);
        }
    }
}
