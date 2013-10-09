using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            // if you don't want to use enums you can use constants
            //const int KING = 1;
            //Console.WriteLine(KING);
            
            //creATE CHESSBOARD
            ChessPiece[,] chessBoard = new ChessPiece[8,8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j<8; j++)
                {
                    chessBoard[i, j] = ChessPiece.Empty;
                }

            }

            fillChessBoard(chessBoard);


            presentChessBoard(chessBoard);

           // Console.WriteLine(view(ChessPiece.Castle));
        }

        private static void fillChessBoard(ChessPiece[,] chessBoard)
        {
            //FILL CHESSBOARD WITH PIECES
            chessBoard[0, 0] = ChessPiece.Castle;
            chessBoard[0, 1] = ChessPiece.Horse;
            chessBoard[0, 2] = ChessPiece.Bishop;
            chessBoard[0, 3] = ChessPiece.Queen;
            chessBoard[0, 4] = ChessPiece.King;
            chessBoard[0, 5] = ChessPiece.Bishop;
            chessBoard[0, 6] = ChessPiece.Horse;
            chessBoard[0, 7] = ChessPiece.Castle;

            for (int i = 0; i < 8; i++)
            {
                chessBoard[1, i] = ChessPiece.Pawn;
            }

            for (int i = 0; i < 8; i++)
            {
                chessBoard[6, i] = ChessPiece.Pawn;
            }

            chessBoard[7, 0] = ChessPiece.Castle;
            chessBoard[7, 1] = ChessPiece.Horse;
            chessBoard[7, 2] = ChessPiece.Bishop;
            chessBoard[7, 3] = ChessPiece.Queen;
            chessBoard[7, 4] = ChessPiece.King;
            chessBoard[7, 5] = ChessPiece.Bishop;
            chessBoard[7, 6] = ChessPiece.Horse;
            chessBoard[7, 7] = ChessPiece.Castle;
        }

        private static void presentChessBoard(ChessPiece[,] chessBoard)
        {
            //PRINT CHESSBOARD
            Console.WriteLine("-----------------------------------------");
            for (int i = 0; i < 8; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < 8; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(view(chessBoard[i, j]));
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.Write(" | ");

                }
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------");
            }
        }
        
        private static String view(ChessPiece myEnum)
        {
            if (myEnum == ChessPiece.Empty) return "  ";
            return myEnum.ToString().Substring(0, 2);
        }

        
    }

    enum ChessPiece { 
        Pawn = 1,
        Castle = 2,
        Horse = 3,
        Bishop = 4,
        Queen = 5,
        King = 6,
        Empty = 7

    }
}
