using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KoptyaevRS.Sprint6.TaskReview.V30.Lib
{
    public class DataService
    {
        public double GetResult(int[,] array, int c, int k, int l)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            double res;
            if (k > l || c > rows)
            {
                res = 0;
            }
            else
            {
                int s = 0;
                int f = 0;
                for (int j = k; j < l; j++)
                {
                    s = s + array[c, j];
                    f++;
                }
                res = s * Math.Pow(f, -1);
            }
            return res;
        }
        public double GetMatrix(int[,] array, int c, int k, int l)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            double res;
            if (k > l || c > rows)
            {
                res = 0;
            }
            else
            {
                int max, y;
                for (int j = 0; j < columns; j++)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        max = i;
                        for (int x = i + 1; x < rows; x++)
                        {
                            if (array[x, j] > array[max, j])
                            {
                                max = x;
                            }
                        }
                        y = array[i, j];
                        array[i, j] = array[max, j];
                        array[max, j] = y;
                    }
                }
                int s = 0;
                int f = 0;
                for (int j = k; j <= l; j++)
                {
                    s = s + array[c, j];
                    f++;
                }
                res = Math.Round(s * Math.Pow(f, -1), 3);
            }
            return res;
        }
    }
}
