/* Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

int InputInt(string message)// создаем фукцию для введения длины массива
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}

double[,] CreateMatrix(int row, int col)
{
    double[,] matrix = new double[row, col];

    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = rnd.Next(-10, 10) + rnd.NextDouble();
            matrix[i, j] = Math.Round(matrix[i,j], 2);
        }
    }
    return matrix;
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}
int m = InputInt("Введите количество строк в массиве: ");

int n = InputInt("Введите количество столбцов в массиве: ");
System.Console.WriteLine();

double[,] arr = CreateMatrix(m,n);
PrintArray(arr);