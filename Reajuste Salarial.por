programa {
  funcao inicio() {
    real salario, salario_novo

    const real PORCENTAGEM = 15

    escreva("\nQual o salario do funcionario: \n")
    leia(salario)

    salario_novo = salario*(PORCENTAGEM/100)+salario

    escreva("\nO novo salário será de R$",salario_novo,"\n")

  }
}
