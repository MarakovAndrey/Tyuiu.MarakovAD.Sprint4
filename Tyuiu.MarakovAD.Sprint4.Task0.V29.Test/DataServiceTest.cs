using Tyuiu.MarakovAD.Sprint4.Task0.V29.Lib;
namespace Tyuiu.MarakovAD.Sprint4.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            int act = ds.GetSumOddArrEl(array);
            int wait = 32;
            Assert.AreEqual(act, wait);
        }
    }
}
