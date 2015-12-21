using System;

class MatrixMultiplication
{
    static void Main()
    {

        int[,] firstMatrix =
       {
         {1, 2},
         {3, 4}
       };

        int[,] secondMatrix =
       {
         {3, 1},
         {2, 2}
       };

        int[,] result = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];

        //for (int row = 0; row < firstMatrix.GetLength(0); row++)
        //{
        //    for (int col = 0; col < firstMatrix.GetLength(1); col++)
        //    {
        //        result[row, col] = (firstMatrix[row, col] * secondMatrix[row, col]) + (firstMatrix[row, col + 1] * secondMatrix[row + 1, col]);
        //    }
        //}



    }

}


