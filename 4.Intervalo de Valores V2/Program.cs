/*Intervalo de Valores
 
Objetivo: Familiarizar-se com a verificação de intervalos numéricos.
Descrição: Crie um programa que verifique se um número digitado pelo usuário está dentro do intervalo de 1 a 100. Utilize uma condição if para verificar se o número está no intervalo e exiba uma mensagem informando o resultado.
Exemplo de Saida: "O número está entre 1 e 100." ou "O número não está entre 1 e 100."*/
int numero;

while (true)
{
    Console.Write("Digite um número: ");
    if (int.TryParse(Console.ReadLine(), out numero) && numero >= 1 && numero <= 100)
    {
        break;
    }
    else
    {
        Console.WriteLine("Por favor, digite um número entre 1 e 100.");
    }
}

if (numero >= 1 && numero <= 100)
{
    Console.WriteLine($"O número {numero} está entre 1 e 100.");
}
else
{
    Console.WriteLine($"O número {numero} não está entre 1 e 100.");
}
