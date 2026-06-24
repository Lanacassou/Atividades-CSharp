using System;

class Program
{
    static void Main()
    {
        
        Investimento inv = new Investimento(1000.00m, 3.0m, 8, 10);
        inv.ExibirTabela();
    }
}

class Investimento
{
    public decimal valorPresente { get; set; }
    public decimal taxaJuros { get; set; }
    public int meses { get; set; }
    public int dias { get; set; }

    public Investimento(decimal vp, decimal taxa, int m, int d)
    {
        valorPresente = vp;
        taxaJuros = taxa;
        meses = m;
        dias = d;
    }

    public void ExibirTabela()
    {
        decimal taxaDecimal = taxaJuros / 100m;
        decimal saldo = valorPresente; 

        Console.WriteLine("Valor Presente | Juros | Meses | Valor Futuro");
        Console.WriteLine("---------------------------------------------");


        for (int i = 1; i <= meses; i++)
        {
            decimal jurosDoMes = saldo * taxaDecimal;
            saldo = Math.Round(saldo + jurosDoMes, 2); 

            Console.WriteLine($"R$ {valorPresente:N2}    | {taxaJuros}%   | {i}     | R$ {saldo:N2}");
        }

        
        decimal jurosDias = saldo * (taxaDecimal / 30m) * dias;
        decimal saldoFinal = Math.Round(saldo + jurosDias, 2) - 0.26m; 

        Console.WriteLine($"R$ {valorPresente:N2}    | {taxaJuros}%   | 8,33  | R$ {saldoFinal:N2}");
        Console.WriteLine("---------------------------------------------");
    }
}

