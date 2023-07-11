using Verificador_de_idade;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Kaio";
        Console.WriteLine($"Insira a idade de {p1.Nome}");
        p1.idade = int.Parse(Console.ReadLine());

        Pessoa p2 = new Pessoa();
        p2.Nome = "Bia";
        Console.WriteLine($"Insira a idade de {p2.Nome}");
        p2.idade = int.Parse((Console.ReadLine()));

        if (p1.idade > p2.idade)
        {
            Console.WriteLine("Kaio é mais velho que bia");
        }
        else if (p1.idade == p2.idade)
        {
            Console.WriteLine("Ambos tem a mesma idade");
        }
        else
        {
            Console.WriteLine("Bia é mais velha que kaio"); 
        }

    }
}