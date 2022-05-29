
using static System.Console;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


   
int idadeMin = 0;
int idadeMax = 0;
int mediaAluno = 0;

WriteLine("Escreva a primeira idade");
idadeMin = Convert.ToInt32(ReadLine());

WriteLine("Escreva a segunda idade");
idadeMax = Convert.ToInt32(ReadLine());

mediaAluno = (idadeMax + idadeMin) / 2;

WriteLine($"A media da faculdade é: {mediaAluno}");
 


