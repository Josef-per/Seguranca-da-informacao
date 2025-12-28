//
// Pegando as informações
Console.Write("Digite um número inteiro: ");
int n = int.Parse(Console.ReadLine());

// tratamento dos dados

int dobro = n * 2;
float terco = n / 3;

// Exibição

Console.WriteLine($"Dobro de {n} = {dobro}, Já um terço de {n} = {terco.ToString("F1")}"); // Pela formatação do ToString("F1"), os valores são arredondados.
