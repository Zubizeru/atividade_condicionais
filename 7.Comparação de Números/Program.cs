/*
Comparação de Números
Objetivo: Praticar a comparação entre variáveis.
Descrição: Escreva um programa que solicita dois números ao usuário e determina qual deles é maior.
Utilize if, else if e else para exibir a mensagem adequada.
Exemplo de Saída: "O primeiro número é maior.", "O segundo número é maior." ou "Os números são iguais."
*/

Console.Write("Digite o primeiro número: ");
int numero1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int numero2 = int.Parse(Console.ReadLine());

if (numero1 > numero2)
{
    Console.WriteLine("O primeiro número é maior.");
}
else if (numero2 > numero1)
{
    Console.WriteLine("O segundo número é maior.");
}
else
{
    Console.WriteLine("Os números são iguais.");
}
