programa {
  funcao inicio() {
    real deposito, rendimento

    const real PORCENTAGEM = 5

    escreva("\nQual o valor do depósito: \n")
    leia(deposito)

    rendimento = deposito*(PORCENTAGEM/100)+deposito

    escreva("\nO Valor apos um mês será de R$",rendimento,"\n")
  }
}
