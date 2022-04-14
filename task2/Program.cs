using System;
using static System.Console;
WriteLine("Введите число N");
int N=int.Parse(ReadLine());
int b=-N;
while (b<=N)
    {
        Write(" "+b);
        b++;
    }
