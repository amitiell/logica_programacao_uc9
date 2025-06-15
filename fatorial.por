programa {

  funcao inicio() {

    inteiro numero, a, resultado, fatorial = 1

  
      escreva("Digite um número para saber o fatorial:")
      leia(numero)

      para(a = 2 ; a <= numero; a++){

          fatorial = fatorial * a 
        }
    
     escreva("o fatorial do ", numero," é " ,fatorial, "\n")
     


    
  }
}
