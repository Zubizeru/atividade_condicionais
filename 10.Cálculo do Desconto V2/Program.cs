/*
Cálculo do Desconto
Objetivo: Aplicar condições para cálculos.
Descrição: Escreva um programa que peça o valor de uma compra e verifique se o valor é maior que 100.
Se sim, aplique um desconto de 10% no valor e mostre o valor final. Caso contrário, exiba o valor original.
Exemplo de Saída: "Valor com desconto: [valor final]" ou "Valor original: [valor]"
*/

int valorCompra;

while (true)
{
    Console.Write("Digite o valor da compra: ");
    if (int.TryParse(Console.ReadLine(), out valorCompra))
    {
        break;
    }
    else
    {
        Console.WriteLine("Entrada inválida. Por favor, digite um preço válido.");
    }
}  

        if (valorCompra > 100)
{
    double valorComDesconto = valorCompra * 0.90;
    Console.WriteLine($"Valor com desconto: {valorComDesconto}");
}
else
{
    Console.WriteLine($"Valor original: {valorCompra}");
}
