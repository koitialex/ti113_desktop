namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float maior;
            float menor;
            Console.WriteLine("Digite 1° número");
            float numero1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite 2° número");
            float numero2 = float.Parse(Console.ReadLine()!);

            if (numero1 > numero2)
                maior = numero1;
            else
            {
                maior = numero2;
            }
            Console.WriteLine($"O número {maior} é o maior número digitado entre o número {numero1} e {numero2}");
        }
    }
}
