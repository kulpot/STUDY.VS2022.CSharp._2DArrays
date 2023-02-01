using System;


namespace _2DArrays
{
    class Program
    {
        static int[,] matrix =
        {   //storage values collections(store array values)
            {1,2,3 },
            {4,5,6 },
            {7,8,9 }
        };

        
        static void Main(string[] args)
        {   //cant change the storage values, it can only change storage location
            foreach (int item in matrix)
            {
                Console.Write(item + " ");
            }
            
            Console.WriteLine("\n This is our 2D array printed using nested for loop");
            ///Nested for loop  ----advantageous for changing the storage values
            //outer for loop (for individual rows)
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // inner for loop (for individual columns)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = 2;
                    Console.Write(matrix[i,j] + " ");
                }
            }
        }
    }
}