using System;
using static System.Console;

WriteLine("Введите любое число");
int a = int.Parse(ReadLine());
string str = a.ToString();

if (a >= 100)
{
    WriteLine(str[2]);
}
else WriteLine("В числе нет третьей цифры");