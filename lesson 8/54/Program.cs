// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7

// 2 3 5 9

// 2 4 4 8

int[][] CreateArrayOfArrays(int dim1, int dim2){

    Random rand = new Random{};
    int[][] arr = new int[dim1][];
    for (int i = 0; i < dim1; i++)
    {
        arr[i]=new int[dim2];
    }

    for (int i = 0; i < dim1; i++)
    {
        for (int k = 0; k < dim2; k++)
        {
            arr[i][k] = rand.Next(1,999);
        }
    }
    return arr;
}

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[][] arrayOfArrays = CreateArrayOfArrays(m,n);
for (int i = 0; i < m; i++)
{
    Array.Sort(arrayOfArrays[i]);
    Console.WriteLine("Start of new array");
    foreach (var item in arrayOfArrays[i])
    {
        Console.WriteLine(item);
    }
}