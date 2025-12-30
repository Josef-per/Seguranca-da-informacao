using System;

// pegando as informações
Console.Write("Insira a quantidade de cigarros fumados p/dia: ");
int cigarros = int.Parse(Console.ReadLine());
Console.Write("Insira à quantos anos fuma: ");
int anos = int.Parse(Console.ReadLine());

// tratando os dados
int tempo = (anos * 365) * (cigarros * 10); //quantidade de minutos fumados
tempo = (tempo / 1440); // divido pela qunatidade de minutos que tem um dia, pra ter quantos dias de vida ele tem;

//Mostrando a resposta
Console.WriteLine($"Considerado que a cada cigarro você perde 10 minutos de vida, você já perdeu {tempo} dias");
