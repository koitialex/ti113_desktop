using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;

namespace ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que leia um nome de usuário e a sua senha.A senha não pode ser
            //igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as
            //informações.
            Console.Write("Informe o nome do usuário:");
            string nome = Console.ReadLine();
            Console.Write("Informe a senha do usuário:");
            string senha = Console.ReadLine();

            while (senha == nome)
            {
                Console.Write("Senha inválida, digite uma outra senha:");
                senha = Console.ReadLine();
            }
            Console.Write("passou!");
        }
    }
}
