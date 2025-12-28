using System;
using System.Globalization;

//Pegando as informações
Console.Write("Nome do Funcionário: ");
string NomeFun = Console.ReadLine();
Console.Write($"Salário do Funcionário {NomeFun}: ");
float Salario = float.Parse(Console.ReadLine());

// Tratando as informações e mostrando o resultado
string SalarioFormat = Salario.ToString("C"); //converte direto para moeda mt util
Console.WriteLine($"O Funcionário {NomeFun} tem um salário de {SalarioFormat} , em Julho");
