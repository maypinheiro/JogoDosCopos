using System;

namespace JogoDosCopos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            char posicao = char.Parse(Console.ReadLine().ToUpper());

            for (int i = 0; i < numero; i++)
            {
                int troca = int.Parse(Console.ReadLine());

                if (troca == 1 && (posicao == 'A' || posicao == 'B'))
                    posicao = (posicao == 'A' ? 'B' : 'A');
                else if (troca == 2 && (posicao == 'B' || posicao == 'C'))
                    posicao = (posicao == 'B' ? 'C' : 'B');
                else if (troca == 3 && (posicao == 'A' || posicao == 'C'))
                    posicao = (posicao == 'C' ? 'A' : 'C');
            }

            Console.WriteLine(posicao); 
        }
    }
}
