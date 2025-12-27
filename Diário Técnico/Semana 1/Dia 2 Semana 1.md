# Programação real 

Hoje vou voltar mais pra linguagem, a que eu escolhi para começar e fazer a maioria dos meus projetos vai ser c#, bem hoje eu vou dar uma olhada estudada e anotada em 

1. Variaveis
2. Condições 
3. Laços
4. Funções

Além disso pretendo fazer alguns projetos, como uma calculadora do win forms ou coisa do tipo, ainda a descidir, mas oque for feito vai ser documentado aqui posteriormente

## Variaveis 

C# é uma linguagem fortimente tipada então preciso adicionar o tipo da variavel o seu nome e o seu valor, bem antes de adicionar um exemplo acho interessante falar sobre o que é uma variavel e de maneira básica é um espaço onde um valor vai ser armazenado, o valor armazenado vai dependeder de seu tipo, como disse antes fortemente tipada. 

``int x = 2;``

Bem isso é um exemplo de criação da variavel x, onde o valor dela é 2. Para chamar a variavel só precisa escrever o nome dela que ela já vai ser chamada como no exemplo abaixo 

``Console.WriteLine(x);
  //No console vai ser apresentado o valor de x, que no caso é 2``

Há diversos tipos de variáveis, mas a mais comuns e mais utilizadas para a maioria das situações são

1. Sting (para textos)
2. int (números inteiros)
3. double (números com virgula, contudo somente duas casas decimais)
4. char (um caractere)
5. bool (valores como true or false)
6. decimal (mesmo sentido do double mas é bem maior com mais casas decimais, melhor para dinheiro)

Por fim mas não menos importante as váriaveis podem mudar de valor quando for preciso, colocando somente seu nome e atribuindo assim um novo valor a ela, que condiza com o mesmo tipo de seu valor, contudo há como criar variaveis que não mudam nunca o seu valor que são as constantes, sendo criadas basicamente da mesma forma com a simples diferença de um detalhe

``const int x = 3``

Agora x sempre sera do valor de 3, nunca vai poder mudar, mesmo que chamem ela e tentem atribuir um novo valor ela nunca vai mudar.

Há diversas formas de mostrar as variaveis uma delas é como apresentado em um dos exemplos, mas há um jeito bem melhor a minha visão que é pela interpolação, perfeito quando precisa adicionar uma váriavel a meio de textos

``Console.WriteLine($"Esse é o valor de {x}")``

## Condições

Bem condições, elas servem para comparar dois valores ou duas expressões de valores, tendo uma estrutura como 

``
if (condição)
{
  O que vc quer que aconteça se for verdadeiro
} 
else if (condição 2)
{
  caso não seja verdadeiro a primeira, mas pode ser nessa condição
}
else 
{
  nenhuma das condições foram aceitas ela cai aqui
}
``

Podemos utilizar nas contições diferentes sentidos como ==, !=, >, <, <=, >=.

Uma alternativa pouco utilizada para condições são os swtichs onde temos os casos, funciona como um if e else, contudo eles normalmente não são mt maleaveis, temos como mais comum utlizar os if and else.

## Laços

Esses laços são de repetição onde uma certa parte do código vai ser repetida até que certa condição seja completa para terminar o loop, tem que tomar muito cuidado com essa parte, pois é comum ter loops infinitos, em alguma parte e isso não é nem um pouco legal de se ver, garanto.

O primeiro loop que vi foi o while, que ele vai repetir enquanto a condição que tiver nele for verdadeira, quando for falsa, ele vai parar a repetição.

``while (condição) 
{
  // código que vai ser repetido 
  break; // esse código ele quebra a repetição, independete do que acontece o loop para se tiver isso, assim use quando necessário.
}
``

Pelo que vi é muito melhor vc utilizar ele quando já se tem os valores exatos que precisa, quando são valores que ainda vão ser adicionados, fica mais complicado e dificil de utilizar. 

Ele tem uma forma alternativa, sendo o do while, onde o código é executado e depois a verificação, do loop, isso garante que o código vai ser executado pelo menos uma vez, diferente do exemplo anterior que caso a condição já seja falsa ele nunca executa o código de dentro

``do 
{
  //código que vai ser executado
}
while (condição);
``

Vejo sua aplicação, mas não me vejo utlizando muito.

Agora voltando um pouco para o for, vejo que apesar de ter uma sintaxe bem maior e um pouco mais complicada, ela é a melhor a se utilizar a minha visão, principalmente quando não se tem algum valor, ou que algum valor possa mudar de uma hora pra outra 

``
for (int i = 0; i < 5; i++) 
{
  Console.WriteLine(i);
}
``

Ele é separado, em 3 estagios, o primeiro vc vai definir uma variavel de começo como seria o start dele, por onde ele vai começar, em seguida a condição do loop, que enquanto for verdadeiro ainda vai estar em loop, por fim de quanto em quanto vai almentar o valor da variavel adcionada no primeiro estagio.

Além dele temos uma variação sua sendo o foreach, onde nela vai ser mais utilizada com arrays de alementos, muito bom no caso de POO, onde temos uma lista de elemtenos.

``
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string i in cars) 
{
  Console.WriteLine(i);
}
``

De loops acho que é só isso mesmo 

## Funções / metodos

Em c# as funções são chamadas de metodos, onde nelas vai ser um bloco de código que só vai ser executado quando for chamado, metodos eles podem passar valores iniciais para eles os parametros e outras funções.

``
class Program
{
  static void MetodoExemplo() 
  {
    // código a ser executado
    // uma boa prática é sempre iniciar o metodo por uma letra maiuscula.
  }
}
``

Nesse exemplo temos um metodo void, onde nele não temos o retorno de nenhum valor, em baixo temos um metodo com um parametro de nome onde, onde os (), são preenchidos com o valor da variavel utilzada

``
static void MyMethod(string fname //recebendo o valor de parametro) 
{
  Console.WriteLine(fname + " Refsnes") ///codigo a ser executado;
}
static void Main(string[] args) //init do programa
{
  MyMethod("Liam"); //passando o valor para o metodo
  MyMethod("Jenny");
  MyMethod("Anja");
}
``

Quando for utilizar o return não posso mais utilizar o void, e ss o tipo do dado que vou estar retornando do meu parametro.

``
static int MyMethod(int x) 
{
  return 5 + x; //metodo retorna um valor.
}
static void Main(string[] args)
{
  Console.WriteLine(MyMethod(3));
} 
``

Acho que é só isso de teoria por hoje, agora para colocar isso em pratica vou tentar fazer três exercicios / pequenos projetos, sendo 

1. Verificador de senha (em um ambiente de login ou cadastro)
2. Contador (vibe cronometro / timer)
3. Calculadora (Mini projeto, sendo uma calc simples)
