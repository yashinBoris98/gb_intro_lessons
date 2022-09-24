// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// и

// 1 5 8 5

// 4 9 4 2

// 7 2 2 6

// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10

// 20 81 8 6

// 56 8 4 24

// 10 6 24 49

int[,] CreateArray(int m, int n){
    int[,] arr = new int[m,n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int k = 0; k < n; k++)
        {
            arr[i,k] = rand.Next(1,99);
        }
    }
    return arr;
}

int[,] MultiplyArrays(int[,] arr1, int[,] arr2,int dim1,int dim2){
    int[,] tempArr = new int[dim1,dim2];
    for (int i = 0; i < dim1; i++)
    {
        for (int k = 0; k < dim2; k++)
        {
            tempArr[i,k]=arr1[i,k]*arr2[i,k];
        }
    }
    return tempArr;
}

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = CreateArray(m,n);
int[,] matrix2 = CreateArray(m,n);
int[,] mult = MultiplyArrays(matrix1,matrix2,m,n);

Console.WriteLine("matrix1");
for (int i = 0; i < m; i++)
{
    for (int k = 0; k < n; k++)
    {
        Console.Write(matrix1[i,k]+" ");
    }
    Console.WriteLine("");
}

Console.WriteLine("matrix2");
for (int i = 0; i < m; i++)
{
    for (int k = 0; k < n; k++)
    {
        Console.Write(matrix2[i,k]+" ");
    }
    Console.WriteLine("");
}

Console.WriteLine("multiplication");
for (int i = 0; i < m; i++)
{
    for (int k = 0; k < n; k++)
    {
        Console.Write(mult[i,k]+" ");
    }
    Console.WriteLine("");
}
