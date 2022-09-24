// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] CreateArray(int dim1, int dim2){

    Random rand = new Random{};
    double[,] arr = new double[dim1,dim2];
    for (int i = 0; i < dim1; i++)
    {
     for (int k = 0; k < dim2; k++)
     {
        // Console.WriteLine(i+" "+k);
        arr[i,k]=rand.NextDouble();
     }   
    }
    return arr;
}

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = CreateArray(m,n);
foreach (var item in array)
{
    Console.WriteLine("array val: "+item);
}

