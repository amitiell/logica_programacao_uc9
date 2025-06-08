programa {
  funcao inicio() {
    inteiro quantidade_alunos,divisao,resto,turma_a,turma_b,turma_c

    escreva("\nQual a quantidade de alunos da escola: \n")
    leia(quantidade_alunos)

    divisao = quantidade_alunos/3
    resto = divisao % 3

    turma_a = divisao
    turma_b = divisao
    turma_c = divisao

    se(resto != 0){
      turma_a = turma_a + resto
    }

    escreva("\nTurma A: \n",turma_a)
    escreva("\nTurma B: \n",turma_b)
    escreva("\nTurma C: \n",turma_c)
    
  }
}
