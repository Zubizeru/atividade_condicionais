/*Verificação de Paridade
 
Objetivo: Praticar o uso do operador (módulo) e estruturas condicionais simples.
Descrição: Crie um programa que peça ao usuário para digitar um número inteiro. O programa deve verificar se o número é par ou impar. Utilize a condição if para determinar o resultado e exiba uma mensagem apropriada.
Exemplo de Saida. "O número é par." ou "O número é impar*/

int numero;

while (true)
{
    Console.Write("Digite um número inteiro: ");

    if (int.TryParse(Console.ReadLine(), out numero))
    {
        break;
    }
    else
    {
        Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
    }
}

if (numero % 2 == 0)
{
    Console.WriteLine("O número é par.");
}
else
{
    Console.WriteLine("O número é ímpar.");
}
