//Задача 19: Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.
Console.Write("введите положительное пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number/10000>=1 && number/10000<=9)
{
int div = number / 10000;
int modulo = number % 10;
if (div == modulo)
{
    int newNumber = (number%10000) / 10;
    div = newNumber /100;
    modulo = newNumber % 10;
    if (div == modulo)
    {
        Console.WriteLine("число является палиндромом");
    }
}
else
Console.WriteLine("число НЕ является палиндромом");
}
else Console.WriteLine("введено некорректное число");