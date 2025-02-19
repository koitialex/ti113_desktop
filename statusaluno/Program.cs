namespace statusaluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mensagem = "";

            Console.Write("Informe o nome do aluno:");
            string aluno = Console.ReadLine()!;
            Console.Write("Informe a 1° nota do aluno:");
            float nota1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("\n");
            Console.Write("Informe a 2° nota do aluno:");
            float nota2 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("\n");

            double media = (nota1 + nota2) / 2;

            if (media >= 7)
                mensagem = "Aprovado";
            else if (media > 5 && media < 7) 
                mensagem = "Recuperação";
            else
            {
                mensagem = "Reprovado";
            }
            Console.WriteLine($"O {aluno} teve a média de {media}, por isso ele está {mensagem}");
        }
    }
}
