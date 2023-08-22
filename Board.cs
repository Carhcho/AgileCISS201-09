using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox09
{
    public enum CellValue { E, X, O}
    class Board
    {
        //field
        private CellValue[ , ] allCells;
        //property
        public CellValue[ , ] AllCells
        {
            get { return allCells; }
            set { allCells = value; }
        }
        //constructor
        public Board()
        {
            allCells = new CellValue[3,3];
        }
        //methods
        public bool HasNoMoreE()
        {
            bool noMoreE = true;
            for (int r=0; r<3; r++)
            {
                for (int c=0; c<3; c++)
                {
                    if (allCells[r, c] == CellValue.E)
                        noMoreE = false;
                }
            }
            return noMoreE;
        }
        public override string ToString()
        {
            string str;
            str = AllCells[0, 0] + " | " + AllCells[0, 1] + " | " + AllCells[0, 2] + "\n----------\n" +
                  AllCells[1, 0] + " | " + AllCells[1, 1] + " | " + AllCells[1, 2] + "\n----------\n" +
                  AllCells[2, 0] + " | " + AllCells[2, 1] + " | " + AllCells[2, 2];
            return str;
        }
    }
}
