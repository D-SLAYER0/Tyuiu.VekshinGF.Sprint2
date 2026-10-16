using Tyuiu.VekshinGF.Sprint2.Task0.V14.Lib;

namespace Tyuiu.VekshinGF.Sprint2.Task0.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 1075;
            int y = 754;

            var res = ds.GetCompareOperations(x, y);

            bool[] expected = new bool[] { true, false, true, false, true, false };

            CollectionAssert.AreEqual(expected, res);
        }
    }
}
