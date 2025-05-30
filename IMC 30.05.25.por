programa {
  inclua biblioteca Matematica --> mat

  funcao inicio() {
    
    real altura, peso, resultado

    escreva("\nQual sua altura: ")
    leia(altura)

    escreva("\nQual seu peso: ")
    leia(peso)

    resultado = peso / (altura * altura)
    resultado = mat.arredondar(resultado,1)

    escreva("\nO resultado do IMC é: ", resultado, "\n")

    se(resultado <= 18.5){
      escreva("\nAbaixo do peso")
    }  
    senao se(resultado <= 24.9){
        escreva("\nPeso normal")
      }
    senao se(resultado <= 29.9){
          escreva("\nSobrepeso")
        }
    senao{
          escreva("\nObesidade")
        }
    
  }
}
