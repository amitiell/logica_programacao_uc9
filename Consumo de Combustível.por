programa {
  funcao inicio() {
    const real VALOR = 2.50
    real odo_inicio, odo_final, litros_total, total_passag, media_cons, lucro, total_km

    escreva("\nMarcação Odômetro no inicio do dia \n")
    leia(odo_inicio)

    escreva("Marcação Odômetro no final do dia \n")
    leia(odo_final)

    escreva("Quantos litros de combustivel foi gasto: \n")
    leia(litros_total)

    escreva("Qual valor total recebido: \n")
    leia(total_passag)

    total_km = odo_final-odo_inicio
    media_cons = total_km/litros_total
    lucro = total_passag-(litros_total*2.50)

    escreva("\nA média do consumo foi ",media_cons," km/l e o lucro liquido do dia foi R$",lucro,",00\n")

  }
}
