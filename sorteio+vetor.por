programa {
  inclua biblioteca Util --> util
  funcao inicio() {
    inteiro vetor[15]

    para (inteiro posicao = 0; posicao < 15; posicao++)
    {
      vetor [posicao] = util.sorteia(1, 100) 
    }
    escreva("Vetor na ordem original:\n")

    para(inteiro posicao = 0; posicao < 15; posicao++)
    {
      escreva(vetor[posicao]," ")
    }

    escreva("\n\nVetor na ordem inversa:\n")

    para(inteiro posicao = 14; posicao >=0; posicao--)
    {
      escreva(vetor[posicao]," ")
    }
  }
}
