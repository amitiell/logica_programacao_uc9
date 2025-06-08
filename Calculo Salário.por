programa {
  funcao inicio() {
    real horas_trabalhadas, ganho_hora, salario, dias_trabalhados

    escreva("\nQuantos o funcionario ganha por hora: \n") 
    leia(ganho_hora)

    escreva("Quantas horas ele trabalhou: ")
    leia(horas_trabalhadas)

    escreva("\nQuantos dias ele trabalhou no mês: ")
    leia(dias_trabalhados)

    salario = (ganho_hora*horas_trabalhadas)*dias_trabalhados

    escreva("\nO salario do funcionario no final do mês será de ",salario,"\n")

  }
}
