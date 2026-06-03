using System;

namespace teste1
{
class Program
{
    static void Main(string[] args)
    {
int a= 10;
int b= 20;


int c= (a+b) / 2;
c = c -40;

int[] v= new int[4];
v[3]= a + b + c;

Console.WriteLine(v[3]);
}
}
}

