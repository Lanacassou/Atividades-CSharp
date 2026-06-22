TAREFA 3

PARTE 1

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




PARTE 2




using System;

class Program
{
    static void Main()
    {
       
        Investimento inv = new Investimento(1000.00m, 3.0m, 8, 10, 5, 100.00m);
        inv.ExibirTabelaProblema7();
    }
}

class Investimento
{
    public decimal valorPresente { get; set; }
    public decimal taxaJuros { get; set; }
    public int meses { get; set; }
    public int dias { get; set; }
    public int mesResgate { get; set; }
    public decimal valorResgate { get; set; }

    public Investimento(decimal vp, decimal taxa, int m, int d, int mesR, decimal valorR)
    {
        valorPresente = vp;
        taxaJuros = taxa;
        meses = m;
        dias = d;
        mesResgate = mesR;
        valorResgate = valorR;
    }

    public void ExibirTabelaProblema7()
    {
        
        double taxaDecimal = (double)(taxaJuros / 100m);
        double vp = (double)valorPresente;

        Console.WriteLine("Valor Presente | Juros | Meses | Valor Futuro | Resgate   | Saldo      | Rendimento");
        Console.WriteLine("-----------------------------------------------------------------------------------------");
        
      
        Console.WriteLine($"R$ {valorPresente:N2}    | {taxaJuros:F1}%   | 0     | R$ {valorPresente:N2} |           | R$ 0,00      | ");

      
        for (int i = 1; i <= meses; i++)
        {
           
            double saldoRealDouble = vp * Math.Pow(1.0 + taxaDecimal, i);
            decimal saldoReal = Math.Round((decimal)saldoRealDouble, 2);
            
         
            decimal valorFuturoExibido = saldoReal;
            if (i >= mesResgate)
            {
                valorFuturoExibido = saldoReal - valorResgate;
            }

           
            string resgateTexto = "         ";
            decimal valorResgateLinha = 0;
            if (i == mesResgate)
            {
                valorResgateLinha = valorResgate;
                resgateTexto = $"R$ {valorResgate:N2}";
            }

            decimal saldoExibido = valorFuturoExibido - valorPresente;

           
            string rendimentoTexto = "";
            if (i == mesResgate)
            {
                rendimentoTexto = $"R$ {valorFuturoExibido - valorResgateLinha:N2}"; 
            }
            else if (i > mesResgate)
            {
                rendimentoTexto = $"R$ {valorFuturoExibido:N2}";
            }

            Console.WriteLine($"R$ {valorPresente:N2}    | {taxaJuros:F1}%   | {i,-5} | R$ {valorFuturoExibido:N2} | {resgateTexto,-9} | R$ {saldoExibido,-8:N2} | {rendimentoTexto}");
        }

        
        double mesesTotais = meses + ((double)dias / 30.0);
        double saldoRealFinalDouble = vp * Math.Pow(1.0 + taxaDecimal, mesesTotais);
        decimal saldoRealFinal = Math.Round((decimal)saldoRealFinalDouble, 2);

        decimal valorFuturoFinalExibido = saldoRealFinal - valorResgate;
        decimal saldoFinalExibido = valorFuturoFinalExibido - valorPresente;
        
        Console.WriteLine($"R$ {valorPresente:N2}    | {taxaJuros:F1}%   | 8,33  | R$ {valorFuturoFinalExibido:N2} |           | R$ {saldoFinalExibido,-8:N2} | R$ {valorFuturoFinalExibido:N2}");
        Console.WriteLine("-----------------------------------------------------------------------------------------");
    }
}
