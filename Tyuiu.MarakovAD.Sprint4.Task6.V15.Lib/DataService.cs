using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MarakovAD.Sprint4.Task6.V15.Lib
{
    public class DataService : ISprint4Task6V15
    {
        public int Calculate(string[] array)
        {
            string[] ms = Array.FindAll(array, x => x.Length < 7);
            return ms.Length;
        }
    }
}
