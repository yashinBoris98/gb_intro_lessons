// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int l = new Random().Next(1,99);
int[] a = new int[l];
for (int i = 0; i < l; i++)
{
    a[i]=new Random().Next(1,99);
}

int sum = 0;
for (int i = 0; i < l; i+=2)
{
    if(i<=l)
    sum+=a[i];
}

Console.WriteLine(sum);