programa {
  funcao inicio() {
    real turma_c, turma_d,rep_c, aprov_d, aprov_c, rep_d, percen_c, percen_d, perc_total,soma_turma,perc_final

    escreva("\nQuantos alunos tem na turma C: \n")
    leia(turma_c)

    escreva("Quantos alunos tem na turma D: \n")
    leia(turma_d)

    escreva("Qual a porcentagem de alunos reprovados na Turma C: ")
    leia(rep_c)

    escreva("Qual a porcentagem de alunos reprovados na Turma D: ")
    leia(rep_d)

    percen_c = turma_c-(rep_c/100)*turma_c
    percen_d = turma_d-(rep_d/100)*turma_d

    escreva("\nA quantidade de alunos reprovados na turma C é ",turma_c-percen_c,"\n")
    escreva("\nA quantidade de alunos reprovados na turma D é ",turma_d-percen_d,"\n")

    soma_turma = turma_c+turma_d
    perc_total = (turma_c-percen_c)+(turma_d-percen_d)
    perc_final = (perc_total/soma_turma)*100

    escreva("\nA percentgem de alunos reprovados em relação ao total de alunos é ",perc_final,"\n")

  }
}
