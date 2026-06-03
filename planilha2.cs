using System;

int[] v = new int[6];
int a = 2;

while (a < 6)
{
    v[a] = a * 10;
    a++;
}

Console.WriteLine(v[0]);
Console.WriteLine(v[1]);
Console.WriteLine(v[2]);
Console.WriteLine(v[3]);
Console.WriteLine(v[4]);
Console.WriteLine(v[5]);
