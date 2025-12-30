# Comunicações em um mundo conectado

Conteudos do modulo

1. Tipos de rede
2. Transmissão de dados
3. Largura de banda e taxa de transferencia

## Tipos de redes

**Redes locais** tambem conhecidas como SOHO (Pequenos escritórios domesticos), esse tipo de rede normalmente compartilha as coisas entre si como impressoras, documentos, fotos e outros arquivos ou dispositivos que possam se conectar.

**Redes Médias e Grandes** Normalmente utilizadas em empresas ou medio negocios, normalmente tem muitos lugares e diversas conexões, assim tendo centanes ou milhares de hosts conectados.

**Rede Mundia** Basicamente a internet, ela é composta pelas redes menores citadas sendo uma rede feitas de redes, assim ela conecta essas redes, ligando computadores em todos os lugares do mundo.

## Transmissão de dados

Todos os dados transmitidos para as redes são transmitidos em bits, que ao chegar em seu receptor é armazenado dessa maneira, os bits (código binário), só vai ser transformado em algo vísivel para seres humanos quando for necessário, um exemplo é quando recebemos uma mensagem, ela só vai ser interpretada quando abrimos ela, mas até lá, ela só está salva como bits

Cada letra tem um octeteo de bits, cada grupo de 8 bits correspondem a *1 byte*. As letras podem ser salvas pois elas estão em formato ASCII, pela qual faz exatamente essa conversão, de uma letra como vemos para um octeto de bits.

Hoje em dia são utilizados 3 metodos de transmissão dos nossos bits/informações sendo eles

- **Sinais Elétricos**

São transmitidos por um fio de cobre, onde a informação é transformada em energia eletrica que percorre o cabo chegando até o proximo receptor. Normamelte é utilizado em pelifericos, como teclados, mouses, fones, mas pode ligar outros computadores, contudo isso geralmente acontece em pequensa empresas, pois há opções melhores e mais seguras de levar informações por cabos.

- **Sinais Ópticos**

Conhecido igualmente como a fibra óptica, ela transforma os sinais elétricos em pulsos de luz, seu maior forte é sua confiabilidade, estabilidade e transmissão a longas distâncias, sendo a mais utilizada por grandes empresas. 

- **Sinais Sem fio**

O mais comum de se encontar, sendo muito encontrado como o Bluetooth, Wifi e outras conexões, é muito comum encontrar esse tipo de em casas e pequenas empresas.

As empresas ou sites, podem coletar diversos dados de seus clientes, como sua localização histórico e diversas formas, esses metodos de coleta de dados são tratados por 3 catgorias, os dados doados, na qual você está ciente dos dados que está entregando e concorda com sua utilização, dados inferidos, aqueles que são coletados sem perceber, como compras no cartão de crédito, histórico de lugares visitados e outros, por fim os dados observados, eles são dados que podem estar sendo coletados a qualquer momento literalmente te observando como o GPS do seu celular que guar sua lozalização, as recomendações suspeitamente precisas do google e outras.

## Largura de banda larga e taxa de trânsferencia

- **Largura de banda**

A largura de banda é a capacidade de transferencia de dados, medidas por bits, de um ponto ao outro em um determinado tempo, normalmente leva-se por padrão 1 segundo, os bits que estão sendo transferidos, podem se contabilizados em 

- bps = 1 bits p/segundo  
- kbps = 10 ^ 3 bps
- Mbps = 10 ^ 6 bps
- Gbps = 10 ^ 9 bps 
- Tbps = 10 ^ 12 bps

Sendo a cada salto de transmição 1000x maior que o anterior

- **Taxa de transferência**

A taxa de transferência também é a medida de bits em sua tranferenica, contudo nem sempre bate com o mesmo valor da largura de banda pois muitos fatores podem influenciar e atrapalhar na taixa de tranferencia como

- Tipo dos dados enviados
- Quantidade dos dados enviados
- latencia de conexão 

O termo latencia é o atraso que os bits tem para ir de um lugar a outro, incluindo os seus atrasos

Uma coisa que pode enfluenciar muito na velocidade da taixa de transferencia é um conceito que a taxa de transferencia não pode ser mais rápida que o link mais lento do caminho entre o dispositivo emissor e o dispositivo receptor, ou seja basta uma parte do caminho ser um pouco mais lento para causar lentidão no processo inteiro de tranferencia de dados.

Para testar e ver a velocidade, podemos utilizar sites de medição.

Com isso chegamos ao final do modulo 1.
