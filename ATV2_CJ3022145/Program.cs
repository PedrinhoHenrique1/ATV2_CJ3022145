/*Console.WriteLine("Atividade 1");
//Atividade 1 - Sala
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

//Atividade 2 - Sala
Console.WriteLine("Digite seu salário: ");
float salário = int.Parse(Console.ReadLine());
float aumento = salário * 0.25f;
float total = salário + aumento;
Console.WriteLine("O salário pós aumento é " + total.ToString("0.00"));

Console.WriteLine("Atividade 3");

//Atividade 3 - Sala
Console.WriteLine("Digite o número desejado: ");
int numero = int.Parse(Console.ReadLine());
numero = (numero * 3 + 1) + (numero * 2 - 1);
Console.WriteLine("A soma do sucessor do triplo com o antecessor do dobro é: " + numero.ToString());

//Atividade 1 - Lista
using System.Runtime.InteropServices;

Console.WriteLine("Digite o seu valor em metros: ");
double quantidade = double.Parse(Console.ReadLine());
double centimetros = quantidade / 100;
double milimetros = quantidade / 1000;

Console.WriteLine("O seu valor em centímetros é: " + centimetros.ToString("0.00"));
Console.WriteLine("O seu valor em milímetros é: " + milimetros.ToString("0.00"));
Console.ReadKey();

//Atividade 2 - Lista
Console.WriteLine("Digite o valor em Fahrenheit: ");
float f_graus = float.Parse(Console.ReadLine());
float c_graus;

Console.WriteLine("Digite o valor novamente: ");
int f_graus1 = int.Parse(Console.ReadLine());
int c_graus1;

c_graus = (f_graus - 32.0f) * (5.0f / 9.0f);
c_graus1 = (f_graus1 - 32) * (5 / 9);
Console.WriteLine("O resultado em celsius com float é: {0} \n O resultado em celsius com inteiro é: {1}", c_graus, c_graus1);


//Atividade 3 - Lista
Console.WriteLine("Digite sua altura em metros: ");
float altura = float.Parse(Console.ReadLine());
Console.WriteLine("Digite seu peso em kilos: ");
float peso = float.Parse(Console.ReadLine());
float imc;
imc = peso / (altura * altura);
Console.WriteLine("O seu IMC é: " + imc.ToString());



//Atividade 4 - Lista
Console.WriteLine("Digite a primeira nota: ");
 float nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o peso da primeira nota: ");
float peso1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota: ");
float nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o peso da segunda nota: ");
float peso2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a terceira nota: ");
float nota3 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o peso da terceira nota: ");
float peso3 = float.Parse(Console.ReadLine());
float total;

total = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2 + peso3);
Console.WriteLine("A média poderada dos pesos é: " + total.ToString());

//Atividade 5 - Lista (Fórmula da velocidade)
Console.WriteLine("Digite a distância percorrida: ");
float distância = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o tempo que foi gasto na ação em segundos: ");
float tempo = float.Parse(Console.ReadLine());
float velocidade;

velocidade = (distância / tempo);
Console.WriteLine("A velocidade em a ocorreu a ação foi de: " + velocidade.ToString());
*/
//Atividade 6 -  Lista
Console.WriteLine("Digite seu salário: ");
float salário = int.Parse(Console.ReadLine());
float aumento = salário * 0.25f;
float total = salário + aumento;
Console.WriteLine("O salário pós aumento é " + total.ToString("0.00"));

//Atividade 7 - Lista 
Console.WriteLine("Digite o valor a ser convertido em reais: ");
double real = double.Parse(Console.ReadLine());
double valor_dolar = 4.97;
double dolar;

dolar = real / valor_dolar;
Console.WriteLine("O valor em real convertido para dólar é: " + dolar.ToString());

//Atividade 8 - Lista
Console.WriteLine("Digite o número desejado: ");
int numero = int.Parse(Console.ReadLine());
numero = (numero * 3 + 1) + (numero * 2 - 1);
Console.WriteLine("A soma do sucessor do triplo com o antecessor do dobro é: " + numero.ToString());

//Atividade 9 - Lista
