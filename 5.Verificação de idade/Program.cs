/*
Verificação de idade
Objetivo: Aplicar condições para classificar dados.
Descrição: Desenvolva um programa que solicite a idade de uma pessoa e determine se ela é maior de idade (18 anos ou mais) ou menor de idade.
Utilize if e else para mostrar a mensagem apropriada.
Exemplo de Saída: "Você é maior de idade." ou "Você é menor de idade."
*/

Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade.");
}
else
{
    Console.WriteLine("Você é menor de idade.");
}