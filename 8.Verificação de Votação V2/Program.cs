/*
Verificação de Votação
Objetivo: Compreender a lógica de permissões baseadas em condições.
Descrição: Crie um programa que pergunte a idade de uma pessoa e determine se ela pode votar (idade >= 16).
Utilize uma condição if para exibir a mensagem correspondente.
Exemplo de Saída: "Você pode votar." ou "Você não pode votar."
*/
int idade;

while (true)
{
    Console.Write("Digite sua idade: ");
    if (int.TryParse(Console.ReadLine(), out idade))
    {
        if (idade > 0 && idade < 130)
        {
            break;
        } else
        {
            Console.WriteLine("Por favor, informe uma idade entre 1 e 129.");
        }
    }
    else
    {
        Console.WriteLine("Por favor, digite uma idade válida");
    }

}
if (idade < 16)
{
    Console.WriteLine("Você não pode votar.");
}
else if (idade >= 16 && idade <= 17)
{
    Console.WriteLine("Você pode votar, mas o voto não é obrigatório.");
}
else if (idade >= 18 && idade <= 70)
{
    Console.WriteLine("Você deve votar. O voto é obrigatório.");
}
else
{
    Console.WriteLine("Você pode votar, mas o voto não é obrigatório.");
}
