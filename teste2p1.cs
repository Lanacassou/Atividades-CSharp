using System;

class Program
{
    static void Main()
    {
       
        decimal valorPresente = 1000.00m;
        decimal taxaJuros = 0.053m; 
        int periodoMes = 6;

        
        decimal percentualJuros = taxaJuros * 100;

        
        double baseCalculo = (double)(1 + taxaJuros);
        decimal valorF = valorPresente * (decimal)Math.Pow(baseCalculo, periodoMes);

       
        Console.WriteLine(" PROBLEMA 1: RENDIMENTO FIXO");
        Console.WriteLine($"Valor Presente inicializado: R$ {valorPresente:F2}");
        Console.WriteLine($"Taxa de Juros inicializada: {percentualJuros}% a.m.");
        Console.WriteLine($"Período inicializado: {periodoMes} meses");
        Console.WriteLine($"Resultado do Valor F: R$ {valorF:F2}");
    }
}
