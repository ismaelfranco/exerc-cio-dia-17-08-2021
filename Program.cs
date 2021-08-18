using System;

namespace exemplo_01
{
    class Program
    {
        static void Main(string[] args)
        {
       string nome;
       float matricula, nota1, nota2, media;

       Console.Write("Digite o nome do aluno: ");
       nome = Console.ReadLine();

       Console.Write("Digite o número de matrícula do aluno: ");
       matricula = float.Parse(Console.ReadLine());

       Console.Write("Digite a nota do 1º Bimestre: ");
       nota1 = float.Parse(Console.ReadLine());

       Console.Write("Digite a nota do 2º Bimestre: ");
       nota2 = float.Parse(Console.ReadLine());

       media = (nota1 + nota2)/2;

       if ( media >= 6)
       {
           Console.Write($"Aluno, {nome}. Aprovado com média final {media}");
       }

       else 
       {
           Console.Write($"Aluno, {nome}. Reprovado com média final {media}");
       }
        }
    }
}
