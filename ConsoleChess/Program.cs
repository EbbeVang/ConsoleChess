using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess
{
    class Program
    {
        private static ChessPiece[,] chessBoard = new ChessPiece[8, 8];
        
        static void Main(string[] args)
        {
            // if you don't want to use enums you can use constants
            //const int KING = 1;
            //Console.WriteLine(KING);
            
            //creATE CHESSBOARD
            
           

            fillChessBoard(chessBoard);

            presentChessBoard(chessBoard);

            while (true)
            {
                string input = Console.ReadLine();
                string from = input.Substring(0, 2);
                string to = input.Substring(2, 2);
                Console.WriteLine("from: {0}", from);
                Console.WriteLine("to: {0}", to);
                makeMove(from, to);

                presentChessBoard(chessBoard);
            }}

            public static Boolean makeMove(string from, string to)
            {
                int fromNummber = Convert.ToInt32( from.Substring(1,1))-1;
                int fromLetter = Convert.ToChar(from.Substring(0, 1))-1;
                fromLetter -= 96;

                int toNumber = Convert.ToInt32(to.Substring(1,1))-1;
                int toLetter = Convert.ToChar(to.Substring(0,1))-1;
                toLetter -= 96;
                Console.WriteLine(toLetter);
                chessBoard[toLetter, toNumber] = chessBoard[fromLetter, fromNummber];
                chessBoard[fromLetter, fromNummber] = ChessPiece.Empty;

                return true;

                
            }

           // Console.WriteLine(view(ChessPiece.Castle));
        

        private static void fillChessBoard(ChessPiece[,] chessBoard)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    chessBoard[i, j] = ChessPiece.Empty;
                }

            }

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
            for (int i = 0; i < 8; i++)
            {
                Console.Write("   "+(i+1));
            }
            Console.WriteLine();

            
            Console.WriteLine(" ---------------------------------");
            for (int i = 0; i < 8; i++)
            
            {
                Console.Write(Convert.ToChar(97+i));
                Console.Write("| ");
                for (int j = 0; j < 8; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(view(chessBoard[i, j]));
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.Write(" | ");

                }
                Console.WriteLine();
                Console.WriteLine(" ---------------------------------");
            }
        }
        
        private static String view(ChessPiece myEnum)
        {
            if (myEnum == ChessPiece.Empty) return " ";
            return myEnum.ToString().Substring(0, 1);
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
