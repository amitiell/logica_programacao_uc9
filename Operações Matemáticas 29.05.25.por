programa{
  funcao inicio()
  {
    real a, b, soma, sub, div, mult

    escreva("Digite o primeiro número: ")
    leia(a)

    escreva("Digite o segundo número: ")
    leia(b)

    soma = a+b //soma os dois números
    sub = a-b //subtrai os dois números
    div = a/b //divide os dois números
    mult = a*b //multiplica os dois números

    escreva("\nA soma dos números é igual a: ",soma)
    escreva("\nA subtração dos números é igual a: ",sub)
    escreva("\nA divisão dos números é igual a: ",div)
    escreva("\nA multiplicação dos números é igual a: ",mult,"\n")
  }
}