programa
{
	inclua biblioteca Util --> u
	
	funcao inicio()
	{
		
		const inteiro COL = 8
		const inteiro LIN = 7

		
		inteiro matriz[LIN][COL] 

		para (inteiro linha = 0; linha < LIN; linha++)
		{
			para (inteiro coluna = 0; coluna < COL; coluna++)
			{
				matriz[linha][coluna] = linha + coluna 
				
				escreva("[ ", matriz[linha ][coluna ], " ]") 
			}
			
			escreva ("\n")
		}
	}
}

