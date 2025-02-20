using System.Threading;

namespace ex_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo para montar uma calculadora simples, onde o
            //usuário vai optar em escolher conforme o menu adiante.
            //Observação: no caso de divisão, o denominador não pode ser zero,
            //invalidando a operação.
            //1.Soma.
            //2.Subtração.
            //3.Multiplicação.
            //4.Divisão
            //5.Potenciação
            //6.Radiciação
            //Console.WriteLine("Hello, World!");

            string menu = @"

            1.Soma.
            2.Subtração.
            3.Multiplicação.
            4.Divisão
            5.Potenciação
            6.Radiciação

            selecione uma opção:";

            Console.WriteLine(menu);
            byte opcao = Convert.ToByte(Console.ReadLine());

            double n1, n2, resultado = 0;

            switch (opcao)
            {
                case 1:
                    Console.Write("\nInforme o 1º Numero:");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\nInforme o 2º Numero:");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    resultado = n1 + n2;
                    Console.WriteLine($"A soma de {n1} e {n2} é {resultado}");
                    break;
                case 2:
                    Console.Write("\nInforme o 1º Numero:");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\nInforme o 2º Numero:");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    resultado = n1 - n2;
                    Console.WriteLine($"A soma de {n1} e {n2} é {resultado}");
                    break;
                case 3:
                    Console.Write("\nInforme o 1º Numero:");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\nInforme o 2º Numero:");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    resultado = n1 * n2;
                    Console.WriteLine($"A soma de {n1} e {n2} é {resultado}");
                    break;
                case 4:
                    Console.Write("\nInforme o 1º Numero:");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\nInforme o 2º Numero:");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    while (n2 == 0)
                    {
                        Console.Clear();
                        Console.Write("\nInforme novamente o 2º Numero:");
                        n2 = Convert.ToDouble(Console.ReadLine());
                    }

                    resultado = n1 / n2;
                    Console.WriteLine($"A soma de {n1} e {n2} é {resultado}");
                    break;
                case 5:
                    Console.Write("\nInforme o 1º Numero:");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\nInforme o 2º Numero:");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    resultado = Math.Pow(n1, n2);
                    Console.WriteLine($"A soma de {n1} e {n2} é {resultado}");
                    break;
                case 6:
                    Console.Write("\nInforme o 1º Numero:");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\nInforme o 2º Numero:");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    resultado = Math.Pow(n1, (1 / n2));
                    Console.WriteLine($"A soma de {n1} e {n2} é {resultado}");
                    break;
                default:
                    Console.WriteLine("Operação inválida ");
            }

        }
    }
}
