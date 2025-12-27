# Variavel 

É um espaço de memoria dedicada para uma variavel, onde sera guardado as informações, em C# temos os seguintes tipos de variaveis

| Tipo de dado | Tamanho | Descrição
------------------------------------
| int          | 4 bytes | Armazena valores de -2,147,483,648 até 2,147,483,647 (númericos)
| long         | 8 bytes | Armazena valores de -9,223,372,036,854,775,808 até 9,223,372,036,854,775,807 (númericos)
| float        | 4 bytes | Armazena valores decimais, sendo 6 a 7 após a virgula
| double       | 8 bytes | Armazena valores decimais, sendo até 115 digitos após a virgula
| bool         | 1 byte  | Armazena valores de true or false
| char         | 2 bytes | Armazena um unico caractere
| string       | 2 bytes p/ char | Armazena uma string de caracteres.
------------------------------------

Essa tabela foi de retirada da W3schools, onde foi uma boa parte da minha base teorica para toda a minha pesquisa de fundamentos,

## Tipos númericos

### int 

Sendo o mais utilizado e o mais comum tendo sua estrutura simples, vai caber normalmente em todos os contextos que vai se precisar guardar algum número.

> Como no exemplo 
> ``ìnt x = 2;
    Concole.WriteLine(x);
  ``

### long 

Funciona da mesma maneira que o int, só que menos utilizado por guardar números extremamente grandes, em situações de aplicações basicas ele não é muito utilizado, se for. Porém ele tem um adendo o número ao final precisa ter uma terminação especifica, sendo qeu ao final dele é necessário da letra L ao ser declarado.

> Como no exemplo
> `` long x = 15000000000L;
     Concole.WriteLine(x);
  ``

### float

Para numeros decimais, utilizaria principalmente para pequenos decimais que não precisam de tanta precisão, como angulos, graus e outros. Como o long o float precisa de uma terminação sendo o F

> Como no exemplo
> `` float y = 5.75F;
     Console.WriteLine(y);
  ``

### decimal

Seguie as mesmas regras do float, só com uma unica diferença, ele é muito maior, utilizar principalmente para tratar dinheiro, como investimentos, transações bancarias, balanço de mercado, onde cada centavo importa muito. Ele também tem sua terminação a letra D.

> Como no exemplo
> `` decimal y = 5.75D;
     Console.WriteLine(y);
  ``

## Booleans

O tipo boolean, ele é basicamente um sim ou não, true or false, onde você pode declarar se alguma variavel tem um efeito positivo ou negativo, eles são mais usados em testes de condicionais (Arquivo relacionado a Roadmap Cyber/Fundamentos/Condicionais.md)

> Como no exemplo.
> `` boolean Online =  true;
     Console.WriteLine(Online);
   ``

## Char

Armazena somente um caractere, pode ser utilizado para fazer medias escolares que usam mensão como nos EUA, além disso é diferente o jeito que deve ser declarado a variavél pois ela é declarada em aspas simples.

> Como no exemplo
> `` char Nota = 'A';
     Console.WriteLine(A);
  ``

## String 

Armazena frases ou textos inteiros dentro de uma variavel, é um dos tipos mais utlizado juntamente do int, nele é preciso fazer a declaração utilzando aspas duplas

> Como no exemplo
> `` string nome = "Josef";
    Console.WriteLine(nome);
  ``

---

Bem isso é tudo sobre variaveis que tenho como fundamento.
