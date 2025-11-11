using Tyuiu.MarakovAD.Sprint4.Task6.V15.Lib;
namespace Tyuiu.MarakovAD.Sprint4.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var week = new string[] { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };
            int res = ds.Calculate(week);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
