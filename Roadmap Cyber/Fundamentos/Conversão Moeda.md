# Conversão de moeda

Essa anotação tem referencia ao Ex003 - Nome e Salário, onde nele eu preciso fazer uma conversão de moeda para mostrar o salário da pessoa, sendo que existe uma conversão uma pequena conversão que pode facilitar muito a vida pra isso, assim anoto ela aqui e em alguns exemplos.

``string Conversão = ValorAntigo.ToString("C")
  Concole.WriteLine($"Salário: {Conversão}")
``

Esse ToString("C"), vai converter o valor direto para dinherio adicionando até mesmo o R$, com somente 2 números apos a virgula.
