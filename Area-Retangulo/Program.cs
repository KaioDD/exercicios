using Area_Retangulo;
using System.Globalization;

Console.WriteLine("Informe a largura e altura do triangulo");

Retangulo r = new Retangulo();
r.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
r.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.WriteLine($"Area do retangulo: {r.CalcularArea()}");
Console.WriteLine($"Perimeto do retangulo: {r.CalcularPerimetro()}");
Console.WriteLine($"Diagonal do retangulo: {r.CalcularDiagonal()}");



