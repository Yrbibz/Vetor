programa {
  funcao inicio() {
inteiro n, par, num, mepa

par=0
mepa=0
 escreva("Quantos n�meros voc� vai digitar? : ")  
    leia(n)
inteiro nu [n], ospar [n]

   para (real i = 0; i ==0 ou i<n; i++) { 
   
   escreva("Digite um n�mero: ")  
    leia(num)
   
   se (num % 2 == 0) { 
       ospar[par] = num
        par = par + 1
        mepa=mepa+num
      }
    
    senao 
  par=par+0

   }

  
   se (par!=0)
   escreva("\nM�dia dos pares = ", mepa/par )
   senao 
   escreva("Nenhum n�mero par")
  }
}
