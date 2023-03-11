﻿using ChessGame_.Xadrez;
using System;
using tabuleiro;
using Xadrez;


namespace ChessGame_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).MovimentosPossiveis();

                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab, posicoesPossiveis);

                    Console.Write("Destino: ");
                    Posicao destinho = Tela.LerPosicaoXadrez().ToPosicao();

                    partida.ExecutaMovimento(origem, destinho);
                }
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();


        }
    }
}



