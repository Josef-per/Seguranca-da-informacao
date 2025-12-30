using System;

//pegando as informações
Console.Write("Insira a velocidade do carro: ");
int vel = int.Parse(Console.ReadLine());


//tratamento dos dados
double multa = 0d;
int velPass = 0;

if (vel > 80)
{
    velPass = vel - 80;
    multa = velPass * 5d;

    //Mostrando o resultado
    Console.WriteLine($"Você foi multado por ultrapassar o limite de velocidade \nValor da multa: {multa.ToString("C")}");
}
else
{
    Console.WriteLine("Você manteve no limite de velocidade, continue assim !");
}
