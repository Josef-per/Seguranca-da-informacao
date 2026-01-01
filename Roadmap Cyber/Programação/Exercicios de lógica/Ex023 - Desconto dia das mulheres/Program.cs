using System;
using System.Globalization;

//Pegando as informações
Console.Write("Informe o seu sexo \nMasculino [1] Feminino[2]\n->");
int sexo = int.Parse(Console.ReadLine());
Console.Write("Insira o seu nome: ");
string nome = Console.ReadLine();
Console.Write("Insira o total das suas compras: ");
float compras = float.Parse(Console.ReadLine());

//tratamento dos dados
if (sexo == 1)
{
    compras = compras * 0.95f; //5% de desconto para homens
}
else
{
    compras = compras * 0.87f; //13% de desconto para mulheres
}

//mostrando o resultado
//dava pra fazer dentor do if mas dessa vez descidi fazer diferente

Console.WriteLine($"{nome} o total da sua compra ficou em {compras.ToString("C")} com desconto promocional aplicado \nTenha um bom dia!");
