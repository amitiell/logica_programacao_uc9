programa {
    funcao inicio() {
        const real ACRESCIMO = 50.0 / 100.0  // 50%
        const real COMISSAO = 15.0 / 100.0  // 15%
        
        real custo, empregados, salario_min, quantidade_bicicleta
        real valor_venda, lucro_liq, comissao_total, comissao_por_func, salario_final

        escreva("Número de empregados: ")
        leia(empregados)

        escreva("Qual o valor do Salário-mínimo: ")
        leia(salario_min)

        escreva("Qual preço de custo de cada bicicleta: ")
        leia(custo)

        escreva("Número de bicicletas vendidas: ")
        leia(quantidade_bicicleta)

        valor_venda = custo * (1 + ACRESCIMO)

        comissao_total = (custo * COMISSAO) * quantidade_bicicleta

        comissao_por_func = comissao_total / empregados

        salario_final = (2 * salario_min) + comissao_por_func

        lucro_liq = (valor_venda - custo) * quantidade_bicicleta - comissao_total

        escreva("\n--- Resultados ---\n")
        escreva("Salário final de cada empregado: R$ ", salario_final, "\n")
        escreva("Lucro líquido da loja: R$ ", lucro_liq, "\n")
    }
}