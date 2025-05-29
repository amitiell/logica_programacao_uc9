// " % " mode calcula o resto da divisão

programa {
  funcao inicio() {

  inteiro resto, valor

  escreva("Digite um valor: ")
  leia(valor)

  resto = valor % 2

  se (resto == 0){
    escreva("\nO número é par\n")
  }
  senao
  {
    escreva("\nO número é impar\n")
  }

  }
}
