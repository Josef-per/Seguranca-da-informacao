//
// Pegando os valores
Console.Write("Escreva o primeiro número: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Escreva o segundo número: ");
int n2 = int.Parse(Console.ReadLine());

// tratando os valores e fazendo a soma
int soma = n1 + n2; // essa variavel não é tão necessária da pra fazer sem
Console.WriteLine($"A soma dos valores {n1} + {n2} é igual a: {soma}");

/*
    sem a variavel soma
    Console.WriteLine($"A soma dos valores {n1} + {n2} é igual a: {n1+n2}");
*/
