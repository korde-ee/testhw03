// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Test(int num)
{
    int r, sum = 0, t;

    for(t = num; num!= 0; num = num / 10)
    {
         r = num % 10;
         sum = sum * 10 + r;
         //Console.Write($"Число r = {r}, число sum = {sum}.\n");
    }
    if(t==sum) Console.Write($"Число {t} является палиндромом.\n");
    else Console.Write($"Число {t} не палиндром.\n");
}
//int numFive;
Console.Write("Введите пятизначное число: ");
int numFive = Convert.ToInt32(Console.ReadLine()); 

Test(numFive);

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
/*
double LenghtBetweenTwoDots(int num11, int num12, int num13, int num21, int num22, int num23)
{
    int firstX = (num11 - num21)*(num11 - num21);
    int secondY = (num12 - num22)*(num12 - num22);
    int therdZ =(num13 - num23)*(num13 - num23);
    double distance = Math.Sqrt(firstX + secondY + therdZ);
    return distance;
}

Console.Write("Введите координату Х первой точки: ");
int numX1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
int numY1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
int numZ1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Х второй точки: ");
int numX2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
int numY2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
int numZ2 = Convert.ToInt32(Console.ReadLine());

double distanceItog = LenghtBetweenTwoDots(numX1, numY1, numZ1, numX2, numY2, numZ2);
double itog= Math.Round(distanceItog, 2);
Console.WriteLine($"Расстояние между двумя точками с координатами {numX1},{numY1},{numZ1} и {numX2},{numY2},{numZ2} - {itog}");
*/

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//Вариант 1
/*
int Cube(int num)
{
    int cubenum = num * num * num;
    return cubenum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Таблица кубов числа {number} --> ");
for (int i = 1; i <= number; i++)
{
    int result = Cube(i);
    Console.Write($"{result}, ");
}
*/
//Вариант 2
/*
void CubeVar(double num)
{
    int current = 1;
    while (current <= num - 1)
    {
            Console.Write(current * current * current + ","); 
            current ++;
    }
    Console.Write(current * current * current); 
}
double number;
Console.Write("Введите положительное число: ");
number = Convert.ToDouble(Console.ReadLine());
if(number < 0) number = number * (-1);
CubeVar(number);
*/