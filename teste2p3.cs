using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("PROBLEMA 3: RENDIMENTO INTERATIVO ");
       
        Console.Write("Digite o Valor Presente (Ex: 68): R$ ");
        double valorPresente = double.Parse(Console.ReadLine());

        Console.Write("Digite a Taxa de Juros anual em % (Ex: 2): ");
        double taxaJurosPorcentagem = double.Parse(Console.ReadLine());
        double taxaJuros = taxaJurosPorcentagem / 100; 

        Console.Write("Digite o Período em anos (Ex: 3): ");
        int periodoAnos = int.Parse(Console.ReadLine());

        double valorF = valorPresente * Math.Pow((1 + taxaJuros), periodoAnos);
        
       
        valorF = Math.Round(valorF, 2);

    
        Console.WriteLine($"MOSTRAR RENDA (Valor Futuro): R$ {valorF:F2}");
      
    }
}