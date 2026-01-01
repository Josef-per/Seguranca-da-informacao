using System;

//Pegando os dados
Console.Write("Insira o ano de nascimento: ");
int ano = int.Parse(Console.ReadLine());

// tratando os dados
int idade = 2026 - ano;
int alistamento = idade - 18;

if (alistamento > 0)
{
    Console.WriteLine($"Já se passaram {alistamento} anos desde o alismtamento militar");
}
else if (alistamento == 0)
{
    Console.WriteLine($"Você já pode se alistar esse ano!");
}
else
{
    Console.WriteLine($"Ainda falta {alistamento * -1} anos para poder se alistar");
}
