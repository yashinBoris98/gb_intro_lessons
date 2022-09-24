// Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4

// 12 13 14 5

// 11 16 15 6

// 10 9 8 7

int[,] CreateArray(){
    int[,] arr = new int[4,4];
    Random rand = new Random();
    for (int i = 0; i < 4; i++)
    {
        for (int k = 0; k < 4; k++)
        {
            arr[i,k] = rand.Next(1,99);
        }
    }
    return arr;
}

int[,] arr = CreateArray();
for (int i = 0; i < 4; i++)
{
    for (int k = 0; k < 4; k++)
    {
        Console.Write(arr[i,k]+" ");
    }
    Console.WriteLine("");
}
