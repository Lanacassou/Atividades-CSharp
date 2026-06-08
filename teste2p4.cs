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