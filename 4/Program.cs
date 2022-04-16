using System;
using static System.Console;

int day = new Random().Next(1, 8);
WriteLine(day);
string week = (day>5)? "Выходной": "Будний день";
WriteLine(week);

/*if (day >5)
{
    WriteLine("Выходной");
}
else WriteLine("Будний день");*/