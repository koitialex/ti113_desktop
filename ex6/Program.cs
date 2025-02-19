namespace ex6
{
    //Faça um algoritmo que pergunte o nome do usuário, o quanto ganha por hora e o número de horas
    //trabalhadas no mês.Calcule o resultado e mostre o nome e o total da renda recebida no mês
    internal class Program
    {
        static void Main(string[] args)
        {
            float renda;
            Console.WriteLine("Digite um nome:");
            string nome = Console.ReadLine()!;
            Console.WriteLine("Quando ganha por hora:");
            float dinheiro = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Numero de horas no mês");
            float horas = float.Parse(Console.ReadLine()!);

            renda = dinheiro * horas;

            Console.WriteLine($"O {nome} tem uma renda mensal de ${renda}");
        }
    }
}
