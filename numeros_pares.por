programa {
  funcao inicio() {
inteiro n, par, num

par=0

 escreva("Quantos n�meros voc� vai digitar? : ")  
    leia(n)
inteiro nu [n], ospar [n]

   para (real i = 0; i ==0 ou i<n; i++) { 
   
   escreva("Digite um n�mero: ")  
    leia(num)
   
   se (num % 2 == 0) { 
       ospar[par] = num
        par = par + 1
      }
    
    senao 
  par=par+0

   }

   escreva ("N�meros pares: ")
   para (inteiro i = 0; i < par; i++) {
        escreva("\n", ospar[i])
   }
   escreva("\nQuantidade de pares = ", par)
  }
}
