namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float maior;

            Console.WriteLine("Digite 1° número");
            float numero1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite 2° número");
            float numero2 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite 2° número");
            float numero3 = float.Parse(Console.ReadLine()!);

            if (numero1 > numero2 && numero1 > numero3)
                maior = numero1;
            else if (numero2 > numero1 && numero2 > numero3)
                maior = numero2;
            else
            {
                maior = numero3;
            }
            Console.WriteLine($"O número {maior} é o maior número digitado entre o número {numero1}, {numero2} e {numero3}");
        }
    }
}
