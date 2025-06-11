// Inicia o programa
programa
{
// Chama a função inicio 
	funcao inicio()
	{
// Declara as variaveis
		inteiro x, y, n
// Pede a Altura do triângulo
		escreva("\nInforme a altura do triângulo: ")
// Le e armazena a informação
		leia(n)
// Laço de repetição e adição variavel X
		para(x = 1; x <= n ; x++){
// Laço de repetição e adição variavel Y
			para(y = 1; y <= x; y++){
// Mostra a informação na tela 
				escreva("*")
				}
// Pula a linha
			escreva("\n")
			}
	}
}