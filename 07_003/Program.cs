/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int n = InputInt("введите количество строк");
int m = InputInt("введите количество столбцов");

int[,] matrix = new int[n, m];

FillArray(matrix);
PrintArray(matrix);
averageNumbeColumn(matrix);


void averageNumbeColumn(int[,] arr)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        avarage = (avarage + arr[i, j]);
    }
    avarage = avarage / arr.GetLength(0);
    Console.Write(avarage + "; ");
}
}

int InputInt(string message)
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");// + пробел
        }
        Console.WriteLine("");
    }
}
