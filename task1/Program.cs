// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


int InputInt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(System.Console.ReadLine());
}

double[,] GenerateArray(int row, int col)
{
    double[,] array = new double[row, col];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 100;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]:F2} ");
        }
    }
    System.Console.WriteLine();
}

int row = InputInt("Введите количество строк");
int col = InputInt("Введите колиество столбцов");

double[,] matrix = GenerateArray(row, col);
PrintArray(matrix);