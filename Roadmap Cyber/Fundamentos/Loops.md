# Loops

Loops conseguem executar um bloco de código enquanto alguma condição for verdadeira, enquanto ela ainda estiver sendo atendida o bloco de código parmanece inalterado e executando até que a mesma pare de ser verdadeira

Existem alguns tipos de loops em C# sendo

- **While lopp**
  
Uma forma interessante de enterder o while loop é em pensar que enquanto algo estiver acontecendo, o bloco vai continuar sendo executado, sua sintaxe é simples e fácil de entender
  
>``
    while (condição)
    {
      //bloco executado
    }
  ``

Ou seja para poder fazer o while loop funcionar precisamos somente de uma condição verdadeira. Assim abrinco espaço para novas utlizações, jeitos diferentes de utilizar essa sua funcionalidade

> Como nesse exemplo
> `` 
    bool repet = true;
    while (repet) 
    {
      Console.WriteLine("Eu repeti");
      //nesse caso temos um loop infinito pois ele para nunca, nesse caso podemos parar ele com o break
      break;
    }
  ``

Nesse exemplo acima podemos ver que é possível utlizar uma váriavel de tipo bool como true, pra poder fazer o while funcionar, pois mesmo que não esteja acontecendo uma condição formal como estamos acostumados, ela ainda está sendo atendida sendo verdadeira.

Por fim temos a sua variação, onde podemos coloar o código a ser executado primeiro e a condição em seguida, isso é bom para casos que o código tem que ser executado uma vez, para depois se for atendido os requisitos pode continuar e entrar em loop.

> Como no exemplo
> `` 
    do 
    {
      // codigo
    }
    while (condição);
  ``

Sobre o while é isso que precisamos, ele é simples e perfeito pra ser uilizado quando sabemos de algum limite claro, que não necessáriamente é contabil.

- **for loop**

O for ele é mais utilizado em diversos casos, tendo na minha visão um pouco mais de aplicação que o while, mas claro não da somente para usar ele. Sua estrutura é muito mais complexa em comparção, mas nada dificil de se fazer ou mesmo manter.

Para que funcione o for precisa de 3 coisas

1. Variavel inicial, essa pode ser declarada dentro dele ou utilizada por fora, sendo um int (executa somente uma vez)
2. Condição de repetição, essa parte é importante pois ela define a condição de repetição para que o for continue (vai ser verificado a cada loop)
3. Passo de incremento da variavel inicial vai ser incrementada, pode ser i++, +2 -100, vai a necessidade (vai ser incrementado a cada loop)

Se todos esses 3 paços forem feitos com sucesso, não vai ter problemas alguns em fazer ele funcionar.

> Como no exemplo
> `` 
    for (int n = 0; n < 5; n++)
    {
      Console.WriteLine(n);
    }
  ``

Uma ultima coisa, pode se colocar um loop dentro do outro, o interessante que o loop de fora ele vai só repetir quando o loop de dentro acabar.

- **Foreach loop**

Ele só serve se vc tiver utilizando um array, ele de forma simples vai meio que andar pelo array de elementos, contudo o for consegue fazer o mesmo, um pouco mais verboso e com mais chances de erro, mas consegue ter a mesma funcionalidade.

Foreach ele serve perfeitamente para arrays, mas tambem qualquer outro tipo de lista de dados que precisam ser passados 1 a 1, como uma lista json ou algo do tipo 

Sua syntaxe é simples muito parecida com o while, mas claro depende somente de uma lista para ter o seu termino, de todos os laços de repetição ele é o único que não precisa de uma condição lógica, sendo sua única condição um array de elementos.

> Como no exemplo 
> ``
    string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
    foreach (string i in cars) 
    {
      Console.WriteLine(i);
    }
  `` 

Note que a variavel dentro dele tem que condizer com o tipo dos dados do array, ent se for um array de números dentro de sua chava tem que ser 
``
  foreach (int variacel in array)
  {
    //codigo
  }
``

Por fim acabamos o nosso aprofundamento sobre loops !!.
