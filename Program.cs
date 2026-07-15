// estruturas de repetição - exercícios

// 1 - calcule e exiba a tabuada do 2, do 0 até o 20 - while
// int i = 0;
// int result = 0;
// while (i < 21)
// {
//     result = 2 * i;
//     Console.WriteLine($"2 x {i} = {result}");
//     i ++;
// }


// 2 - validador de entrada de dados: enquanto o usuário não digitar um número de 1 à 10, pede de novo - while
// int num = 0;
// Console.WriteLine("Informe um número entre 1 e 10: ");
// num = Convert.ToInt32(Console.ReadLine());

// while (num < 1 || num > 10)
// {   
//     Console.WriteLine("Número inválido! Digite um número entre 1 e 10: ");
//     num = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"O número digitado foi {num}!");

// // 3 - validação completa de input- while
// Console.WriteLine("Digite um número");
// bool ehN = int.TryParse(Console.ReadLine(), out int n);

// while (!ehN)
// {
//     Console.WriteLine("Valor inválido!");
//     ehN = int.TryParse(Console.ReadLine(), out n);
// }

// Console.WriteLine($"O número digitado foi {n}!");

// 4 - fatorial com "for"
Console.WriteLine("Informe um número inteiro para ver seu fatorial: ");
int numero = Convert.ToInt32(Console.ReadLine());

int fatorial = numero;
for (int i = 1; i < numero; i++)
{
    fatorial *= i;  
}
Console.WriteLine($"O resultado de {numero}! é igual a {fatorial}");



// 4 - fatorial com "do while"
// Console.WriteLine("Informe um número inteiro para ver seu fatorial: ");
// int numero = Convert.ToInt32(Console.ReadLine());

// int fatorial = numero;
// int i = 1;
// do 
// {
//     fatorial *= i;  
//     i ++;
// } while (i < numero);
// Console.WriteLine($"O resultado de {numero}! é igual a {fatorial}");


// 4 - fatorial com "while"
// Console.WriteLine("Informe um número inteiro para ver seu fatorial: ");
// int numero = Convert.ToInt32(Console.ReadLine());

// int fatorial = numero;
// int i = 1;
// while (i < numero) 
// {
//     fatorial *= i;  
//     i++;
// }
// Console.WriteLine($"O resultado de {numero}! é igual a {fatorial}");

