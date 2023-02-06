﻿/* Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет*/


int InputInt(string message)
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}

int[,] CreateMatrix()
{
    System.Console.WriteLine("Массив целых чисел");
    int[,] matrix = new int[3, 4];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
    return matrix;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}


int[,] matrix = CreateMatrix();
PrintArray(matrix);

int p = InputInt("Введите позицию элемента в строке ");
int d = InputInt("Введите позицию элемента в столбце ");
// int Fun(int[] arr, int num, int arr[p,d])
// {
int num = matrix[p - 1, d - 1];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == num) ;
        System.Console.WriteLine($"Это число {num}");
    //     else
    //     {
    //         System.Console.WriteLine("такого элемента нет");
    //     }
    //    // return arr[i, j];
    }
}
//}
//matrix[i, j] = Fun([],num);

