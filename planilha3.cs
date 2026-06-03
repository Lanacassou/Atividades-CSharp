using System;

int[] v = new int[6];
int a = 7;
int b = 0; 

while (b < 3) 
{
   
    v[b] = 8 + (b * 2); 
    b = b + 1;
}

Console.WriteLine(v[0]); 
Console.WriteLine(v[1]); 
Console.WriteLine(v[2]); 
Console.WriteLine(v[3]); 
Console.WriteLine(v[4]); 
Console.WriteLine(v[5]); 