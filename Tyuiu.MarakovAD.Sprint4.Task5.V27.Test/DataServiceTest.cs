using Tyuiu.MarakovAD.Sprint4.Task5.V27.Lib;
namespace Tyuiu.MarakovAD.Sprint4.Task5.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] ms = { {4,3,2,-8,7},
                          {-4,6,5,-5,7},
                          {3,8,-8,3,5} };
            int res = ds.Calculate(ms);
            int wait = 4;
            Assert.AreEqual(res, wait);
        }
    }
}
