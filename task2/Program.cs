// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого числа в массиве нет


int InputInt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(System.Console.ReadLine());
}

 int [,] GenerateArray( int row, int col)
 {
    int [,] array = new int [row,col];
    
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j]= new Random().Next(1,11);
    }
}
    return array;
 }

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
    }
    System.Console.WriteLine();
} 

void SearchElement (int [,] array, int searchRow, int searchCol)
{
    if (searchRow-1 <= array.GetLength(0) || searchCol-1 <= array.GetLength(1))
    {
        System.Console.WriteLine($"На позиции {searchRow},{searchCol} находится элемент {array[searchRow-1,searchCol-1]}");
    }
    else
    {
        System.Console.WriteLine("Такой позиции в матрице не существует");
    }
}




int [,] matrix = GenerateArray(3,3);
PrintArray(matrix);

int row = InputInt("Введите номер строки");
int col = InputInt("Введите стобца");

SearchElement(matrix,row,col);