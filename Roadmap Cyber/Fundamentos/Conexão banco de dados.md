# Conectar um banco de dados

Para fazer a conexão com um banco de dados vamos precisar incialmente de uma string de conexão, há diversas formas de fazer, como construir ela toda vez que for precisar utlizar o seu banco de dados, ou da forma mais interessante na minha visão, que é a construção de uma classe no projeto, essa classe pode ser utilizada em qualquer lugar do projeto, assim vc só chama a sua classe não tendo que criar a conexão toda vez que for utilizar ela.

Para fazer uma classe de conexão primeira criamos uma classe no projeot, em seguida criamos a string de conexão ficando dessa forma 

> `` private static string connectionString =
    "Server=localhost; Database=db_app_login; Uid=root; pwd=R5U%kpidy#Zugp"; ``

A string de conexão MySql (depende de cada banco), é composta da seguinte forma Server=Nome do servidor; Database=Nome do banco; Uid=Usuario; pwd=Senha do servidor. Com isso temos a nossa string de conexão local, como feita no projeto 1, caso fosse necessário fazer uma string de conexão cloud, poucas coisas vão mudar, se realmente for mudar algo além disso.

Logo em seguida depois de criar a string de conexão vamos criar um método para poder puxar essa string, esse metodo é responsável por fazer a nossa string ficar funcional como uma classe podendo ser invocado em outros lugares do projeto, ficando dessa forma 

> ``
    public static MySqlConnection GetSqlConnection()
    {
      return new MySqlConnection(connectionString);
    }
  `` 

Observe que precisamos utilizar o MySqlConnection, toda vez que for necessário puxar a conexão, em seguida o GetSqlConnection para assim poder pegar ela, onde vai retornar a nossa string de conexão.

Dessa forma a classe de conexão do banco de dados está pronta para uso.

Podemos utlizar ela da seguite forma 

> `` MySqlConnection conn = DbConnection.GetSqlConnection(); ``

Observe que utlizamos o código de conexão atribuindo um nome a ele com uma variavel, após o igual temos que colocar o nome da nossa classe, como feito com DbConnection, assim já que estamos utlizando a nossa classe de conexão vamos assim puxar a conexão que temos como a string pelo GetSqlConnection.

Assim ela já está em uso, muito mais fácil que fazer toda a srting de conexão quando for precisar utlizar o banco de dados.
