# Número de casas decimais

Bem pra trocar a quantidade de casas decimais, é só fazer uma conversão e colocar a quantidade de casas como F1, uma casa, F2, duas casas e assim vai, contudo, sempre que o fizer ele vai arredondar um pouco, ent acaba perdendo um pouco de precisão.

> Forma 1
>`` float x = 20.788888;
    float xy = x.ToString("F2");
    Console.WriteLine(xy);
  ``

> Forma 2
> `` float x = 20.7888888;
     Console.WriteLine(x.ToString("F2"))
  ``
