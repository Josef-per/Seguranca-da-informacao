# Metodos

Um metodo é um bloco de código que contem uma série de instruções, os métodos em c# são tudo, pois todos so códigos funcionam dentro de métodos e em contextos de métodos, como por exemplo o main, os métodos são executados somente ao serem chamados, assim presta atenção se você fez o metodo e chamou ele em seu lugar de ativação, caso contrário nada vai acontecer, pois ele não está sendo chamado, um dos unicos métodos que não precisam ser chamados é o main, que funciona diretamente ao iniciar a aplicação.

Você pode passar informações para dentro de um método, também conhecido como parâmetros. Os metodos tambem podem ser chamados de functions, ou funções no portugues, eles são muito utilizados para reutilizar códigos, como por exemplo em um menu onde temos as bebidas comidas e sobremesas, cada uma dessas sessões pode ser um método diferente que ao serem chamados mostrando o cardapio de acordo. Os metodos só funcionam dentro de uma classe.

Os metodos eles podem pertencem a duas coisas classes ou objetos, quando pertencem a objetos eles já estão fazendo mais parte de POO, caso estejam fazendo parte de uma classe eles funcionam bem mais como uma função um bloco de código utlizado em qualquer lugar se chamado.

Podemos criar metodos dessa forma 

`` 
class Program
{
  static void NomeMetodo() 
  {
    // Codigo a ser executado
  }
}
``

> Note que uma boa pratica é começar os métodos com uma letra Maiuscula sempre, pois facilita a leitura e a manutenção do código.

Podemos indentificar os métodos por uma forma muito simples, sua priemira frase no código, o do exemplo acima mostra que ele pertence somente a uma classe, pois é static, quando o metodo ele pertence a um objeto (sendo as funcionalidades desse objeto), sua primeira frase vai ser o nível de encapsulamento que só podem ser de 3 níveis, public, private, protect. Eles serão mais detalhados em seus respetivos documentos (POO.md e Encapsulamento.md) 

## Parâmetros

São muito importantes para os métodos, com eles diversas portas são abertas para o que se pode fazer, os parâmetros são informações que passam para dentro do método, fazemos isso quando precisamos de alguma informação de fora do método, pois dentro do método é nada sai, ou seja caso alguma variavel seja criada dentro de um método ela via funcionar sometne dentro do método e não fora, já as de fora caso não sejam variaveis globais, tambem não funcionaram.

Assim se passam as informações necessárias como parâmetros dentro do método

> Como no exemplo
> `` 
    static void MyMethod(string fname) 
    {
      Console.WriteLine(fname + " Refsnes");
    }
    static void Main(string[] args)
    {
      MyMethod("Liam"); //argument
      MyMethod("Jenny");
      MyMethod("Anja");
    }
  ``

Todo parâmetro tem que ter o seu tipo de dados, ou seja se for passar um número ele tem que vir como int nos parenteses do método, as informações que estão sendo puxadas são chamadas de argument

Caso precise passar mais de um parâmetro é só separar eles por virgula e utilizar igualmente como se fosse com um só, as coisas não mudam tanto assim.

Há como fazer parametros opcionais, como são conehcidos, que basicamente você declara um valor para o seu parâmetro dentro, assim quando chegar alguem argument vazio, ele vai adiquirir o valor daquele parâmetro

> Como no exemplo 
> `` 
    static void MyMethod(string country = "Norway") 
    {
      Console.WriteLine(country);
    }
    static void Main(string[] args)
    {
      MyMethod("Sweden");
      MyMethod("India");
      MyMethod();
      MyMethod("USA");
    }
// Sweden
// India
// Norway
// USA
  ``

Além disso metodos podem retornar valores, que é muito utilzado, tanto que já foi até mesmo utlizado no projeto 1. Quando queremos um retorno de algum valro de um metodo precisamos decidir qual vai ser a saida dele como ind, decimal, string, bool, algum dos tipos primitivos, para no final utilizando o return, para poder retornar o que precisamos. 

> como no exemplo
> `` 
    static int MyMethod(int x) 
    {
      return 5 + x;
    }
    static void Main(string[] args)
    {
      Console.WriteLine(MyMethod(3));
    }
    // Outputs 8 (5 + 3)
  ``

## Overload

Muito utilizado em POO, mas sendo basico, acontece quando o metodo tem o mesmo nome mas assinaturas diferente, fazendo assim trabalhar com dois tipos diferentes de dados.

> Exemplo
> `` 
    static int PlusMethod(int x, int y)
    {
      return x + y;
    }
    static double PlusMethod(double x, double y)
    {
      return x + y;
    }
    static void Main(string[] args)
    {
      int myNum1 = PlusMethod(8, 5);
      double myNum2 = PlusMethod(4.3, 6.26);
      Console.WriteLine("Int: " + myNum1);
      Console.WriteLine("Double: " + myNum2);
    }
  ``

Aqui temos um metodo onde Funciona tanto com int quanto com double, sempre faça um overload, quando precisar que dois metodos façam a mesma coisa só que com tios de dados diferentes, assim ele trabalha perfeitamente.

Por enquanto é tudo isos que sei sobre metódos, provavelmente atualizações virão.
