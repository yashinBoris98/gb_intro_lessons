// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// char chooseNum(String line){
// if (line.Length<3)
//     return line[1];
// else 
//     return '0';
// }
// String num = chooseNum(Convert.ToInt32(Console.Read()));
// Console.WriteLine(chooseNum(num));

int chooseNum(int num){
if(num>=100){
    int result = (num%100-(num%100)%10)/10;
    return result;
}
else return 0;
}

// string? enter = Console.ReadLine();
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(chooseNum(a));