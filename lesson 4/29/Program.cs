// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем

int[] nums = new int[8];

for (int i = 0; i <= 7; i++)
{
    nums[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("array print:");

foreach (var item in nums)
{
    Console.WriteLine(item);
}