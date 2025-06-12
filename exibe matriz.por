programa {
  inclua biblioteca Util --> u

  funcao inicio() 
  {
    const inteiro TAMANHO = 10

    inteiro matriz[TAMANHO][TAMANHO]

    para (inteiro linha = 0; linha < TAMANHO; linha++)
    {
      para(inteiro coluna = 0; coluna < TAMANHO; coluna++)
      {
        matriz[linha][coluna] = u.sorteia(1, 9)

        escreva("[", matriz[linha][coluna], "]")

      }
      escreva("\n")
    }
  }
}
