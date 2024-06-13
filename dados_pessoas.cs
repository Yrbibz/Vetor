
int n;

Console.WriteLine("Quantas pessoas serão digitadas?: ");
n = int.Parse(Console.ReadLine());
 
double[] alt = new double[n];
char[] sexo = new char[n];

for (int i = 0; i < n; i++)
{
  Console.WriteLine("Altura da " + (i + 1) + "ª pessoa:");
  alt[i] = double.Parse(Console.ReadLine());
  Console.Write("Gênero da " + (i + 1) + "ª  pessoa: ");
  sexo[i] = char.Parse(Console.ReadLine().ToUpper());
}

double maioralt= alt[0];
double menoralt = alt[0];
double mulheres = 0;
int qmulheres = 0;
int qhomens = 0;

for (int i = 0; i < n; i++){
  if (alt[i] > maioralt){
  maioralt = alt[i];
 }if (alt[i] < menoralt){
  menoralt = alt[i];
 }if (sexo[i] == 'F'){
  mulheres += alt[i];
  qmulheres++;
 }else if (sexo[i] == 'M'){
  qhomens++;
    }
}

 Console.WriteLine("Maior altura: " + maioralt + " cm");
 Console.WriteLine("Menor altura: " + menoralt + " cm");
if (qmulheres>0){
 Console.WriteLine("Média de altura das mulheres: " + mulheres + " cm");
}else{
 Console.WriteLine("Nenhuma mulher no grupo para calcular a média de altura.");
}Console.WriteLine("Número de homens: " + qhomens);    