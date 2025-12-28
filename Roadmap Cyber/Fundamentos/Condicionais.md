# Condições

As condições suportam as comparações matemáticas como <; <=; >; >=; ==; !=. Podendo usar essas condições para performar diferrentes ações dependendo da decisão tomada. Tendo como condições:

- if - Usado para executar um bloco de código caso a condição dele tenhasido atendida, tenha sido verdadeira, retornando um true
- else - Executa um bloco de código caso a condição if não seja atendida, retornando assim um false
- else if - Adiciona uma nova condição caso a anterior tenha retornado um false
- switch - Especifica diversos blocos de código.

## if

O código só é executa caso seja verdadeira a condição

> Como no exemplo
> ``
    if (condição)
    {
      //bloco a ser executado
    }
  ``
> Note que se escerver IF em maiúsculo vai dar tudo errado gerando um erro

> Exemplo de aplicação
> `` 
    if (20 > 18)
    {
      Console.WriteLine("20 é maior que 18");
    }
  ``

Nos lugares dos números podem ser variaveis, contando que as duas somparem os mesmos tipos de dados, caso contrário sempre que for fazer a comparação, vai ter um retorno falso (vai sempre cair no else).

## else

Especifica um bloco de código caso a condição seja falsa

> Como no exemplo
> `` 
    if (condição) 
    {
      //bloco a ser executado
    }
    else 
    {
      //bloco a ser executado
    }
  ``

A lógica permanece a emsmo do if, mas com essa variações explicadas, onde um executa se for true (if), a outra se for false (else)

## else if

Usado logo após o if para especificar uma noca condicional, caso seja negativa cai no else, ou em um novo else if

> Como no exemplo
> `` 
    if (condição 1) 
    {
      // bloco
    }
    else if (condição 2) 
    {
      //bloco
    }
    else 
    {
      //bloco
    }
  ``

Lembrando que pode adicionar um if dentro do outro if sem nenhum problema, contudo que feche tudo certo depois.

## Ternary Operator
  
É uma forma curta e mais rápida (em questão de processamento) funciona igual o if + else, sem alternativas para o else if, assim fazendo somente comoparações mais simples entre unicamente duas variaveis / dois fatores.

> Como no exemplo
> `` variavel = (condição) ? "Resultado true" : "Resultado false"``

Eu achei meio feio e dificil de ver, mas buscando suas aplicações, vi que é muito utlizada como controle de drones ou algo que precise de ser muito rápido pois cada milésimo importa.

> Outro exemplo
> `` 
    int time = 20;
    string result = (time > 18) ? "É sim" : "Né não";
    Console.WriteLine(result);
  ``

## Switch

Você seleciona um dos diversos blocos que podem ser executados. Contudo o switch precisa do default sendo o seu else, caso entre em nenhum caso de blocos, vai ir parar no default.

> Como no exemplo
> `` 
    int day = 4
    switch (day) 
    {
      case 6 : 
        Console.WriteLine("...");
        Break;
      Case 7: 
        Console.WriteLine("...");
        Break;
      Default:
        Console.WriteLine("...");
        Break;
    }
  ``

Sempre que um bloco chega ao fim é preciso colocar o break, para poder finalizar o bloco e poder começar a escrever o próximo.
