programa
{
  inclua biblioteca Util --> u

  funcao inicio()
  {
    const inteiro LINHAS = 5

    inteiro matriz[LINHAS][6]

    para(inteiro linha = 0; linha < LINHAS; linha++)
    {
      para(inteiro coluna = 0; coluna <6; coluna++)
      {
        matriz[linha][coluna] = u.sorteia(1, 60)

        escreva("[",matriz[linha][coluna], "]")
      }
      escreva("\n")
    }
  }
}