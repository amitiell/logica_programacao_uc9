programa {
  inclua biblioteca Util --> util
  funcao inicio() {
    cadeia roll
    inteiro numero,aleatorio

    escreva("Digite /roll para número aleatorio: ")
    leia(roll)

    aleatorio = util.sorteia(0,100)

    escreva(aleatorio)

  }
}
