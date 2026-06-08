using System;

namespace CalculadoraImovel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Venda e Aluguel de Imóvel ");
            Console.Write("Digite a área do imóvel em metros quadrados (m²): ");
            double areaMetro = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do metro quadrado na região (R$): ");
            double valorMetroRegiao = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o total de quartos: ");
            int totalQuartos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o andar do imóvel (0 para térreo, casa ou irrelevante): ");
            int andar = Convert.ToInt32(Console.ReadLine());

            
            double valorBase = areaMetro * valorMetroRegiao;
            double valorVenda = valorBase;

            if (totalQuartos > 4)
            {
                double acrescimoQuartos = valorBase * 0.05; 
                valorVenda += acrescimoQuartos;
                Console.WriteLine("\n[+] Bônus aplicado: Imóvel com mais de 4 quartos (+5%)");
            }

            if (andar > 0)
            {
                double acrescimoAndar = valorBase * (andar * 0.01); 
                valorVenda += acrescimoAndar;
                Console.WriteLine($"[+] Bônus aplicado: Andar alto (+{andar}%)");
            }

            double valorAluguel = valorVenda * 0.01;

          
            Console.WriteLine("\n== RESULTADOS ");
            Console.WriteLine($"Valor estimado de VENDA:   R$ {valorVenda:N2}");
            Console.WriteLine($"Valor estimado de ALUGUEL: R$ {valorAluguel:N2} por mês");
           
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
