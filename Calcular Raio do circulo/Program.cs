Console.WriteLine("Bem vindo a calculadora de área ");
Console.WriteLine("Informe o valor do Raio do circulo:");
 
double raio = double.Parse(Console.ReadLine());

double area = Math.PI * Math.Pow(raio,2);
// Math.Pow(Valor , Valor que sera elevado), no caso da expressão acima seria o valor de raio elevado a 2. 

Console.WriteLine($"A area do circulo é: {area}");
