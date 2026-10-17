using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VekshinGF.Sprint2.Task7.V11.Lib;

namespace Tyuiu.VekshinGF.Sprint2.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            // Правый верхний вырезанный сектор (y < x)
            Assert.AreEqual(false, ds.CheckDotInShadedArea(0.5, 0.1));
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            // Правый нижний вырезанный сектор
            Assert.AreEqual(false, ds.CheckDotInShadedArea(0.5, -0.5));
        }

        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();
            // Левый верхний — заштрихован
            Assert.AreEqual(true, ds.CheckDotInShadedArea(-0.5, 0.5));
        }

        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();
            // Левый нижний — заштрихован
            Assert.AreEqual(true, ds.CheckDotInShadedArea(-0.5, -0.5));
        }

        [TestMethod]
        public void TestMethod5()
        {
            DataService ds = new DataService();
            // Правый верхний выше прямой y=x — заштрихован
            Assert.AreEqual(true, ds.CheckDotInShadedArea(0.3, 0.5));
        }

        [TestMethod]
        public void TestMethod6()
        {
            DataService ds = new DataService();
            // На прямой y=x (граница) — заштрихован
            Assert.AreEqual(true, ds.CheckDotInShadedArea(0.5, 0.5));
        }

        [TestMethod]
        public void TestMethod7()
        {
            DataService ds = new DataService();
            // Вне окружности
            Assert.AreEqual(false, ds.CheckDotInShadedArea(2.0, 2.0));
        }
    }
}