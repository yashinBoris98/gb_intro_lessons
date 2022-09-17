// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int b1 = Convert.ToInt32(Console.ReadLine());
int k1 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine());
double x = -999d;
// int x = 0;
double y1=k1*x+b1;
double y2=k2*x+b2;
bool checkInterjection = k1!=k2;
// Console.WriteLine(y1+" "+y2);
if(!checkInterjection) {
    Console.WriteLine("прямые параллельны");
} else {
while(y1!=y2){
x+=0.1d;
// x++;
y1=k1*x+b1;
y2=k2*x+b2;
Console.WriteLine("x="+x+", y1="+y1+", y2="+y2);
if(x>999) break;
}
Console.WriteLine("значения равны: "+x + " "+y1);
}

//Эта задача отмечена необязательной, отправлю так. Позже попробую исправить

