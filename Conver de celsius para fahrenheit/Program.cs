Console.WriteLine("bem vindo ao conversor de graus"); 
Console.WriteLine("Informe um valor em Celsius para ser convertido em fahrenheit");
double grausEmCelsius = double.Parse(Console.ReadLine());
double conversao = grausEmCelsius * (1.8) + 32;

Console.WriteLine($"{grausEmCelsius}C equilave a {conversao}F");