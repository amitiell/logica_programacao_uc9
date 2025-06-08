programa {
  inclua biblioteca Matematica --> m
  funcao inicio() {
    real milhas, kilometros

    escreva("\nQual a distância em milhas\n")
    leia(milhas)

    kilometros = milhas*0.6214
    kilometros = m.arredondar(kilometros,2)

    escreva("\nA distancia em Kilomtros será ",kilometros, "km/h\n")

  }
}
