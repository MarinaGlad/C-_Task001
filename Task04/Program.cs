//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число ");
string s = Console.ReadLine();
int n = Convert.ToInt32(s);
Console.WriteLine(n % 2 == 0 ? "Четное" : "Не четное");

