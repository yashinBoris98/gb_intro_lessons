// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

string? num = Console.ReadLine();
int sum = 0;
if (num != null)
{
    foreach (char item in num)
    {
        // string w = item.ToString();
        // int n = Convert.ToInt32(w);
        // sum+=n;
    
        sum+=Convert.ToInt32(item.ToString());
    }
}
Console.WriteLine(sum);