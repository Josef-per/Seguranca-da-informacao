//
// Pegar as informações
Console.Write("Digite uma distância em metros: ");
float n = float.Parse(Console.ReadLine());

// tratamento das informações
float km = n / 1000;
float hm = n / 100;
float dam = n / 10;
float dc = n * 10;
float c = n * 100;
float mm = n * 1000;

//tinha como fazer direto quando exibir, mas optei fazer pelas variaveis, pq não tem sentido o exrecicio pedir todas as conversões se não for usar, assim eu descidi fazer dessa forma
// Exibição

Console.WriteLine($" {km}km \n {hm}hm \n {dam}dam \n {dc}dc \n {c}c \n {mm}mm");
