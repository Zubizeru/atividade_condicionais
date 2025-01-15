/*
Cálculo do Desconto
Objetivo: Aplicar condições para cálculos.
Descrição: Escreva um programa que peça o valor de uma compra e verifique se o valor é maior que 100.
Se sim, aplique um desconto de 10% no valor e mostre o valor final. Caso contrário, exiba o valor original.
Exemplo de Saída: "Valor com desconto: [valor final]" ou "Valor original: [valor]"
*/

Console.Write("Digite o valor da compra: ");
double valorCompra = double.Parse(Console.ReadLine());

if (valorCompra > 100)
{
    double valorComDesconto = valorCompra * 0.90; // Aplica 10% de desconto
    Console.WriteLine($"Valor com desconto: {valorComDesconto}");
}
else
{
    Console.WriteLine($"Valor original: {valorCompra}");
}