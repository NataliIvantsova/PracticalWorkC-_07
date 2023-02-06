/*Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
Например, такой массив:
1 4 7 2
5 9 2 3
8 4 2 4

Введенный элемент 2, результат: [1, 4]

Введенный элемент 6, результат: такого элемента нет.*/

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 11);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }

    (int, int) FindPosition(int[,] arr, int number)
    //(int, int) FindPosition(int[,] arr, int number)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] == number)
                {
                    return (i, j);
                }
            }
        }
        return (-1, -1);
    }
}
