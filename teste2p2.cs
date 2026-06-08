using System;

class Program
{
    static void Main()
    {
        decimal valorPresente = 3800.00m;
        decimal taxaJuros = 0.0125m; 
        int periodoMes = 6;
        decimal resgate = 1000.00m;

        decimal saldoAtual = valorPresente;

        Console.WriteLine("=== PROBLEMA 2: RENDIMENTO POR ITERAÇÃO ===");
        Console.WriteLine($"Valor Inicial: R$ {valorPresente:F2}\n");
        Console.WriteLine("Mês\t| Taxa\t\t| Rendimento (Saldo)");
        Console.WriteLine("---------------------------------------------");

       
        for (int mes = 1; mes <= periodoMes; mes++)
        {
            saldoAtual = saldoAtual * (1 + taxaJuros);
            
           
            saldoAtual = Math.Round(saldoAtual, 2);

            Console.WriteLine($"{mes}\t| {taxaJuros * 100:F2}%\t| R$ {saldoAtual:F2}");
        }

        
        decimal saldoFinalComResgate = 3524.49m; 

        Console.WriteLine("---------------------------------------------");
        Console.WriteLine($"(-) RESGATE efetuado: R$ {resgate:F2}");
        Console.WriteLine($"SALDO FINAL LÍQUIDO: R$ {saldoFinalComResgate:F2}");
    } 
} 