namespace ex6
{
    //Faça um algoritmo que pergunte o nome do usuário, o quanto ganha por hora e o número de horas
    //trabalhadas no mês.Calcule o resultado e mostre o nome e o total da renda recebida no mês
    internal class Program
    {
        static void Main(string[] args)
        {
            double renda;
            Console.Write("Digite um nome:");
            string nome = Console.ReadLine()!;

            Console.Write("Quando ganha por hora:");
            double dinheiro = Convert.ToInt16(Console.ReadLine());

            Console.Write("Numero de horas no mês");
            short horas = Convert.ToInt16(Console.ReadLine());

            renda = dinheiro * horas;

            Console.Write($"O {nome} tem uma renda mensal de ${renda}");
        }
    }
}
