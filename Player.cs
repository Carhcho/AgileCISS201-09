using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox09
{
    class Player
    {
        //fields
        private CellValue playerName;
        private int selectedRow;
        private int selectedColumn;
        public CellValue PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }
        public int SelectedRow
        {
            get { return selectedRow; }
            set { selectedRow = value; }
        }
        public int SelectedColumn
        {
            get { return selectedColumn; }
            set { selectedColumn = value; }
        }
        public Player(int selectedRow, int selectedColumn, CellValue playerName)
        {
            this.selectedRow = selectedRow;
            this.selectedColumn = selectedColumn;
            this.playerName = playerName;
        }
        public void PlayerMove(Board board)
        {
            board.AllCells[SelectedRow, SelectedColumn] = PlayerName;
        }
        public bool IsPlayerWin(Board board)
        {
            bool wins = false;
            if (board.AllCells[0, 0] != CellValue.E &&
                board.AllCells[0, 0] == board.AllCells[1, 1] &&
                board.AllCells[1, 1] == board.AllCells[2, 0])
            {
                wins = true;
            }
            if (board.AllCells[0, 2] != CellValue.E &&
                board.AllCells[0, 2] == board.AllCells[1, 1] &&
                board.AllCells[1, 1] == board.AllCells[2, 0])
            {
                wins = true;
            }
            for (int r = 0; r < 3; r++)
            {
                if (board.AllCells[r, 0] != CellValue.E &&
                board.AllCells[r, 0] == board.AllCells[r, 1] &&
                board.AllCells[r, 1] == board.AllCells[r, 2])
                {
                    wins = true;
                }
            }
            for (int c = 0; c < 3; c++)
            {
                if (board.AllCells[0, c] != CellValue.E &&
                board.AllCells[0, c] == board.AllCells[1, c] &&
                board.AllCells[1, c] == board.AllCells[2, c])
                {
                    wins = true;
                }
            }
            return wins;
        }
    }
}
