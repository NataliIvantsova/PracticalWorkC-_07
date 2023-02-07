/* Задача 50. Напишите программу, которая на вход принимает позиции 
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

int l = InputInt("Введите позицию элемента в строке ");
int a = InputInt("Введите позицию элемента в столбце ");
FindNum(matrix,l,a);

void FindNum(int[,] array, int p, int d)
{
    if (p < 1 || p > matrix.GetLength(0) || d < 1 || d > matrix.GetLength(1))
    {
        System.Console.WriteLine("Tакого элемента нет");
    }
    else
    {
        int num = matrix[p - 1, d - 1];
        System.Console.WriteLine(num);
    }
}