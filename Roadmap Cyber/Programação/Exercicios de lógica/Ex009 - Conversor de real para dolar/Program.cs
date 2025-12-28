using System;
using System.Globalization; //ajustar a moeda

//
// Pegando as informações
Console.Write("Digite a quantidade em Real: ");
float real = float.Parse(Console.ReadLine());

// tratamento dos dados
// Levei em conta o mesmo valor do dolar que está na apostila (3,45)

float dolar = real / 3.45f;

//Exibição dos dados

Console.WriteLine($"Você pode comprar: {dolar.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
