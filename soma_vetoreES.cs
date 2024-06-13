
 int n;

Console.Write("Quantos valores terão em cada um dos vetores: ");
n = int.Parse(Console.ReadLine());

int[] vetorA = new int[n];
int[] vetorB = new int[n];
int[] vetorC = new int[n];

Console.WriteLine("Digite os valores do vetor A:");
for (int i = 0; i < n; i++){
vetorA[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Digite os valores do vetor B:");
for (int i = 0; i < n; i++){
vetorB[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < n; i++){
vetorC[i] = vetorA[i] + vetorB[i];
}
Console.WriteLine("Vetor resultante: ");
for (int i = 0; i < n; i++){
Console.WriteLine(vetorC[i]);
}