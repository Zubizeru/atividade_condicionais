/*
Verificação de idade
Objetivo: Aplicar condições para classificar dados.
Descrição: Desenvolva um programa que solicite a idade de uma pessoa e determine se ela é maior de idade (18 anos ou mais) ou menor de idade.
Utilize if e else para mostrar a mensagem apropriada.
Exemplo de Saída: "Você é maior de idade." ou "Você é menor de idade."
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
        }
        else
        {
            Console.WriteLine("Informe uma idade entre 1 e 129");
        }
    }
    else
    {
        Console.WriteLine("Informe uma idade válida.");
    }
    
}
if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade.");
}
else
{
    Console.WriteLine("Você é menor de idade.");
}