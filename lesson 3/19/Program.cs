// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

string numW = Console.ReadLine();

bool conditionOne = numW[0]==numW[4];
bool conditionTwo = numW[1]==numW[3];

if(conditionOne && conditionTwo) Console.WriteLine("y");
else Console.WriteLine("n");