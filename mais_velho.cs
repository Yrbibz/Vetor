
int n;

Console.Write("Quantas pessoas serão digitadas: ");
n = int.Parse(Console.ReadLine());

string[] nomes = new string [n];
int[] idades = new int[n];

for (int i = 0; i < n; i++) {
 Console.WriteLine($"\nDados da {i + 1}ª pessoa:");
 Console.Write("Nome: ");
 nomes[i] = Console.ReadLine();
 Console.Write("Idade: ");
 idades[i] = int.Parse(Console.ReadLine());
}
int oveio = 0;
for (int i=1; i<n; i++){
 if (idades[i] > idades[oveio]){  
        oveio = i;
 }
}
Console.WriteLine("A pessoa mais velha é " + nomes[oveio]);
    