/* Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int m = 3;
int n = 4;
int[,] matrix = CreateMatrix(m, n);
System.Console.WriteLine("массив");
PrintArray(matrix);


int p = InputInt("Введите позицию элемента в строке ");
int d = InputInt("Введите позицию элемента в столбце ");

if(p>=m && d>=n)
System.Console.WriteLine("такого элемента нет");

else
{
    object c = matrix.GetValue(p-1,d-1);//GetV - Возвращает значение, хранящееся в указанной позиции
    System.Console.WriteLine($"Это число {c}");
}
int InputInt(string message)
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}
int[,] CreateMatrix(int m,int n)
{
    System.Console.WriteLine("Массив целых чисел");
    int[,] matrix = new int[m, n];

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
