Console.WriteLine("Atividade 1");
//Atividade 1
float investimento = 1000;
float variação_dia1 = -3.4f;
float variação_dia2 = 2.8f;
float variação_dia3 = 14f;
float variação_dia4 = -8.5f;

float valor_dia1 = investimento * (1 + variação_dia1 / 100);
float valor_dia2 = valor_dia1 * (1 + variação_dia2 / 100);
float valor_dia3 = valor_dia2 * (1 + variação_dia3 / 100);
float valor_atual = valor_dia3 * (1 + variação_dia4 / 100);

Console.WriteLine("O valor atual dos investimentos de Marquesito é R$" + valor_atual.ToString("0.00"));

Console.WriteLine("Atividade 2");

//Atividade 2 
Console.WriteLine("Digite seu salário: ");
float salário = int.Parse(Console.ReadLine());
float aumento = salário * 0.25f;
float total = salário + aumento;
Console.WriteLine("O salário pós aumento é " + total.ToString("0.00"));

Console.WriteLine("Atividade 3");

//Atividade 3 
Console.WriteLine("Digite o número desejado: ");
int numero = int.Parse(Console.ReadLine());
numero = (numero * 3 + 1) + (numero * 2 - 1);
Console.WriteLine("A soma do sucessor do triplo com o antecessor do dobro é: " + numero.ToString());


