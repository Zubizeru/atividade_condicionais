/*Número Positivo ou Negativo
 
Objetivo: Aprender a trabalhar com condições múltiplas.
Descrição: Desenvolva um programa que solicita ao usuário um número. O programa deve determinar se o número é positivo, negativo ou zero, utilizando if, else if, e else para as três possibilidades. Exiba a mensagem correspondente.
Exemplo de Salda: "O número é positivo.", "O número é negativo." ou "O número é zero.*/

Console.Write("Digite um número: ");
double numero = double.Parse(Console.ReadLine());

if (numero > 0)
{
    Console.WriteLine("O número é positivo.");
}
else if (numero < 0)
{
    Console.WriteLine("O número é negativo.");
}
else
{
    Console.WriteLine("O número é zero.");
}