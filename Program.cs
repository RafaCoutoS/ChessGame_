using ChessGame_.Xadrez;
using System;
using tabuleiro;
using Xadrez;


namespace ChessGame_
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());

            Console.ReadLine();

        }
    }
}



