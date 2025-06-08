programa {
  funcao inicio() {
    inteiro ano_nasc, ano_atual, mes_nasc, mes_atual, dia_nasc, dia_atual, idade, dia

    escreva("\nQual ano você nasceu: \n")
    leia(ano_nasc)

    escreva("Qual ano atual: \n")
    leia(ano_atual)

    escreva("Qual mês de nascimento: \n")
    leia(mes_nasc)

    escreva("Qual mês atual: \n")
    leia(mes_atual)

    idade = ano_atual - ano_nasc

    se (mes_atual<mes_nasc){
      idade = idade-1
      escreva("sua idade é: ",idade,"\n")
    }    
    senao se(mes_atual>mes_nasc){
      escreva("Sua idade é ",idade,"\n")
    }
    senao se(mes_atual==mes_nasc){
      escreva("dia nascimento: ")
      leia(dia_nasc)

      escreva("dia atual: ")
      leia(dia_atual)

    }

    se(dia_atual<dia_nasc){
      idade = idade-1
      escreva("Sua idade é ",idade, "\n")
    }
    senao se(dia_atual>=dia_nasc){
      escreva("sua idade é: ",idade)
    }



  }
}
