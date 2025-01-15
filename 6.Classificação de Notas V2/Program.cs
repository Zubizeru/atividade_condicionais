/*
Classificação de Notas
Objetivo: Aprender a usar múltiplas condições em uma estrutura de decisão.
Descrição: Crie um programa que peça a nota de um aluno e classifique a nota em categorias:
"Excelente" (nota >= 9), "Boa" (7 <= nota < 9),
"Regular" (5 <= nota < 7) e "Baixa" (nota < 5).
Exiba a classificação na tela.
Exemplo de Saída: "Excelente", "Boa", "Regular", "Baixa"
*/
double nota;
while (true)
{
    Console.Write("Digite a nota do aluno: ");
    if (double.TryParse(Console.ReadLine(), out nota)) {
        if (nota >= 0 && nota <= 10)
        {
            break;
        }
        else
        {
            Console.WriteLine("Por favor, digite uma nota entre 0 e 10.");
        }
    } else {
        Console.WriteLine("Por favor, digite uma nota válida");
    }
}
if (nota >= 9)
{
    Console.WriteLine("Excelente");
}
else if (nota >= 7)
{
    Console.WriteLine("Boa");
}
else if (nota >= 5)
{
    Console.WriteLine("Regular");
}
else
{
    Console.WriteLine("Baixa");
}
