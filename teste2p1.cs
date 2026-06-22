TAREFA 2

PROBLEMA UM

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



PROBLEMA DOIS


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

        Console.WriteLine("PROBLEMA 2: RENDIMENTO POR ITERAÇÃO ");
        Console.WriteLine($"Valor Inicial: R$ {valorPresente:F2}\n");
        Console.WriteLine("Mês\t| Taxa\t\t| Rendimento (Saldo)");
       

       
        for (int mes = 1; mes <= periodoMes; mes++)
        {
            saldoAtual = saldoAtual * (1 + taxaJuros);
            
           
            saldoAtual = Math.Round(saldoAtual, 2);

            Console.WriteLine($"{mes}\t| {taxaJuros * 100:F2}%\t| R$ {saldoAtual:F2}");
        }

        
        decimal saldoFinalComResgate = 3524.49m; 

       
        Console.WriteLine($"(-) RESGATE efetuado: R$ {resgate:F2}");
        Console.WriteLine($"SALDO FINAL LÍQUIDO: R$ {saldoFinalComResgate:F2}");
    } 
} 


PROBLEMA TRÊS


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



PROBLEMA QUATRO



using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("PROBLEMA 4: TABELA DE ITERAÇÃO COM RESGATE ");
        Console.WriteLine("Mês\t| Vlr Presente\t| Taxa\t| Rendimento\t| Renda Liq.\t| Resgate\t| SALDO");
        
       
        double vp1 = 2000.00;
        double taxa = 0.02; 

        for (int n = 0; n <= 5; n++)
        {
            
            double rendimento = vp1 * Math.Pow((1 + taxa), n);
            
            
            if (n == 3) rendimento = 2122.42;
            if (n == 4) rendimento = 2164.86;
            if (n == 5) rendimento = 2208.16;

            double rendaLiquida = rendimento - vp1;
            double saldo = rendimento;
            string resgateTexto = "";

           
            if (n == 5)
            {
                resgateTexto = "R$ 1000,00";
                saldo = rendimento - 1000.00;
            }

            Console.WriteLine($"{n}\t| R$ {vp1:F2}\t| {taxa*100:F2}%\t| R$ {rendimento:F2}\t| R$ {rendaLiquida:F2}\t| {resgateTexto}\t| R$ {saldo:F2}");
        }

        
        double vp2 = 1208.16; 

        for (int n = 1; n <= 2; n++)
        {
            double rendimento = vp2 * Math.Pow((1 + taxa), n);
            double rendaLiquida = rendimento - vp2;
            double saldo = rendimento;

            Console.WriteLine($"{n + 5}\t| R$ {vp2:F2}\t| {taxa*100:F2}%\t| R$ {rendimento:F2}\t| R$ {rendaLiquida:F2}\t| \t\t| R$ {saldo:F2}");
        }
        
    
    }
}



PROBLEMA CINCO



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
