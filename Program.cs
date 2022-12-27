/*Задача 1

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Проверка на пятизначность обязательна

14212 -> нет

12821 -> да

23432 -> да*/
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
string Num = number.ToString();
if (Num.Length == 5)
{
    if((Num[0] == Num[4]) && (Num[1] == Num[3]))
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }

    else{
        Console.WriteLine($"Число {number} не является палиндромом");
}
}


/*Задача 2

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Введи координаты х точки 1: ");
int xa = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи координаты y точки 1: ");
int ya = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи координаты х точки 2: ");
int xb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи координаты y точки 2: ");
int yb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи координаты х точки 3: ");
int xc = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи координаты y точки 3: ");
int yc = int.Parse(Console.ReadLine()!);
double result = Math.Sqrt(Math.Pow(xb - xa, 2)+ Math.Pow(yb - ya, 2) +Math.Pow(yc - yc, 2));
Console.WriteLine($"Расстояние между точками: {result:f2}");

/*Задача 3

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("Введи число: ");
int n = int.Parse(Console.ReadLine()!);
for (int i =1; i <= n; i++){
    Console.Write($"{Math.Pow(i, 3)} ");
}

