// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
int findMax(int[] arr){
    int max = 0;
    foreach (int item in arr)
    {
        if(item>max) max=item;
    }
    return(max);
}

int findMin(int[] arr){
    int min = 320000000;
    foreach (int item in arr)
    {
        if(item<min) min=item;
    }
    return(min);
}

int[] a = new int[9];
for (int i = 0; i < 9; i++)
{
    a[i]=new Random().Next(0,320000000);
}

int diff = findMax(a) - findMin(a);
Console.WriteLine(diff);

