programa {
  funcao inicio() {
inteiro n
real tudo

tudo=0

 escreva("Digite quantas vezes vai digitar: ")  
    leia(n)
inteiro num [n]

   para (real i = 0; i ==0 ou i<n; i++) { 
   escreva("Digite um número: ")  
    leia(num[i])
    tudo=tudo+num[i]
   }

   escreva("Valores =")
    para (real i = 0; i < n ou i==0; i++)
        {
            escreva("  ", num[i])
        }

escreva("\nSoma = ", tudo)
escreva("\nMédia = ", tudo/n)



  }
}


