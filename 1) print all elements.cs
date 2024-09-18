using System;

class Program
{
    static void Main()
    {
        // Initialize a two-dimensional array
        int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Print all elements in the array on the same line, separated by spaces
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
        }
        
        // Optionally, add a new line at the end
        Console.WriteLine();
    }
}
