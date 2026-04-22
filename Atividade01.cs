using System;

namespace CalculadoraImovel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Calculadora de Venda e Aluguel de Imóvel ---");

            // 1. Entrada de Dados
            Console.Write("Digite a área do imóvel em metros quadrados (m²): ");
            double areaMetro = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do metro quadrado na região (R$): ");
            double valorMetroRegiao = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o total de quartos: ");
            int totalQuartos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o andar do imóvel (0 para térreo, casa ou irrelevante): ");
            int andar = Convert.ToInt32(Console.ReadLine());

            // 2. Cálculo do Valor Base
            double valorBase = areaMetro * valorMetroRegiao;
            double valorVenda = valorBase;

            // 3. Aplicação das Regras de Valorização

            // Regra dos Quartos: Se tiver mais de 4 quartos, aumenta 5% no valor
            if (totalQuartos > 4)
            {
                double acrescimoQuartos = valorBase * 0.05; // 5% de acréscimo
                valorVenda += acrescimoQuartos;
                Console.WriteLine("\n[+] Bônus aplicado: Imóvel com mais de 4 quartos (+5%)");
            }

            // Regra do Andar: Cada andar adiciona 1% ao valor da propriedade
            if (andar > 0)
            {
                double acrescimoAndar = valorBase * (andar * 0.01); // 1% por andar
                valorVenda += acrescimoAndar;
                Console.WriteLine($"[+] Bônus aplicado: Andar alto (+{andar}%)");
            }

            // 4. Cálculo do Aluguel (1% do valor final de venda)
            double valorAluguel = valorVenda * 0.01;

            // 5. Saída de Dados
            Console.WriteLine("\n================ RESULTADOS ================");
            Console.WriteLine($"Valor estimado de VENDA:   R$ {valorVenda:N2}");
            Console.WriteLine($"Valor estimado de ALUGUEL: R$ {valorAluguel:N2} por mês");
            Console.WriteLine("============================================");
            
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}