using Tyuiu.VekshinGF.Sprint2.Task1.V13.Lib;

namespace Tyuiu.VekshinGF.Sprint2.Task1.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int a = 145;
            int b = 916;
            int c = 164;
            int d = 137;

            var res = ds.GetLogicOperations(a, b, c, d);

            bool[] expected = new bool[] {true, true, true, true, true, false };

            CollectionAssert.AreEqual(expected, res);
        }
    }
}
