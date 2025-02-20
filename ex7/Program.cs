using System.Drawing;
using System.Text;

namespace ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que o usuário escreva o nome e o preço de seis
            //produtos e assim que terminar de escrever o ultimo produto, mostre o
            //nome e o valor do produto mais barato.
            string[] nome = new string[6];
            string menornome = "";
            double[] preco = new double[6];
            double menorpreco = 0;
            
          

            for (int i = 0; i < 6; i++)
            {
                
                Console.WriteLine($"Nome do {i + 1}º produto:");
                nome[i] = Console.ReadLine()!;
                Console.WriteLine($"Preco do {i + 1}º produto:");
                preco[i] = Convert.ToDouble(Console.ReadLine());
                
            }
            menorpreco = preco.Min();
            int posicaobarato = Array.IndexOf(preco, menorpreco);
            menornome = nome[posicaobarato];
            Console.WriteLine($@"O produto mais barato é {menornome} e ele custa {menorpreco} ");
        }
    }
}
