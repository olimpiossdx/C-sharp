using System;
/*
Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme

Exemplo:

Entrada:
8
1
7
2
2
4

Saída:
MUITO OBRIGADO
Alcool: 1
Gasolina: 2
Diesel: 0

*/
namespace combustivel {
  class Program {
    static void Main (string[] args) {
      short alcool, gasolina, diesel;
      gasolina = alcool = diesel = 0;
      string opacao = Console.ReadLine ();
      while (!opacao.Equals ("4")) {

        if (opacao.Equals ("1")) alcool += 1;
        else if (opacao.Equals ("2")) gasolina += 1;
        else if (opacao.Equals ("3")) diesel += 1;
        opacao = Console.ReadLine ();
      }
      Console.WriteLine ($"MUITO OBRIGADO\nAlcool: {alcool}\nGasolina: {gasolina}\nDiesel: {diesel}");
    }
  }
}