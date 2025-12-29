using System;
using System.Globalization;

// Pegando as informações
Console.Write("Insira o valor do salário: ");
double OldSal = double.Parse(Console.ReadLine());

//Aumento de 15%
double NewSal = OldSal * 1.15d;

//mostrando as informações
Console.WriteLine($"O novo salário sera de: {NewSal.ToString("C")}");
