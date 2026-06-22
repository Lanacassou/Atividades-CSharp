TAREFA 1


    
TESTE UM


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


TESTE DOIS 



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



TESTE TRÊS


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
