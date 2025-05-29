programa {
  funcao inicio() {
    
    inteiro a, b, aux

    escreva("Informe um valor para a variável A: ")
    leia(a)

    escreva("Informe um valor para a variável B: ")
    leia(b)

    escreva("\nVariáveis antes da troca: \n")
    escreva("A = ",a ,"; B = ", b, "\n")

    
    aux = a 
    a = b 
    b = aux

    escreva("\nVariáveis após a troca: \n")
    escreva("A = ", a,"; B = ", b, "\n")

  }
}
