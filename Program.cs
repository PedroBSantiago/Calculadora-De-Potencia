Console.Clear();

double b,expoente,potencia;

Console.WriteLine("calculadora de potencia");

Console.Write("base:");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("expoente:");
expoente = Convert.ToDouble(Console.ReadLine());

potencia = Math.Pow(b,expoente);

Console.WriteLine($"resultado:{potencia:N2}");