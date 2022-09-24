// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int AddUpArrMembers(int[] arr){
    int sum = 0;
    foreach (var item in arr)
    {
        sum+=item;
    }
    return sum;
}

int FindMin(int[] arr){
    int min = arr[0];
    foreach (var item in arr)
    {
        if(item<min) min=item;
    }
    return min;
}

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[][] arrayOfArrays = CreateArrayOfArrays(m,n);
int[] sumOfArrays = new int[m];
for (int i = 0; i < m; i++)
{
    int sum = AddUpArrMembers(arrayOfArrays[i]);
    Console.WriteLine("sum of array is equal: "+sum);
    sumOfArrays[i]=sum;
}
Console.WriteLine("Minimal sum of array is equal: "+FindMin(sumOfArrays));