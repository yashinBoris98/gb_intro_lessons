// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> такого числа в массиве нет


double[,] CreateArray(int dim1, int dim2){

    Random rand = new Random{};
    double[,] arr = new double[dim1,dim2];
    for (int i = 0; i < dim1; i++)
    {
     for (int k = 0; k < dim2; k++)
     {
        Console.WriteLine(i+" "+k);
        arr[i,k]=rand.Next(-999,999);
     }   
    }
    return arr;
}

Random rand = new Random();
int m = rand.Next(1,10);
int n = rand.Next(1,10);
double[,] array = CreateArray(m,n);

int a =Convert.ToInt32(Console.ReadLine());
int b =Convert.ToInt32(Console.ReadLine());
double? d = array[a,b];
if (d!=null)
{
    Console.WriteLine("такой элемент есть");
}
else Console.WriteLine("такого элемента нет");
