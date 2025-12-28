using System;

//
// Pegando as informações
Console.Write("Informe a altura da parede: ");
float alt = float.Parse(Console.ReadLine());
Console.Write("Informe a largura da parede: ");
float larg = float.Parse(Console.ReadLine());

//tratamento dos dados
float area = alt * larg;
float tinta = area / 2;

//Mostrando os dados
Console.WriteLine($"Para pintar essa parede vai ser necessário {tinta.ToString("F2")} baldes de tinta");
