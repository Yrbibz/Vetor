programa {
  funcao inicio() {

     inteiro n, idade, qnmenor, cidadao
    real alt, malt, menor
    cadeia nome
    

    malt = 0
    menor = 0
    cidadao = 0

    escreva("Quantas pessoas serão digitadas: ")  
    leia(n)

    cadeia nomemeno[n] 

    para (inteiro i = 0; i < n; i++) { 
      escreva("\nDados da ", (i + 1), "ª pessoa:") 
      escreva("\nNome: ")  
      leia(nome)
      escreva("Idade: ")  
      leia(idade)
      se (idade < 16) { 
       
        nomemeno[cidadao] = nome
        cidadao = cidadao + 1
        menor = menor + 1
      }

    escreva("Altura: ")  
    leia(alt)
    malt=malt+alt
   }

   qnmenor = (menor * 100.0) / n

   escreva("\nAltura média: ", malt/n)
   escreva("\nPessoas com menos de 16 anos: ", qnmenor, "%")
     para (inteiro i = 0; i < cidadao; i++) {
        escreva("\n", nomemeno[i])}



  }
}
