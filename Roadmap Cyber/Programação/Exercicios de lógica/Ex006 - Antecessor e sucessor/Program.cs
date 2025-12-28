//
//Pegando as informações
Console.Write("Digite um número inteiro: ");
int n = int.Parse(Console.ReadLine());

//tratamento e exebição
//eu vou optar por criar as variaveis mas dava pra fazer tudo direto quando for mostrar

int antecessor = n - 1;
int sucessor = n + 1;

Console.WriteLine($"O sucessor do número {n} é: {sucessor}");
Console.WriteLine($"O antecessor do número {n} é: {antecessor}");
