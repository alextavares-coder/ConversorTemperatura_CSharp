using ConversorTemperatura.App;

var conversor = new CalculadoraTemperatura();

Console.Write("Temperatura em Celsius: ");
double c = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Fahrenheit: {conversor.ParaFahrenheit(c):F1}");