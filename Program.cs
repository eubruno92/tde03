// 1 - Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior
// Encontre o maior dentre 3 números:
// Primeiro Número : 65465
// Segundo Número : 64658
// Terceiro Número : 65464
// O primeiro número : 65465 é o maior

// solicite que insira tres numeros:
// Console.WriteLine("Primeiro Número: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Segundo Número: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Terceiro Número: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// primeiro assumimos que o num1 é o maior

// int maior = num1;

//comparamos o maior atual com num2
// if (num2 > maior)
// {
//     maior = num2;
// }
// comparamos o maior atual (que pode ser o num1 ou num2) com o num3
// if (num3 > maior)
// {
//     maior = num3;
// }
// exibir o maior
// Console.WriteLine($"O maior número é: {maior}");





// 2 - Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop 
// while, do-while e for.
// Os 10 primeiros números naturais são :
// 1 2 3 4 5 6 7 8 9 10
// A soma dos números é : 55

// Usando 'WHILE'

// int soma = 0;
// int numero = 1;

// Console.WriteLine("Os 10 primeiros números naturais são :");
// while (numero <= 10)
// {
//     Console.Write(numero + " ");
//     soma += numero;
//     numero++;
// }
// Console.WriteLine("\nA soma dos números é: " + soma);

// Usando 'DO-WHILE'

// int soma = 0;
// int numero = 1;

// Console.WriteLine("Os 10 primeiros números naturais são :");
// do
// {
//     Console.Write(numero + " ");
//     soma += numero;
//     numero++;
// } while (numero <= 10);
// Console.WriteLine("\nA soma dos números é : " + soma);

// Usando 'FOR'

// int soma = 0;

// Console.WriteLine("Os 10 primeiros números naturais são :");
// for (int numero = 1; numero <= 10; numero++)
// {
//     Console.Write(numero + " ");
//     soma += numero;
// }
// Console.WriteLine("\nA soma dos números é : " + soma);




// 3 - Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero 
// recebido via teclado 
// - Verifique se o número é maior que zero e emita uma mensagem
// - Considere a tabela de multiplicação de 1 até 10
// - Após exibir a tabela torne a solicitar outro número 
// - Para sair do loop defina uma condição de saída 
// Dica: Use os loop while e for e para sair a instrução break;

// while (true)
// {
//     Console.Write("Digite um número natural maior que zero (ou digite 0 para sair): ");
//     int numero;
//     if (!int.TryParse(Console.ReadLine(), out numero))
//     {
//         Console.WriteLine("Por favor, digite um número válido.");
//         continue;
//     }
//     if (numero == 0) break; // Condição de saída.
//     if (numero < 0)
//     {
//         Console.WriteLine("O número deve ser maior que zero. Tente novamente.");
//         continue;
//     }
//     Console.WriteLine($"Tabela de multiplicação para {numero}:");
//     for (int i = 1; i <= 10; i++)
//     {
//         Console.WriteLine($"{numero} x {i} = {numero * i}");
//     }
// }
//     Console.WriteLine("Programa encerrado.");




// 4- Crie um programa para exbir no console os números pares de 10 a 20, ambos incluídos, exceto 16, de 3 
// maneiras diferentes:
//- Incrementando 2 em cada passo
// for (int i = 10; i <=20; i +=2)
// {
//     if (i !=16)
//     {
//         Console.WriteLine(i);
//     }
// }
//- Incrementando 1 em cada passo 
// for (int i = 10; i <= 20; i++)
// {
//     if (i % 2 == 0 && i != 16)
//     {
//         Console.WriteLine(i);
//     }
// }
//- Com e loop infinito (use "break" e "continue")
// int i = 10;
// while (true)
// {
//     if (i > 20) break;
//     if (i == 16)
//     {
//         i++;
//         continue;
//     }
//     if (i % 2 == 0)
//     {
//         Console.WriteLine(i);
//     }
//     i++;
// }






// 5 - Escreva um programa para calcular o fatorial de um número inteiro. 
// O fatorial de um número é representado por : n! => n * (n – 1) * (n – 2) ....2*1 
// Exemplo : fatorial de 6 é representado por 6! = 6*5*4*3*2*1

// Console.Write("Digite um número inteiro para calcular o fatorial: ");
// int numero = Convert.ToInt32(Console.ReadLine());
// long fatorial = 1;
// for(int i = numero; i >= 1; i--)
// {
//     fatorial *= i;
// }
// Console.WriteLine($"{numero}! = {fatorial}");






// 6 - Escreva um programa para exibir as tabelas de multiplicação do 2 ao 6 usando o loop do-while aninhado
// Modelo de saída
// 2 x 1 = 2
// 2 x 2 = 4
// 2 x 3 = 6
// 2 x 4 = 8
// 2 x 5 = 10
// 2 x 6 = 12
// 2 x 7 = 14
// 2 x 8 = 16
// 2 x 9 = 18
// 2 x 10 = 20
// 3 x 1 = 3
// 3 x 2 = 6
// 3 x 3 = 9
// 3 x 4 = 12
// 3 x 5 = 15
// 3 x 6 = 18
// 3 x 7 = 21
// 3 x 8 = 24
// 3 x 9 = 27
// 3 x 10 = 30
// int numero = 2;
// do
// {
//     int multiplicador = 1;
//     do
//     {
//     Console.WriteLine($"{numero} x {multiplicador} = {numero * multiplicador}");
//     multiplicador++;
//     } while (multiplicador <= 10); 
//     Console.WriteLine(); 
//     numero++;
// }
// while (numero <= 6);







// 7 - Crie um programa que recebe na entrada de dados um número inteiro de 0 a 10 que representa a nota de 
// um aluno. Com base na tabela a seguir imprima no console qual o resultado da avaliação do aluno. (Use a 
// instrução switch, break e default em um loop infinito e defina uma condição de saida.)

// while (true)
// {
//     Console.Write("Insira a nota do aluno (0 a 10) ou digite -1 para sair: ");
//     int nota = Convert.ToInt32(Console.ReadLine());
//     if (nota == -1)
//     {
//         Console.WriteLine("Saindo do programa...");
//         break;
//     }
//     switch (nota)
//     {
//         case 10:
//         Console.WriteLine("Avaliação: A+");
//         break;
//         case 9:
//         Console.WriteLine("Avaliação: A");
//         break;
//         case 7:
//         case 8:
//         Console.WriteLine("Avaliação: B");
//         break;
//         case 6:
//         Console.WriteLine("Avaliação: C");
//         break;                        
//         case 5:
//         Console.WriteLine("Avaliação: E");
//         break;
//         case 4:
//         case 3:
//         case 2:
//         case 1:
//         case 0:
//         Console.WriteLine("Avaliação: F");
//         break;
//         default:
//         Console.WriteLine("Nota inválida. Por favor, insira uma nota entre 0 e 10.");
//         break;        
//     }
// }








// 8 - Crie um programa para realizar as operações de adição, subtração, multiplicação e divisão de números 
// inteiros. (considere que na divisão podemos ter números fracionários e que não existe divisão por zero e 
// quando isso ocorrer exibir uma mensagem de alerta

// Console.WriteLine("Informe o primeiro número:");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Informe o operando (+, -, /, *):");
// char operando = Convert.ToChar(Console.ReadLine());

// Console.WriteLine("Informe o segundo número:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// switch (operando)
// {
//     case '+':
//         Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
//         break;
//         case '-':
//         Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
//         break;
//         case '*':
//         Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
//         break;
//         case '/':
//             if (num2 == 0)
//             {
//                 Console.WriteLine("Não existe divisão por zero!!!");
//             }
//             else
//             {
//                 double resultado = (double)num1 / num2;
//                 Console.WriteLine($"{num1} / {num2} = {resultado}");
//             }
//         break;
//         default:
//         Console.WriteLine("Operando inválido.");
//         break;
// }