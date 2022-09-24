// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[][] CreateArray(int dim1, int dim2){

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
int[][] array = CreateArray(m,n);
int length = array.GetLength(0);
for (int i = 0; i < length; i++)
{
    int[] subArr = new int[i];
    subArr = array[i];
    int sum = 0;
    foreach (var item in subArr)
    {
        sum +=item;
    }
    Console.WriteLine(sum);
}

