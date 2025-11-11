using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MarakovAD.Sprint4.Task7.V15.Lib
{
    public class DataService : ISprint4Task7V15
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] ms = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ms[i,j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (ms[i, j] % 2 != 0) { 
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
