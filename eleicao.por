
// Inicia o programa
programa
{
// Chama a função inicio
	funcao inicio()
	{
// Declaração de variavel Candidatos
		inteiro candidato_a = 0, candidato_b = 0
// Declaração de variavel Votos
		inteiro brancos = 0, nulos = 0, total_votos = 0
// Declaração de variavel porcentagens para candidatos
		real porcentagem_candidato_a, porcentagem_candidato_b
// Declaração de variavel porcentagens votos (brancos e nulos)
		real porcentagem_brancos, porcentagem_nulos
// Declaração variavel total de votos 
		inteiro voto
// Laço de repetição (faça/enquanto) primeiro le e depois execulta
		faca
		{
// Limpa a tela
			limpa()
// Pede intensão de voto
			escreva("Escolha seu candidato ou tecle zero para encerrar\n\n")
// Escreve numero que o usuario poderá escolher
			escreva("  1 -> Candidato A\n")
			escreva("  2 -> Candidato B\n")
			escreva("  3 -> Branco\n")
// Explica a dinamica do voto
			escreva("\nQualquer número diferente de 0, 1, 2 e 3 anulará o seu voto\n")
// Escolha do voto
			escreva("Digite seu voto: ")
// Faz a leitura do voto e armazena na Variavel (voto)
			leia(voto)
// Limpa a tela
			limpa()
// inicia o laço de repetição de escolha
			escolha (voto)
			{
// Caso escolha 0, o programa se encerra
				caso 0:
					escreva ("Votação encerrada!\n")
				pare
// Caso escolha 1, acrescenta 1 voto ao candidato A
				caso 1: 
			 		candidato_a = candidato_a + 1 
			 	pare
// Caso escolha 2, acrescenta 1 voto ao candidato B
			 	caso 2: 
			 		candidato_b = candidato_b + 1 
			 	pare
// Caso escolha 3, acrescenta 1 voto ao Branco
			 	caso 3: 
			 		brancos = brancos + 1 
			 	pare
// Acrescenta 1 voto ao nulo, caso nenhuma opção assima seja a escolha
			 	caso contrario:
			 		nulos = nulos + 1 
			}			 
		
		}
// Final do laçço de repetição (loop), o programa irá rodar até que o valor "0", seja escolhido
		enquanto(voto != 0)
// Faz a soma do total de votos 
		total_votos = candidato_a + candidato_b + brancos + nulos
// Estrutura de decisão
		se (total_votos > 0)
		{
// Calcula a porcentagem de votos de cada candidato, brancos e nulos
			porcentagem_candidato_a = (candidato_a * 100.0) / total_votos  
			porcentagem_candidato_b = (candidato_b * 100.0) / total_votos
			porcentagem_brancos = (brancos * 100.0) / total_votos
			porcentagem_nulos = (nulos * 100.0) / total_votos
// Pula uma linha
			escreva("\n")
// Mostra o resultado do total de votos
			escreva("Total de votos: ", total_votos, "\n\n")
// Mostra o total de votos e porcentagem do candidato A 
			escreva("Candidato A: " , candidato_a, " voto(s). ", porcentagem_candidato_a, " % do total\n" )
// Mostra o total de votos e porcentagem do candidato B
			escreva("Candidato B: ", candidato_b, " voto(s). ", porcentagem_candidato_b, " % do total\n" )
// Mostra o total de votos e porcentagem de votos Brancos
			escreva("Brancos: ", brancos, " voto(s). ", porcentagem_brancos, " % do total\n")
// Mostra o total de votos e porcentagem de votos Nulos
			escreva("Nulos: ", nulos, " voto(s). ", porcentagem_nulos, " % do total\n")
		}
	}
}

