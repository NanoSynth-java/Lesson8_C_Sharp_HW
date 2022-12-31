// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Console.WriteLine("Введите кол-во строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] FillArray(int rows, int cols, int min, int max)
// {
//     int[,] array = new int[cols, rows];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i,j] = new Random().Next(min, max + 1); 
//         }
//     }
//     return array;
// }


// void PrintArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int [,] matrix = FillArray(rows, cols, 1, 100);



// void SortArray(int[,] array)
// {
//     int temp;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = j+1; k < array.GetLength(1); k++)
//             {
//                 if (array[i,j] > array[i,k])
//                 {
//                     temp = array[i,j];
//                     array[i,j] = array[i,k];
//                     array[i,k] = temp;
//                 }
//             }
//         }
//     }
// }

// PrintArray(matrix);
// SortArray(matrix);
// PrintArray(matrix);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.WriteLine("Введите кол-во строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] FillArray(int rows, int cols, int min, int max)
// {
//     int[,] array = new int[cols, rows];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void MinSumElementsInRow(int[,] array)
// {
//     int sum = int.MaxValue;
//     int index = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int temp = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             temp += array[i, j];
//         }
//         if (temp < sum)
//         {
//             sum = temp;
//             index = i + 1;
//         }
//     }
//     Console.WriteLine("Строка: " + index + " Сумма - " + sum);
//     Console.WriteLine();
//     Console.ReadKey();

// }

// int[,] matrix = FillArray(rows, cols, 1, 10);
// PrintArray(matrix);
// MinSumElementsInRow(matrix);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 1 2 | 3 4
// 5 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// int[,] arrayA = {
//     {2,4},
//     {3,2}
// };
// int[,] arrayB = {
//     {3,4},
//     {3,3}
// };

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// PrintArray(arrayA);
// PrintArray(arrayB);

// int [,] result = new int[arrayA.GetLength(0), arrayB.GetLength(1)];

// int[,] TwoMatrice(int[,] arrayA, int[,] arrayB)
// {

//     for (int i = 0; i < arrayA.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayB.GetLength(1); j++)
//         {
//             for (int k = 0; k < arrayA.GetLength(1); k++)
//             {
//                 result[i, j] += arrayA[i, k] * arrayB[k, j];

//             }
//         }
//     }
//     return result;
// }
// TwoMatrice(arrayA, arrayB);
// PrintArray(result);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Сколько будет строк ? ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сколько будет столбцов ? ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Какой будет глубина трехмерности массива ;) ?"); // ничего смешнее придумать и понятнее я придумать не смог.
int third = Convert.ToInt32(Console.ReadLine());
int[,,] array3d = new int[rows, cols, third];
Random rndnum = new Random();

// int[,,] FillArray(int[,,] array3d, int min, int max)
// {
//     foreach (int rows in array3d)
//     {
//         foreach (int cols in array3d)
//         {
//             foreach (int third in array3d)
//             {
//                 array3d[rows,cols,third] = rndnum.Next(min, max + 1);
//             }
//         }
//     }
//     return array3d;
// }

int [,,] FillArray(int[,,] array3d, int min, int max)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                array3d[i,j,k] = rndnum.Next(min,max + 1);
            }
        }
    }
    return array3d;
}

void PrintArray(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                Console.Write($"row {i} column {j} 3d {k} (Элемент хранит число {array3d[i,j,k]}) \t");
            }
        } Console.WriteLine();
    } Console.WriteLine();
}

FillArray(array3d,1,10);
PrintArray(array3d);