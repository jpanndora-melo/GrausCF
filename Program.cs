Console.Write("Digite a temperatura em graus Celsius: ");
double Celsius = Convert.ToDouble(Console.ReadLine());
double tempF = Celsius * 1.8 + 32;
Console.WriteLine($"{Celsius}°C equivalem a {tempF}°F");