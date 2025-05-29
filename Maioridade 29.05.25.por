programa {
  funcao inicio() {
    
    const inteiro MATURIDADE = 18

    inteiro idade, anos

    escreva("Digite sua idade: ")
    leia(idade)

    anos = MATURIDADE - idade

    se (anos > 0){
      escreva("\nFalta(m) ", anos, " ano(s) para você atingir a maioridade\n")
    }
    senao{
      escreva("Você já atingiu a maioridade\n")
    }
  }
}
