namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            string num1 = Console.ReadLine();

            Console.WriteLine("Digite o segundo valor: ");
            string num2 = Console.ReadLine();

            int numero1 = int.Parse(num1);
            int numero2 = int.Parse(num2);

            Console.WriteLine("A soma dos valores é: " +(numero1 + numero2));

            



        }
    }
}
