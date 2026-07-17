// estruturas de repetição (e decisão) - exercícios e desafios

// exercício 1 - calcule e exiba a tabuada do 2, do 0 até o 20 - while
// int i = 0;
// int result = 0;
// while (i < 21)
// {
//     result = 2 * i;
//     Console.WriteLine($"2 x {i} = {result}");
//     i ++;
// }



// exercício 2 - validador de entrada de dados: enquanto o usuário não digitar um número de 1 à 10, pede de novo - while
// int num = 0;
// Console.WriteLine("Informe um número entre 1 e 10: ");
// num = Convert.ToInt32(Console.ReadLine());

// while (num < 1 || num > 10)
// {   
//     Console.WriteLine("Número inválido! Digite um número entre 1 e 10: ");
//     num = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"O número digitado foi {num}!");



// exercício 3 - validação completa de input- while
// Console.WriteLine("Digite um número");
// bool ehN = int.TryParse(Console.ReadLine(), out int n);

// while (!ehN)
// {
//     Console.WriteLine("Valor inválido!");
//     ehN = int.TryParse(Console.ReadLine(), out n);
// }

// Console.WriteLine($"O número digitado foi {n}!");



// exercício 4 - fatorial com "for"
// Console.WriteLine("Informe um número inteiro para ver seu fatorial: ");
// int numero = Convert.ToInt32(Console.ReadLine());

// int fatorial = numero;
// for (int i = 1; i < numero; i++)
// {
//     fatorial *= i;  
// }
// Console.WriteLine($"O resultado de {numero}! é igual a {fatorial}");


// exercício 4 - fatorial com "do while"
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


// exercício 4 - fatorial com "while"
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



// desafio 3 
// Console.WriteLine("Informe o login e senha corretamente! Você tem três tentativas!");
// string login = "Taise";
// string senha = "1234";
// string l;
// string s;

// for (int i = 1; i < 4; i++)
// {
//     Console.WriteLine($"Sua {i}ª tentativa: ");
//     Console.WriteLine("Informe o login: ");
//     l = Console.ReadLine();
//     Console.WriteLine("Informe a senha: ");
//     s = Console.ReadLine();
//     if (login == l && senha == s) {
//         Console.WriteLine("Login realizado com sucesso!");
//         break;
//     } else
//     {
//         if (i == 3)
//         {
//             Console.WriteLine("Acesso bloqueado!");
//         }
//     }
// }



//  desafio 4
// Console.WriteLine("=-=-= Bem-vindo ao simulado de caixa eletrônico =-=-=");

// Console.WriteLine("Informe seu saldo atual: ");
// double saldo = Convert.ToDouble(Console.ReadLine());

// int opc = 0;

// while (opc != 4) {
//     Console.WriteLine("1 - Depositar | 2 - Sacar | 3 - Ver saldo | 4 - Sair");
//     Console.WriteLine("Informe sua opção (1, 2, 3 ou 4): ");
//     opc = Convert.ToInt32(Console.ReadLine());

//     if (opc == 1)
//     {
//         Console.WriteLine("Informe quanto deseja depositar (R$): ");
//         double ValorDeposito = Convert.ToDouble(Console.ReadLine());
//         saldo += ValorDeposito;
//         Console.WriteLine($"Depósito de R${ValorDeposito} realizado com sucesso!");
//     } else if (opc == 2)
//     {
//         Console.WriteLine("Informe quanto deseja sacar (R$): ");
//         double valorSaque = Convert.ToDouble(Console.ReadLine());
//         if (valorSaque > saldo)
//         {
//             Console.WriteLine("Saldo insuficiente para saque!");
//         } else
//         {
//             saldo -= valorSaque;
//             Console.WriteLine($"Saque de R${valorSaque} realizado com sucesso!");
//         }
//     } else if (opc == 3)
//     {
//         Console.WriteLine($"Seu saldo atual é igual a R${saldo}!");
//     } else if (opc == 4) 
//     {
//         Console.WriteLine("Até a próxima!");
//     } else
//     {
//         Console.WriteLine("Opção inválida! Tente novamente!");
//     }
// }
