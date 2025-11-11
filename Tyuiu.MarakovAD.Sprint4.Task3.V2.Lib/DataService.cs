using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MarakovAD.Sprint4.Task3.V2.Lib
{
    public class DataService : ISprint4Task3V2
    {
        public int Calculate(int[,] array)
        {
            int max = 0;
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < columns; j++)
                {
                    if (array[0, j] > max) { 
                        max = array[0, j];
                    }
                }
            }
            return max;
        }
    }
}
