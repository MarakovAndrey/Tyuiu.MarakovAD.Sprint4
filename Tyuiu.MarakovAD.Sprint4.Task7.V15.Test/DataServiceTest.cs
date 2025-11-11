using Tyuiu.MarakovAD.Sprint4.Task7.V15.Lib;
namespace Tyuiu.MarakovAD.Sprint4.Task7.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 4;
            int columns = 2;
            int[,] ms = new int[rows, columns];
            string str = "10293847";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 4;
            Assert.AreEqual(res, wait);
        }
    }
}
