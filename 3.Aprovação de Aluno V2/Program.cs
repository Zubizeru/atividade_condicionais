/*Aprovação de Aluno
 
Objetivo: Compreender a aplicação de condições para tomada de decisão.
• Descrição: Escreva um programa que pergunte a nota de um aluno. Se a nota for maior ou igual a 6, o aluno é considerado 'Aprovado". Caso contrário, ele é "Reprovado". Exiba a situação do aluno na tela.
Exemplo de Saída: "Aluno aprovado." ou "Al reprovado."*/

double nota;

while (true)
{
    Console.Write("Digite a nota do aluno: ");
    if (double.TryParse(Console.ReadLine(), out nota))
    {
        if (nota < 0 ||  nota > 10)
        {
            Console.WriteLine("Por favor digite uma nota entre 0 e 10.");
        } else
        {
            break;
        }
    }
    else
    {
        Console.WriteLine("Por favor, digite uma nota válida.");
    }
}

if (nota >= 6)
{
    Console.WriteLine($"Aluno aprovado com nota {nota}.");
}
else
{
    Console.WriteLine($"Aluno reprovado com nota {nota}.");
}
