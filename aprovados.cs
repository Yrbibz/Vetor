 int n;

 Console.Write("Quantos alunos serão digitados: ");
 n = int.Parse(Console.ReadLine());

 string[] nomes = new string[n];
 double[] nota1 = new double[n];
 double[] nota2 = new double[n];

for (int i = 0; i < n; i++){
Console.WriteLine("Digite nome, primeira e segunda nota do " + (i + 1) + "º aluno:");
nomes[i] = Console.ReadLine();
nota1[i] = double.Parse(Console.ReadLine());
nota2[i] = double.Parse(Console.ReadLine());
}

Console.WriteLine("\nAlunos aprovados:");
for (int i = 0; i < n; i++){
double media = (nota1[i] + nota2[i]) / 2.0;
if (media >= 6.0){
Console.WriteLine(nomes[i]);
}
}
    

