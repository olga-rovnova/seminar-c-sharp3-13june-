// Задача 23: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int count = 1;
while (count<n)
{
    int result = Cube(count);
    count++;
    Console.Write($"{result}, ");
}
Console.WriteLine(Cube(n)+".");

int Cube(int a)
{
    return a*a*a;
}
