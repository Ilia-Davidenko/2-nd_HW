using System;
using static System.Console;

WriteLine("Введите номер дня недели (1-7)");
int day = int.Parse(ReadLine());

if (day == 6) WriteLine("Выходной");
if (day == 7) WriteLine("Выходной");
if (day == 1) WriteLine("Будний день");
if (day == 2) WriteLine("Будний день");
if (day == 3) WriteLine("Будний день");
if (day == 4) WriteLine("Будний день");
if (day == 5) WriteLine("Будний день");