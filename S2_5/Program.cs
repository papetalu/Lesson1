﻿// 14. Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да
Console.Clear();
Console.Write("Введите значение: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x % 7 == 0 && x % 23 == 0)
   Console.WriteLine("Кратно");
else
   Console.WriteLine("Не кратно");
