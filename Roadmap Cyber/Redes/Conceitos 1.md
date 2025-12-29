# Conceitos de redes

Aqui estão as minhas anotações e o que eu entendi sobre redes até o momento

- **ip** 

Internet Protocol, ele serve como uma etiqueta digital para o pc, onde nele podemos encontrar as seguintes informações, a rede e o host (número da máquina). O número de ip é recebido quando vc se conecta a uma rede, na mesma rede vc nunca pode ter dois aparelhos com o mesmo ip

O ip tem duas versões o IPv4 e o IPv6. IPv4 ele só recebe números decimais, já o IPv6 ele é hexadecial, um ponto importante é que o ip, apesar de parecer números ao pesquisr por ele na verdade é um conjunto binário gigantesto, sendo o IPv4 - 32 bits e o IPv6 - 128bits

O ip mais utilizado no Brasil é a versão 4, sendo composta por 4 octetos de bits, temos como um exemplo comum de ip 192.168.1.12 (isso é um ip)

- **dns** 

É uma lista de ips de sites dominios e lugares acessiveis da internet, ele serve como um tradutor simultâneo, pois ao colocar na barra de pesquisa algum site escrito como o nome dele tipo o Proton. 

O DNS é um servidor próprio, onde pode estar em diversos lugares, como o nosso próprio roteador que fica na nossa casa, onde tem um serviço dns, menor com os sites mais comuns, contudo há um serviço dns, na qual vai converter o meu hostname, em um ip de fáicl utilização.

- **http/https**

O protocolo de tranferencia de hypertexto (http), serve para que os servidores se comuniquem com seus clientes, um exemplo é quando entra em algum site, é feita um requisição http, para que o site possa ser enviado para o cliente, assim abrindo na sua máquina. Já o https, funciona da mesma forma, sendo somente uma atualização do http, sendo sua diferença a segurança nessa troca de informações, o https, ele faz uma criptografia para que a comunicação seja isolada evidando o ambiente externos ou pessoas mal intensionadas

- **porta**

A porta é como se fosse a caixa postal, ou melhor uma mesa, é por onde a comunicação é feita, elas tanto começam pela porta quanto terminam pela porta, cada porta tem o seu número, e cada conexão tem sua porta.

- **TCP e UDP**

Tcp transmite informações com segurança e confiabilidade sacrificando sua velocidade, é muito utilizado em dowloads de arquivos, sites https, transferencias de emails, vc vai utilizar ele equando a segurança e a confiabiliade dos dados dor a sua maior precupação caso seja a velocidade é recomendo utilizar o UDP, pois o Udp priocisa a eficiencia e a velocidade, assim no caminho podendo perder alguns dados, perda de pacotes, é muito utilizado em jogos online videos e streaming.

Uma diferença grande deles é que o Tcp é um protocolo baseado em conexão, já o Udp não se baseia em conexão.

Nenhuma é melhor que a outra, pois as duas tem suas partes e aplicações, uma pode ser ruim para um tipo de aplicação, enquanto a outra não serve, tudo vai depender da aplicação que se está utlizando.
