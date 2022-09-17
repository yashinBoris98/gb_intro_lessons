// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите длинну массива:");
int l = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[l];

int evenNum = 0;

for (int i = 0; i < l; i++)
{
    arr[i]= new Random().Next(100,999);
}

foreach (int item in arr)
{   
    if (item%2==0) evenNum++;
}
Console.WriteLine(evenNum);