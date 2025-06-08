programa {
  funcao inicio() {
    cadeia produto_1, produto_2, produto_3
    real kg_produto_1, kg_produto_2, kg_produto_3, total_1, total_2, total_3, total_tara_1, total_tara_2, total_tara_3
    inteiro caixas_produto_1, caixas_produto_2, caixas_produto_3

    const real TARA_CAIXA = 2.0
    const real TARA_PALETE = 17.5

    escreva("\nQual o primeiro produto: \n")
    leia(produto_1)

    escreva("Quantos KGs no total: \n")
    leia(kg_produto_1)

    escreva("Quantas caixas foram utilizadas: ")
    leia(caixas_produto_1)
    
    escreva("\nQual o segundo produto: \n")
    leia(produto_2)

    escreva("Quantos KGs no total: \n")
    leia(kg_produto_2)

    escreva("Quantas caixas foram utilizadas: ")
    leia(caixas_produto_2)
    
    escreva("\nQual o terceiro produto: \n")
    leia(produto_3)

    escreva("Quantos KGs no total: \n")
    leia(kg_produto_3)

    escreva("Quantas caixas foram utilizadas: ")
    leia(caixas_produto_3)
    

    limpa()

    total_1 = kg_produto_1 - ((caixas_produto_1 * TARA_CAIXA) + TARA_PALETE) 
    
    total_2 = kg_produto_2 - ((caixas_produto_2 * TARA_CAIXA) + TARA_PALETE)
    
    total_3 = kg_produto_3 - ((caixas_produto_3 * TARA_CAIXA) + TARA_PALETE)

    total_tara_1 = (caixas_produto_1 * TARA_CAIXA) + TARA_PALETE
    
    total_tara_2 = (caixas_produto_2 * TARA_CAIXA) + TARA_PALETE
    
    total_tara_3 = (caixas_produto_3 * TARA_CAIXA) + TARA_PALETE

    escreva("\n---------------------------------------------------------\n")
    escreva("                     NOTA DE ENTRADA                     \n")
    escreva("---------------------------------------------------------\n")
    escreva(produto_1,"\n")
    escreva("TOTAL BRUTO: ",kg_produto_1,"Kg\n")
    escreva("TOTAL TARA: ",total_tara_1,"kg\n")
    escreva("TOTAL LIQUIDO: ",total_1,"kg\n")
    escreva("---------------------------------------------------------\n")
    
    escreva(produto_2,"\n")
    escreva("TOTAL BRUTO: ",kg_produto_2,"Kg\n")
    escreva("TOTAL TARA: ",total_tara_2,"kg\n")
    escreva("TOTAL LIQUIDO: ",total_2,"kg\n")
    escreva("---------------------------------------------------------\n")
    
    escreva(produto_3,"\n")
    escreva("TOTAL BRUTO: ",kg_produto_3,"Kg\n")
    escreva("TOTAL TARA: ",total_tara_3,"kg\n")
    escreva("TOTAL LIQUIDO: ",total_3,"kg\n")
    escreva("---------------------------------------------------------\n")


  }
}
