using Media_Salarial;

internal class Program
{
    public static void Main(string[] args)
    {
        Funcionario f1 = new Funcionario();
        Funcionario f2 = new Funcionario();

        f1.Nome = "kaio";
        f1.Salario = 3000.00;

        f2.Nome = "Pedro";
        f2.Salario = 2500.00;

        var mediaSalarial = f1.Salario + f2.Salario / 2;

        Console.WriteLine($"A media salarial é: {mediaSalarial}");
    }
}