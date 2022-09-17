// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

float b1 = Convert.ToInt32(Console.ReadLine());
float k1 = Convert.ToInt32(Console.ReadLine());
float b2 = Convert.ToInt32(Console.ReadLine());
float k2 = Convert.ToInt32(Console.ReadLine());
float x = -999;
float y1=k1*x+b1;
float y2=k2*x+b2;
bool checkInterjection = k1!=k2;
Console.WriteLine(y1+" "+y2);
if(!checkInterjection) {
    Console.WriteLine("прямые параллельны");
} else {
while(y1!=y2){
x+=0.01f;
y1=k1*x+b1;
y2=k2*x+b2;
}
Console.WriteLine(x + " "+y1);
}