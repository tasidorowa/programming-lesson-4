﻿// int[,] matrix = new int[4, 5];

// Random rnd = new Random();

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = rnd.Next(1, 11);
//         Console.Write($"{matrix[i, j]} "); //интерполяция строк
//     }
//     Console.WriteLine();
// }

int[,] CreateMatrix(int rowsCount, int columsCount)
{
    int[,] matrix = new int[rowsCount, columsCount];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} "); //интерполяция строк
        }
        Console.WriteLine();
    }
}

int [,] matrix = CreateMatrix(4,5);
ShowMatrix(matrix);