programa {
  funcao inicio() {
    const real CONSUMO = 50
    real kg, dias, gramas

    escreva("\nQuantos kgs de alimento será: \n")
    leia(kg)

    gramas = 1000/kg

    dias = gramas/CONSUMO

    escreva("\nO Alimento ira durar ",dias,"dias.\n")

  }
}
