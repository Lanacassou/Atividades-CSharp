using System;

class Program
{
    static void Main()
    {
    
        Console.WriteLine(" PROBLEMA 5: CÁLCULO DE VALOR PRESENTE INVERSO ");

        double valorFuturoAlvo = 7390.61;
        double taxaJuros = 0.0125; 
        int periodos = 6;         

       
        double valorPresenteInvestido = valorFuturoAlvo / Math.Pow((1 + taxaJuros), periodos);

      
        valorPresenteInvestido = Math.Round(valorPresenteInvestido, 2);

        Console.WriteLine($"Valor Futuro Alvo (VF): \tR$ {valorFuturoAlvo:F2}");
        Console.WriteLine($"Taxa de Juros (i): \t\t{taxaJuros * 100:F2}%");
        Console.WriteLine($"Período (t): \t\t\t{periodos} meses");
        Console.WriteLine($"VALOR PRESENTE INVESTIDO (VP): R$ {valorPresenteInvestido:F2}");
    
    }
}