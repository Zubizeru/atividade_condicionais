/*
Dia da Semana (usando if-else)
Objetivo: Praticar a utilização de múltiplas condições com if, else if e else.
Descrição: Desenvolva um programa que peça um número de 1 a 7 e exiba o dia da semana correspondente (1 para "Domingo", 2 para "Segunda-feira", etc.).
Se o número estiver fora desse intervalo, exiba uma mensagem de erro.
Exemplo de Saída: "Domingo", "Segunda-feira", etc., ou "Número inválido. Digite um número de 1 a 7."
*/

Console.Write("Digite um número de 1 a 7: ");
int numero = int.Parse(Console.ReadLine());

if (numero == 1)
{
    Console.WriteLine("Domingo");
}
else if (numero == 2)
{
    Console.WriteLine("Segunda-feira");
}
else if (numero == 3)
{
    Console.WriteLine("Terça-feira");
}
else if (numero == 4)
{
    Console.WriteLine("Quarta-feira");
}
else if (numero == 5)
{
    Console.WriteLine("Quinta-feira");
}
else if (numero == 6)
{
    Console.WriteLine("Sexta-feira");
}
else if (numero == 7)
{
    Console.WriteLine("Sábado");
}
else
{
    Console.WriteLine("Número inválido. Digite um número de 1 a 7.");
}
