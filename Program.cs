using Humanizer;

Console.WriteLine("Ingresa un nombre:");
var nombre = Console.ReadLine();
Console.WriteLine("Cargo:");
var cargo = Console.ReadLine();
Console.WriteLine("Edad:");
var edad = int.Parse(Console.ReadLine());

Console.WriteLine($"Mi nombre es {nombre}, trabajo como {cargo} y tengo {edad.ToWords()} añoss");