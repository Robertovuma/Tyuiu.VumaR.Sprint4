using Tyuiu.VumaR.Sprint4.Task7.V20.Lib;
namespace Tyuiu.VumaR.Sprint4.Task7.V20.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int n = 5;
            int m = 3;
            int[,] matrix = new int[n, m];
            string value = "357951248632587";

            int res = ds.Calculate(n, m, value);
            int wait = 6144;

            Assert.AreEqual(wait, res);
        }
    }
}
