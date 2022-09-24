// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)

bool CheckUnique(int[,,] arr,int num){
    foreach (var item in arr)
    {
        if(item==num)
        return false;
    }
    return true;
}

void FillWithUniqueNumbersAndPrint(ref int[,,] arr){
    Random rand = new Random();
    for (int i = 0; i < 2; i++)
    {
        for (int k = 0; k < 2; k++)
        {
            for (int l = 0; l < 2; l++)
            {
                int a = 10;
                while(!CheckUnique(arr,a)){
                    a=rand.Next(10,99);
                }
                arr[i,k,l]=a;
                Console.WriteLine(a+"("+i+","+k+","+l+")");
            }
        }
    }
}

int[,,] trippleArray = new int[2,2,2];
FillWithUniqueNumbersAndPrint(ref trippleArray);
