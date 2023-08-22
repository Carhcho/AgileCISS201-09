using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tic Tac Toe";
            Board board = new Board();
            Console.WriteLine(board);
            CellValue playerName = CellValue.X;
            int row;
            int column;
            bool playerWins = false;
            bool stalemate = false;
            while (!(playerWins || stalemate))
            {
                do
                {
                    Console.WriteLine("Player " + playerName + " moves");
                    Console.WriteLine("Enter row number (0,1,2): ");
                    row = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter column number (0,1,2): ");
                    column = int.Parse(Console.ReadLine());
                    if (board.AllCells[row, column] != CellValue.E)
                        Console.WriteLine("Invalid move.");
                } while (board.AllCells[row, column] != CellValue.E);

                Player player = new Player(row, column, playerName);
                player.PlayerMove(board);
                Console.WriteLine(board);
                playerWins = player.IsPlayerWin(board);
                stalemate = board.HasNoMoreE();
                if (playerWins)
                    Console.WriteLine("Player " + playerName + " wins.");
                if (stalemate)
                    Console.WriteLine("Stalemate!");
                playerName = (playerName == CellValue.X) ?
                    CellValue.O : CellValue.X;
            }
            Console.ReadKey();
        }
    }
}
