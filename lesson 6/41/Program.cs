// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода стоп-слова "stop"

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

string? w;
int sum = 0;
while(true){
w = Console.ReadLine();
if(w!="stop") sum+=Convert.ToInt32(w);
else break;
}
Console.WriteLine(sum);

