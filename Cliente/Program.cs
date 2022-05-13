// See https://aka.ms/new-console-template for more information
using System;


Console.WriteLine("Bem-vindo ao Sistema de Clientes");
Console.WriteLine();
Console.WriteLine("Favor indicar os dados do cliente:");
Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("CPF: ");
long cpf = long.Parse(Console.ReadLine());
Console.Write("Data de Nascimento: ");
DateTime dataNasc = DateTime.Parse(Console.ReadLine());
Console.Write("Renda mensal: ");
double renda = double.Parse(Console.ReadLine());
Console.Write("Estado civil: ");
char edoCiv = char.Parse(Console.ReadLine());
Console.Write("Dependentes: ");
int depend = int.Parse(Console.ReadLine()); 

//try
//{
//    Cliente cliente = new Cliente(nome, cpf, dataNasc, renda, edoCiv, depend);

//} catch (DomainException ex)
//{
//    Console.WriteLine(ex.Message);  
//}
