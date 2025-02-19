namespace ex5
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
            Console.WriteLine("Digite 3° número");
            float numero3 = float.Parse(Console.ReadLine()!);

            if (numero1 > numero2 && numero1 > numero3)
            {
                maior = numero1;
                menor = numero3;

            }
            else if (numero2 > numero3 && numero2 > numero1)
            {
                maior = numero2;
                menor = numero1;

            }
            else
            {
                maior = numero3;
                menor = numero2;
            }

            Console.WriteLine($"O número {maior} é o maior" + 
                $" O número {menor} é o menor número");
        }
    }
}
