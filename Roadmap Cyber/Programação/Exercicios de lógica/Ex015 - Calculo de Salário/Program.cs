using System;
using System.Globalization;

//pegando as informações
Console.Write("Quantos dias foram trabalhados: ");
int Dias = int.Parse(Console.ReadLine());

// tratamento de dados
float Sal = (Dias * 8f) * 25f; //Dias * quantidade de horas, Depois valor por horas trabalhadas 25

//Mostrando o resultado
Console.WriteLine($"O salário desse funcionário é de: {Sal.ToString("C")}");
