programa {
  funcao inicio() {

    inteiro numero, a, resultado, primo = 1

    escreva("Escreva o número para descobrir se ele é primo ou não:")
    leia(numero)

    para(a = 2; a < numero; a++){

      resultado = numero % a

      se(resultado == 0){
        primo = 0
      }
}
       se(primo == 1){
        escreva("Número primo\n")
       }
       senao{
        escreva("Número não primo\n")
       }
       
 }
}

