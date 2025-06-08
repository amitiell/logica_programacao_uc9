programa {
  funcao inicio() {
    inteiro numero, unidade, dezena, centena, milhar

    escreva("\nDiga o número a ser decomposto: \n")
    leia(numero)

    milhar = (numero/1000) % 10
    centena = (numero/100) % 10
    dezena = (numero/10) % 10
    unidade = numero % 10
    
    escreva("\nMilhar: ",milhar)
    escreva("\nMilhar: ",centena)
    escreva("\nMilhar: ",dezena)
    escreva("\nMilhar: ",unidade)
  }
}
