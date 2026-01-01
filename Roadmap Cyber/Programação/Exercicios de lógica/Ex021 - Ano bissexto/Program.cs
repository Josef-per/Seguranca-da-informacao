using System;

//Pegando as informações
Console.Write("Insira um ano: ");
int ano = int.Parse(Console.ReadLine());

//tratando os dados e mostranod o resultado
// ano bissexto acontece quando é divisivel por 4 ou  100 ou 400;

if (ano % 4 == 0)
{
    Console.WriteLine($"O ano de {ano} é bissexto");
}
else
{
    Console.WriteLine($"O ano de {ano} não é bissexto");
}
