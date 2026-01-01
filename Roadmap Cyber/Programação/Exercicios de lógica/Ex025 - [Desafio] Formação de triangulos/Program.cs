using System;

//coletando os dados
Console.Write("Insira o tamanho do primeiro segmento de reta: ");
float r1 = float.Parse(Console.ReadLine());
Console.Write("Insira o tamanho do segundo segmento de reta: ");
float r2 = float.Parse(Console.ReadLine());
Console.Write("Insira o tamanho do terceiro segmento de reta: ");
float r3 = float.Parse(Console.ReadLine());

// tratamento de dados
if (r1 < r2 + r3 && r2 < r1 + r3 && r3 < r1 + r2)
{
    Console.Write($"Com os segmentos {r1.ToString("F1")} - {r2.ToString("F1")} - {r3.ToString("F1")} é possivel fazer um triangulo");
}
else
{
    Console.Write($"Com os segmentos {r1.ToString("F1")} - {r2.ToString("F1")} - {r3.ToString("F1")} não é possivel fazer um triangulo");
}
