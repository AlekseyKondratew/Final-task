﻿Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
a = (a % 100)/10;
Console.WriteLine(a);
