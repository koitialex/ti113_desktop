namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mensagem = "";
            Console.WriteLine("Solicite um número de 1 a 7:");
            float numero = float.Parse(Console.ReadLine()!);

            if (numero == 1)
                mensagem = "Domingo";
            else if (numero == 2)
                mensagem = "segunda-feira";
            else if (numero == 3)
                mensagem = "terça-feira";
            else if (numero == 4)
                mensagem = "quarta-feira";
            else if (numero == 5)
                mensagem = "quinta-feira";
            else if (numero == 6)
                mensagem = "sexta-feira";
            else if (numero == 7)
                mensagem = "sábado";
            else
            {
                mensagem = "digite um número entre 1 a 7";
            }


            Console.WriteLine($"O número digitado {numero},{mensagem}");
        }
    }
}
