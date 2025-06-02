programa {
  // Inclui a biblioteca 'Util' e a renomeia para 'util' para facilitar o uso.
  // Esta linha é CRÍTICA para que as funções de aleatoriedade funcionem.
  inclua biblioteca Util --> util

  funcao inicio() {
    inteiro escolhaJogador
    inteiro escolhaComputador
    cadeia nomeEscolhaJogador
    cadeia nomeEscolhaComputador

    escreva("--- Jogo de Pedra, Papel e Tesoura --- \n")
    escreva("Escolha sua opção:\n")
    escreva("1. Pedra\n")
    escreva("2. Papel\n")
    escreva("3. Tesoura\n")
    leia(escolhaJogador)

    // Garante que o jogador escolheu uma opção válida
    enquanto (escolhaJogador < 1 ou escolhaJogador > 3) {
      escreva("Opção inválida. Por favor, escolha 1, 2 ou 3: ")
      leia(escolhaJogador)
    }

    // Mapeia o número para o nome da escolha do jogador
    se (escolhaJogador == 1) {
      nomeEscolhaJogador = "Pedra"
    } senao se (escolhaJogador == 2) {
      nomeEscolhaJogador = "Papel"
    } senao {
      nomeEscolhaJogador = "Tesoura"
    }

    // Gera a escolha do computador (número aleatório entre 1 e 3)
    // Usando util.sorteia(limite_inferior, limite_superior)
    // Para obter 1, 2 ou 3, o limite inferior é 1 e o superior é 3.
    escolhaComputador = util.sorteia(1, 3) // Usando a função sorteia da biblioteca Util

    // Mapeia o número para o nome da escolha do computador
    se (escolhaComputador == 1) {
      nomeEscolhaComputador = "Pedra"
    } senao se (escolhaComputador == 2) {
      nomeEscolhaComputador = "Papel"
    } senao {
      nomeEscolhaComputador = "Tesoura"
    }

    escreva("\n") // Pula uma linha para melhor visualização
    escreva("Você escolheu: ", nomeEscolhaJogador, "\n")
    escreva("O computador escolheu: ", nomeEscolhaComputador, "\n")
    escreva("\n") // Pula uma linha

    // Lógica do jogo
    se (escolhaJogador == escolhaComputador) {
      escreva("EMPATE!\n")
    } senao se (
      (escolhaJogador == 1 e escolhaComputador == 3) ou // Pedra vs Tesoura
      (escolhaJogador == 2 e escolhaComputador == 1) ou // Papel vs Pedra
      (escolhaJogador == 3 e escolhaComputador == 2)    // Tesoura vs Papel
    ) {
      escreva("VOCÊ VENCEU!\n")
    } senao {
      escreva("VOCÊ PERDEU!\n")
    }
  }
}