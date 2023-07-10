internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo ao verificador de Numero PAR");
        Console.WriteLine("Insira um numero inteiro para saber se é par ou impar");

        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine($"O {numero} é par ");
        }
        else
        {
            Console.WriteLine($"O {numero} não é par");
        }
    }
}