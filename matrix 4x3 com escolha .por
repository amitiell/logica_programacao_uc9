programa
{
	inclua biblioteca Util --> u
	
	funcao inicio()
	{
		
		const inteiro COL = 4
		const inteiro LIN = 3

		
		inteiro matriz[LIN][COL] 
    inteiro l, c

		para (inteiro linha = 0; linha < LIN; linha++)
		{
			para (inteiro coluna = 0; coluna < COL; coluna++)
			{
				escreva("Digite o valor da linha ",linha," e da coluna ",coluna," : ")
        leia(matriz[linha][coluna])
				 
			}
      
		}
    para (inteiro linha = 0; linha < LIN; linha++)
		{
			para (inteiro coluna = 0; coluna < COL; coluna++)
			{	 
        escreva("[",matriz[linha][coluna],"]")
			}
      escreva("\n")
		}
      escreva("Qual linha: \n")
      leia(l)
      escreva("Qual coluna: \n")
      leia(c)

    escreva("[",matriz[l-1][c-1],"]")

	}
}

