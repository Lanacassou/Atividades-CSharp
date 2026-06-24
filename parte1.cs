PROBLEMA 8

sing System;

class Tabela03
{
    static void Main()
    {
        Problema8();
    }

    static void Problema8()
    {
        double valorInvestido;
        double taxaJuros;
        int periodoMeses;
        double resgate;

        Console.Write("Valor Investido: ");
        valorInvestido = Convert.ToDouble(Console.ReadLine());

        Console.Write("Taxa de Juros (%): ");
        taxaJuros = Convert.ToDouble(Console.ReadLine()) / 100;

        Console.Write("Período (meses): ");
        periodoMeses = Convert.ToInt32(Console.ReadLine());

        Console.Write("Valor do Resgate: ");
        resgate = Convert.ToDouble(Console.ReadLine());

        double rendimento =
            valorInvestido * Math.Pow(1 + taxaJuros, periodoMeses);

        double saldoLiquido = rendimento - resgate;

        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("Valor Investido\tTaxa\tRendimento\tPeríodo\tResgate\tSaldo Líquido");
        Console.WriteLine("----------------------------------------------------------------");

        Console.WriteLine(
            "R$ " + valorInvestido.ToString("F2") + "\t" +
            (taxaJuros * 100).ToString("F2") + "%\t" +
            "R$ " + rendimento.ToString("F2") + "\t" +
            periodoMeses + "\t" +
            "R$ " + resgate.ToString("F2") + "\t" +
            "R$ " + saldoLiquido.ToString("F2")
        );
    }
}
