programa
{
    funcao inicio()
    {
 real maior, n, pm


 escreva("Quantos números você vai digitar: ")
  leia(n)

       
 real vetor[n]

     
  para (inteiro i = 0; i < n; i++){
    escreva("Digite o ", i + 1, "º número: ")
    leia(vetor[i])
        }
       
     maior = vetor[0]
     pm = 0

   para (inteiro i = 1; i < n; i++){
     se (vetor[i] > maior)
            {
     maior = vetor[i]
     pm = i+1
            }
        }

        
  escreva("Maior valor: ", maior)
  escreva("\nPosição do maior valor: ", pm)
    }
}

