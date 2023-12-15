using System.Windows;

namespace Lib_4
{
    public class Calculation
    {
        /// <summary>
        /// Находит количество столбцов матрицы, все элементы которых различны
        /// </summary>
        /// <param name="matrix">Матрица</param>
        /// <returns>Количество столбцов матрицы</returns>
        public static int ColumnsUniqueElements(int[,] matrix)
        {
            int count = 0;
            bool diff;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                diff = true;
                int i = 0;

                while (i < matrix.GetLength(0) && diff)
                {
                    int k = 0;

                    while (k < matrix.GetLength(0) && diff)
                        if (matrix[i, j] == matrix[k, j] && i != k) diff = false;
                        else k++;

                    if (diff) i++;
                }

                if (diff) count++;
            }

            return count;
        }
    }
}
