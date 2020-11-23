using System;

namespace Function_ClassAverageGrade_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[11];
            float[] nota1 = new float[11];
            float[] nota2 = new float[11];
            float[] nota3 = new float[11];
            float[] nota4 = new float[11];
            float[] media = new float[11];



            for (var i = 1; i <= 10; i++)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Digite a NOME do(a) {i}º aluno(a)");
                nome[i] = Console.ReadLine();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("");

                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Digite a PRIMEIRA nota do(a) aluno(a) {nome[i]}");
                nota1[i] = float.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------------");


                Console.WriteLine($"Digite a SEGUNDA nota do(a) aluno(a) {nome[i]}");
                nota2[i] = float.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------------");


                Console.WriteLine($"Digite a TERCEIRA nota do(a) aluno(a) {nome[i]}");
                nota3[i] = float.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------------");


                Console.WriteLine($"Digite a QUARTA nota do(a) aluno(a) {nome[i]}");
                nota4[i] = float.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("");


                media[i] = (nota1[i] + nota2[i] + nota3[i] + nota4[i]) / 4;
                
            }

            for (var i = 1; i <= 10; i++)
            {

                Console.WriteLine("");

                if (media[i] > 7)
                {
                    Console.Write($"A media do(a) aluno(a) {nome[i]} foi : {media[i]}");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" (ALUNO(A) APROVADO(A))");
                    Console.ResetColor();
                }

                else
                {
                    Console.Write($"A media do(a) aluno(a) {nome[i]} foi : {media[i]}");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" (ALUNO(A) REPROVADO)");
                    Console.ResetColor();
                }

                Console.WriteLine();

                float mediageral = (media[1] + media[2] + media[3] + media[4] + media[5] + media[6] + media[7] + media[8] + media[9] + media[10]) / 10;

                Console.WriteLine("A média geral da turma foi: " + mediageral);
                
            }

        }

    }

}
                
                
                
            



                


