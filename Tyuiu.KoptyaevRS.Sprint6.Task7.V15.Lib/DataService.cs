using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KoptyaevRS.Sprint6.Task7.V15.Lib
{
    public class DataService : ISprint6Task7V15
    {
        public int[,] GetMatrix(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int xCol = 6;

            for (int r = 0; r < rows; r++)
            {
                for (int c = xCol; c <= xCol; c++)
                {
                    if (matrix[r, c] < 10 && matrix[r, c] % 3 == 0)
                    {
                        matrix[r, c] = 3;
                    }
                }
            }
            return matrix;
        }
    }
}
