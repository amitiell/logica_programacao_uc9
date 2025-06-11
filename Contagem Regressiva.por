programa {
  inclua biblioteca Util

  funcao inicio() {
    inteiro contador = 0
    
    enquanto(contador < 10 ){
      limpa()
      escreva("Detonação em: ", contador)

      contador = contador + 1
      Util.aguarde(1000)

    }
    limpa()
    escreva("Boooom\n")
  }
}
