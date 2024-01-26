using System;
using tabuleiro;
using xadrez;


namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            PosicaoXadrez pod = new PosicaoXadrez('c', 7);
            Console.WriteLine(pod);
            Console.WriteLine(pod.toPosicao());
            Console.ReadLine();
        }
    }
}
