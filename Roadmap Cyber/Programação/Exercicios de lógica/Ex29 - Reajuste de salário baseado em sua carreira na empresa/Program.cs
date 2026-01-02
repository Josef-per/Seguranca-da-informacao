using System;
using System.Globalization;

Console.Write("Insira o nome do funcionário: ");
string nome = Console.ReadLine();
Console.Write("Insira o ano que foi contratado: ");
int ano = int.Parse(Console.ReadLine()) - 2025;
Console.Write("Insira o seu salário atual: ");
float salario = float.Parse(Console.ReadLine());

if (nao <= 3)
{
    salario = salario * 1.03f;
    Console.Write($"O funcionário {nome} por ter {ano} anos na empresa vai ter um reajuste salárial de {salario.ToString("C")}");
}
else if (ano > 3 && ano <= 10)
{
    salario = salario * 1.125f;
    Console.Write($"O funcionário {nome} por ter {ano} anos na empresa vai ter um reajuste salárial de {salario.ToString("C")}");
}
else
{
    salario = salario * 1.2f;
    Console.Write($"O funcionário {nome} por ter {ano} anos na empresa vai ter um reajuste salárial de {salario.ToString("C")}");
}
