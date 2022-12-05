﻿//Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2


Console.WriteLine("Введите количество строк      ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество колонок      ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
int[,] GetArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine(array[i, j]);

        }
        Console.WriteLine();
    }

}
void ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1)-1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k+1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;

                }
            }
        }
    }

}
PrintArray(GetArray());
Console.WriteLine("             ");
ChangeArray(array);
PrintArray(array);


