int tempo;
double distancia;
double velocidadeSom;

velocidadeSom = 340.29;

Console.Clear();

Console.Write("Digite à quantos segundos você ouviu o som do trovão: ");
tempo = Convert.ToInt32(Console.ReadLine());

distancia = ((tempo * velocidadeSom) / 1000 );

Console.WriteLine($"A sua distância do raio é de {distancia:N5} km: ");