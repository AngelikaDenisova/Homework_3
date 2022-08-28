// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");

string number = Console.ReadLine();

char[] array = number.ToArray();


if (array.Length > 5 || array.Length < 5)
{
    Console.WriteLine("Ошибка");
}

 if (array[0] == array[4] && array[1] == array[3])
 {
    Console.WriteLine("Число является палиндромом");
 }
 else 
 {
    Console.WriteLine("Число не является палиндромом");
 }


